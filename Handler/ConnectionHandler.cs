using System;
using System.Collections.Generic;
using System.Threading;
using EngineDestroyer.Network;

namespace EngineDestroyer.Handler {
    public class ConnectionHandler {
        public EventHandler<ConnectionArgs> ChangedStatus { get; set; }
        public int Count => connections.Count;
        public bool Running { get; set; }
        public int MaxConnections { get; set; }
        public string IpAddress { get; set; } = string.Empty;
        public int Port { get; set; }
        public int NewConnectionTime { get; set; }

        private List<Connection> connections;
        private Thread newConnectionThread;
        private Thread checkConnectionThread;

        public void Start() {
            Running = true;

            if (connections == null) {
                connections = new List<Connection>(MaxConnections);
            }
            else {
                connections.Clear();           
            }

            FillConnectionList();

            newConnectionThread = new Thread(CreateConnections);
            checkConnectionThread = new Thread(CheckConnections);

            newConnectionThread.Start();
            checkConnectionThread.Start();
        }

        public void Stop() {
            Running = false;

            Disconnect();

            newConnectionThread?.Abort();
            checkConnectionThread?.Abort();
        }

        public void Clear() {
            connections?.Clear();
        }

        public Connection GetValidConnection() {
            for (var i = 0; i < MaxConnections; i++) {
                if (connections[i] != null) {
                    if (connections[i].Connected) {
                        return connections[i];
                    }
                }
            }

            return null;
        }

        public List<Connection> GetConnections() {
            return connections;
        }

        private void Disconnect() {
            if (connections != null) {
                if (connections.Count > 0) {
                    for (var i = 0; i < MaxConnections; ++i) {
                        if (connections[i] != null) {
                            connections[i].Disconnect();
                        }
                    }
                }
            }
        }

        private void FillConnectionList() {
            for (var i = 0; i < MaxConnections; ++i) {
                var connection = new Connection();
                connection.ChangedStatus += ChangedStatus;
                connection.Index = i;

                connections.Add(connection);
            }
        }

        private void CreateConnections() {
            while (Running) {
                
                for (var i = 0; i < MaxConnections; ++i) {
                    if (connections[i] != null) {
                        if (!connections[i].Connected) {
                            connections[i].Connect(IpAddress, Port);

                            Thread.Sleep(NewConnectionTime);
                        }
                    }
                }

                Thread.Sleep(1);
            }
        }

        private void CheckConnections() {
            while (Running) {

                if (connections != null) {
                   for (var i = 0; i < MaxConnections; ++i) {
                        if (connections[i] != null) {
                            if (connections[i].Connected) {
                                connections[i].CheckSocketState();
                            }
                        }
                    }
                }

                Thread.Sleep(5000);
            }
        }
    }
}