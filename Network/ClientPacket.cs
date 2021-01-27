using EngineDestroyer.Handler;

namespace EngineDestroyer.Network {
    public abstract class ClientPacket {
        public int Size => msg.Length();

        protected ByteBuffer msg;

        public ClientPacket() {
            msg = new ByteBuffer();
        }

        public void Send(Connection connection) {
            connection.Send(msg);
        }

        public int SendToAll() {
            var count = 0;
            var connections = GlobalHandler.ConnectionHandler.GetConnections();

            if (connections != null) {
                for (var i = 0; i < connections.Count; ++i) {
                    if (connections[i] != null) {
                        if (connections[i].Connected) {
                            Send(connections[i]);
                            ++count;
                        }
                    }
                }
            }

            return count;
        }

 
    }
}