using System;
using System.Windows.Forms;

namespace EngineDestroyer {
    /// <summary>
    /// Mensagens enviadas pelo broadcast, aparecem no chat para todos. 
    /// Mas, os pacotes SayMsg e EmoteMsg aparecem apenas no servidor e são salvos no log.
    /// PlayerMsg envia a mensagem para determinado jogador conectado no jogo.
    /// </summary>
    public partial class FrmChat : Form {
        /// <summary>
        /// Cabeçalho da mensagem.
        /// </summary>
        private byte header = 0;

        /// <summary>
        /// Quantidade de vezes que a mensagem foi enviada.
        /// </summary>
        private int sendCount = 0;

        /// <summary>
        /// Ativa ou desativa o overflow no pacote.
        /// </summary>
        private bool overflow = false;

        /// <summary>
        /// Quando ativo usa todas as conexões disponíveis para entregar o pacote.
        /// </summary>
        private bool allConnections = false;

        /// <summary>
        /// Quando ativado, entra em um loop de mensagens.
        /// </summary>
        private bool loop = false;

        /// <summary>
        /// Indice para percorrer as conexões.
        /// </summary>
        private int connectionIndex = 0;

        /// <summary>
        /// Mensagem de texto.
        /// </summary>
        private string message = string.Empty;

        /// <summary>
        /// Nome do jogador (Alvo).
        /// </summary>
        private string target = string.Empty;

        /// <summary>
        /// Pacote de dados para envio.
        /// </summary>
        private byte[] packet;

        public FrmChat() {
            InitializeComponent();
        }

        /// <summary>
        /// Define os dados padrão das variaveis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmChatcs_Load(object sender, EventArgs e) {
            cmb_msgtype.SelectedIndex = 0;
            header = (byte)ClientPacket.CSayMsg;
        }

        /// <summary>
        /// Troca o tipo de mensagem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_msgtype_SelectedIndexChanged(object sender, EventArgs e) {
            var index = cmb_msgtype.SelectedIndex;

            switch (index) {
                case 0:
                    header = (byte)ClientPacket.CSayMsg;
                    lbl_header.Text = "Header: " + header;
                    break;
                case 1:
                    header = (byte)ClientPacket.CEmoteMsg;
                    lbl_header.Text = "Header: " + header;
                    break;
                case 2:
                    header = (byte)ClientPacket.CPlayerMsg;
                    lbl_header.Text = "Header: " + header;
                    break;
                case 3:
                    header = (byte)ClientPacket.CBroadcastMsg ;
                    lbl_header.Text = "Header: " + header;
                    break;
            }
        }

        /// <summary>
        /// Envia a mensagem por um loop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            //envia os dados por todas as conexões
            if (allConnections) {
                SendDataToAll();
            }

            //usa uma conexão por vez
            if (!allConnections) {
                if (connectionIndex >= Program.Connections.MaxConnection - 1) {
                    connectionIndex = 0;
                }

                SendData(connectionIndex, packet);
                connectionIndex++;
            }
        }

        /// <summary>
        /// Envia os dados pelo socket.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="buffer"></param>
        private void SendData(int index, byte[] buffer) {
            if (Program.Connections == null) {
                MessageBox.Show("Connect to server before send some packet.", "Message");
                StopSend();
                return;
            }

            if (Program.Connections[index].Connected) {
                Program.Connections[index].Send(buffer);

                lbl_totalsize.Text = "Total Size: " + buffer.Length + " bytes";
                sendCount++;
                lbl_send.Text = "Send Count: " + sendCount;
            }
        }

        /// <summary>
        /// Envia os dados por todas as conexões
        /// </summary>
        private void SendDataToAll() {
            for (var n = 0; n < Program.Connections.MaxConnection; n++) {
                if (Program.Connections[n].Connected) {
                    SendData(n, packet);
                }
            }
        }

        /// <summary>
        /// Ativa ou desativa o overflow no pacote.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_overflow_CheckedChanged(object sender, EventArgs e) {
            overflow = chk_overflow.Checked;
        }

        /// <summary>
        /// Ativa o loop de mensagens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_loop_CheckedChanged(object sender, EventArgs e) {
            loop = chk_loop.Checked;

            if (loop) {
                btn_send.Text = "Start";
            } 
            else {
                btn_send.Text = "Send";
            }
        }

        /// <summary>
        /// Ativa todas as conexões para o uso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_allcon_CheckedChanged(object sender, EventArgs e) {
            allConnections = chk_allcon.Checked;
        }

        /// <summary>
        /// Altera o intervalo das mensagens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_loop_TextChanged(object sender, EventArgs e) {
            var result = 0;

            if (int.TryParse(txt_loop.Text, out result)) {
                timer1.Interval = result;
            } else {
                timer1.Interval = 2000;
            }
        }

        /// <summary>
        /// Desabilida os controles e ativa o timer.
        /// </summary>
        private void StartSend() {
            chk_loop.Enabled = false;
            cmb_msgtype.Enabled = false;
            txt_msg.Enabled = false;
            txt_target.Enabled = false;
            chk_overflow.Enabled = false;
            txt_loop.Enabled = false;

            timer1.Start();
            btn_send.Text = "Stop";
        }
        
        /// <summary>
        /// Habilita os controles e desativa o timer.
        /// </summary>
        private void StopSend() {
            txt_loop.Enabled = true;
            chk_overflow.Enabled = true;
            chk_loop.Enabled = true;
            cmb_msgtype.Enabled = true;
            txt_msg.Enabled = true;
            txt_target.Enabled = true;
            btn_send.Text = "Start";

            timer1.Stop();
        }

        /// <summary>
        /// Envia mensagem ou ativa o timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e) {
            message = txt_msg.Text.Trim();
            target = txt_target.Text.Trim();

            //já deixa o pacote pronto para ser enviado
            CreateBuffer();

            if (loop) {
                if (btn_send.Text == "Start") {
                    StartSend();
                }
                else {
                    StopSend();
                }          
            }
            else {
                //usa apenas uma conexão ativa para envia as mensagens.
                if (!allConnections) {
                    var freeSlot = 0;
  
                    for (var n = 0; n < Program.Connections.MaxConnection; n++) {
                        if (Program.Connections[n].Connected) {
                            freeSlot = n;
                            break;
                        }
                    }

                    SendData(freeSlot, packet);
                }
                else {
                    SendDataToAll();
                }
            }
        }

        /// <summary>
        /// Cria o array de bytes para ser enviado.
        /// </summary>
        private void CreateBuffer() {
            if (header == (byte)ClientPacket.CPlayerMsg) {
                packet = Packet.PlayerMessage(message, target, overflow); 
            }
            else {
                packet = Packet.Message((ClientPacket)header, message, overflow);
            }
        }

        /// <summary>
        /// Permite que apenas números sejam inseridos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_loop_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Back) {
                e.Handled = false;
                return;
            }

            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}