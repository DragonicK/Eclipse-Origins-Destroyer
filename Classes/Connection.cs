using System;
using System.Net.Sockets;

namespace EngineDestroyer {
    public class Connection {
        private Socket socket;

        /// <summary>
        /// Obtem o estado da conexão
        /// </summary>
        public bool Connected { get; private set; } = false;
        
        /// <summary>
        /// ID de conexão.
        /// </summary>
        public int Index { get; set; }

        public Action<ConnectionArgs> StatusChanged;

        /// <summary>
        /// Guarda o último status do socket.
        /// </summary>
        private bool lastStatus = false;

        public Connection() {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Blocking = false;
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

        /// <summary>
        /// Envia os dados.
        /// </summary>
        /// <param name="buffer"></param>
        public void Send(byte[] buffer) {
            
            try {
                socket.Send(buffer);
            }
            catch (SocketException e) {
                if (e.NativeErrorCode.Equals(10035)) {
                    Connected = true;
                }
                else {
                    Connected = false;
                }
            }

            ChangeStatus(Connected);
        }

        /// <summary>
        /// Verifica se a conexão está ativa.
        /// </summary>
        /// <returns></returns>
        public void CheckSocketState() {
            bool result = true;

            try {
                byte[] tmp = new byte[1];
                socket.Send(tmp, 0, SocketFlags.None);
            }
            catch (SocketException e) {
                if (e.NativeErrorCode.Equals(10035)) {
                    result = true;
                }
                else {
                    result = false;
                }
            }

            Connected = result;

            //se houver alguma alteração, chama o evento
            ChangeStatus(result);
        }

        /// <summary>
        /// Recebe os dados.
        /// </summary>
        /// <returns></returns>
        public byte[] ReceiveData() {
            byte[] buffer = new byte[512];
          
            if (Connected) {
                if (socket.Available <= 0) { return new byte[1]; }

                try {
                    socket.Receive(buffer);
                }
                catch {

                }
            }

            return buffer;
        }

        private void ChangeStatus(bool status) {
            if (lastStatus != status) {
                lastStatus = status;
                StatusChanged?.Invoke(new ConnectionArgs(Index, status));
            }
        }
    }
}