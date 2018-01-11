using System;
using System.Windows.Forms;

namespace EngineDestroyer {
    /// <summary>
    /// Gera vários pacotes a partir do cabeçalho mínimo até o máximo.
    /// Tenta atacar todos os cabeçalhos do servidor para gerar algum erro.
    /// </summary>
    public partial class FrmRage : Form {
        /// <summary>
        /// Cabeçalho mínimo e máximo.
        /// </summary>
        private int headerFrom, headerTo;

        /// <summary>
        /// O conteúdo do pacote é basicamente vários dados de 4 bytes com valores máximos.
        /// Quantidade máxima de valores com 4 bytes.
        /// </summary>
        private int quantity;

        /// <summary>
        /// Contador de cabeçalho.
        /// </summary>
        private int headerCounter = 0;

        /// <summary>
        /// Tempo de envio de cada pacote.
        /// </summary>
        private int sendTime = 1000;

        public FrmRage() {
            InitializeComponent();


        }

        /// <summary>
        /// Envia os dados por todas as conexões abertas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            //se chegou no últmo cabeçalho estipulado, para de enviar os dados
            if (headerCounter > headerTo) {
                StopTimer();
            }

            //se não houver nenhuma conexão ativa, não faz nada
            if (Program.Connections == null) {
                MessageBox.Show("Connect to server before send some packet.", "Message");
                StopTimer();
                return;
            }

            //percorre todas as conexões, quando aberto, envia os dados
            for (var n = 0; n < Program.Connections.MaxConnection; n++) {
                if (Program.Connections[n].Connected) {
                    var buffer = Packet.CreateRagePacket(headerCounter, quantity);
                              
                    Program.Connections[n].Send(buffer);
  
                    lbl_totalsize.Text = "Packet Size: " + buffer.Length + " bytes";
                    lbl_header.Text = "Header: " + headerCounter;
                    lbl_send.Text = "Send Count: " + headerCounter;
                    headerCounter++;

                    //verifica novamente, se chegou no últmo cabeçalho estipulado, para de enviar os dados
                    if (headerCounter > headerTo) {
                        StopTimer();
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Desativa o timer e ativa as caixas de texto.
        /// </summary>
        private void StopTimer() {
            txt_min.Enabled = true;
            txt_max.Enabled = true;
            txt_quant.Enabled = true;
            txt_time.Enabled = true;
            btn_start.Text = "Start";
            timer1.Stop();
        }

        /// <summary>
        /// Ativa o timer e desativa as caixas de texto.
        /// </summary>
        private void StartTimer() {
            txt_min.Enabled = false;
            txt_max.Enabled = false;
            txt_quant.Enabled = false;
            txt_time.Enabled = false;
            btn_start.Text = "Stop";
            timer1.Start();
        }

        /// <summary>
        /// Ativa o timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e) {
            headerFrom = Convert.ToInt32(txt_min.Text.Trim());
            headerTo = Convert.ToInt32(txt_max.Text.Trim());
            quantity = Convert.ToInt32(txt_quant.Text.Trim());
            sendTime = Convert.ToInt32(txt_time.Text.Trim());

            headerCounter = headerFrom;
            timer1.Interval = sendTime;

            if (btn_start.Text == "Start") {
                StartTimer();
            }
            else {
                StopTimer();
            }
        }

        /// <summary>
        /// Todos os textbox são direcionados para este método.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllowOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e) {
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