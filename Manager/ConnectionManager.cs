using System.Drawing;
using System.Collections.Generic;
using System.Threading;

namespace EngineDestroyer {
    public class ConnectionManager {
        /// <summary>
        /// Quantidade máxima de conexões.
        /// </summary>
        public int MaxConnection { get; set; }

        /// <summary>
        /// IP do alvo.
        /// </summary>
        public string IpAddress { get; set; } = string.Empty;

        /// <summary>
        /// Porta do alvo.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Tempo para cada nova conexão.
        /// </summary>
        public int ConnectionTime { get; set; }

        /// <summary>
        /// Obtem a referência do socket.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Connection this[int index] {
            get {
                if (index < MaxConnection) {
                    return clients[index];
                }

                return null;
            }
        }

        // Lista de sockets.
        private List<Connection> clients;

        // Indica se o loop está em execução ou não.
        private bool running;
    
        private Thread t1, t2;

        /// <summary>
        /// Inicia e prepara a lista de clientes.
        /// </summary>
        /// <param name="maxConnections"></param>
        public ConnectionManager(int maxConnections) {
            MaxConnection = maxConnections;

            running = false;

            if (t1 != null) {
                t1.Abort();
            }

            if(t2 != null) {
                t2.Abort();
            }

            clients = new List<Connection>();

            for (var n = 0; n < maxConnections; n++) {
                clients.Add(new Connection());
                clients[n].Index = n;
                clients[n].StatusChanged += StatusChanged;
            }
        }

        /// <summary>
        /// Realiza a conexão com o alvo.
        /// </summary>
        public void Connect() {
            running = true;

            // Cria as conexões.
            t1 = new Thread(CreateConnection);
            t1.Start();

            // Verifica o estado do socket.
            t2 = new Thread(CheckConnectionState);
            t2.Start();
        }

        /// <summary>
        /// Fecha as conexões com o alvo e encerra a thread.
        /// </summary>
        public void Disconnect() {
            running = false;

            if (t1 != null) {
                t1.Abort();
            }

            if (t2 != null) {
                t2.Abort();
            }
        }

        /// <summary>
        /// Realiza a conexão com o alvo sempre verificando se foi perdida e conectando novamente.
        /// </summary>
        private void CreateConnection() {
              while (running) {

                for (var n = 0; n < MaxConnection; n++) {
                    if (!clients[n].Connected) {
                        clients[n].Connect(IpAddress, Port);
                    }

                    Thread.Sleep(ConnectionTime);
                }

                // Faz a thread dormir que não consuma muito processamento.
                Thread.Sleep(10);
            } 
        }

        /// <summary>
        /// Verifica o estado atual da conexão.
        /// </summary>
        private void CheckConnectionState() {
            while (running) {

                for (var n = 0; n < MaxConnection; n++) {
                    clients[n].CheckSocketState();
                }

                Thread.Sleep(2000);
            }
        }

        /// <summary>
        /// Chama o evento quando o status da conexão é alterado.
        /// </summary>
        /// <param name="e"></param>
        private void StatusChanged(ConnectionArgs e) {
            var color = (e.Connected) ? Color.DarkGreen : Color.DarkRed;
            var result = (e.Connected) ? "connected" : "disconnected";
            Program.MainForm.WriteLog($"Socket {e.Index}: {result}", color);
        }
    }
}