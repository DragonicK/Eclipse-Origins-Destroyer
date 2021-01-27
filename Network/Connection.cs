using System;
using System.Net.Sockets;

namespace EngineDestroyer.Network {
    public sealed class Connection {
        public const int ReceiveTimeOut = 15 * 1000 * 1000;
        public const int SendTimeOut = 15 * 1000 * 1000;
        public EventHandler<ConnectionArgs> ChangedStatus { get; set; }
        public bool Connected { get; private set; } = false;
        public int Index { get; set; }

        private bool lastStatus = false;
        private readonly Socket socket;

        public Connection() {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp) {
                Blocking = true
            };
        }

        public void Disconnect() {
            try {
                socket.Disconnect(true);
            }
            catch {

            }

            Connected = false;
            ChangeStatus(false);
        }
  
        public void Connect(string ip, int port) {        
            try {
                socket.Connect(ip, port);
                Connected = true;
            }
            catch {
                Connected = false;
            }

            ChangeStatus(Connected);
        }

        public void Send(ByteBuffer msg) {
            var buffer = new byte[msg.Length() + 4];
            var values = BitConverter.GetBytes(msg.Length());

            Array.Copy(values, 0, buffer, 0, 4);
            Array.Copy(msg.ToArray(), 0, buffer, 4, msg.Length());

            if (socket.Poll(SendTimeOut, SelectMode.SelectWrite)) {
                try {
                    socket.Send(buffer, SocketFlags.None);
                }
                catch {
                    Disconnect();
                }
            }
            else {
                Disconnect();
            }
        }

        public void CheckSocketState() {
            var msg = new ByteBuffer();

            msg.Write(0);
            msg.Write(0);

            Send(msg);
        }

        public void ReceiveData() {
            if (socket.Available > 0) {
                var size = socket.Available;
                var buffer = new byte[size];

                if (socket.Poll(ReceiveTimeOut, SelectMode.SelectRead)) {
                    try {
                        socket.Receive(buffer, size, SocketFlags.None);
                    }
                    catch {
                        Disconnect();
                    }
                }
                else {
                    Disconnect();
                }
            }
        }

        private void ChangeStatus(bool status) {
            if (lastStatus != status) {
                lastStatus = status;
                ChangedStatus?.Invoke(this, new ConnectionArgs(Index, status));
            }
        }
    }
}