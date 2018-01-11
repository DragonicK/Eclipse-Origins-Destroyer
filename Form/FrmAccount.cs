using System;
using System.Drawing;
using System.Windows.Forms;

namespace EngineDestroyer {
    public partial class FrmAccount : Form {
        bool closing = false;

        /// <summary>
        /// Ativa ou desativa o loop para enviar os dados.
        /// </summary>
        bool loop = false;

        /// <summary>
        /// Ativa ou desativa a geração de contas.
        /// </summary>
        bool generate = true;

        public FrmAccount() {
            InitializeComponent();
        }

        private void FrmAccount_Load(object sender, EventArgs e) {
            timer2.Start();
        }

        private void FrmAccount_FormClosing(object sender, FormClosingEventArgs e) {
            closing = true;
            timer2.Stop();
        }

        /// <summary>
        /// Escreve no log.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        private void WriteLog(string text, Color color) {
            if (closing) {
                return;
            }

            log_textbox.SelectionStart = log_textbox.TextLength;
            log_textbox.SelectionLength = 0;

            log_textbox.SelectionColor = color;
            log_textbox.AppendText($"{DateTime.Now}: {text}{Environment.NewLine}");
            log_textbox.SelectionColor = color;

            log_textbox.ScrollToCaret();
        }

        /// <summary>
        /// Envia dados para todas as conexões.
        /// </summary>
        /// <param name="packet"></param>
        private void SendDataToAll() {
            if (Program.Connections == null) {
                MessageBox.Show("Connect to server before send some packet.", "Message");
                return;
            }

            var account = string.Empty;

            for (var n = 0; n < Program.Connections.MaxConnection; n++) {
                if (Program.Connections[n].Connected) {
                    byte[] packet = new byte[1];

                    if (generate) {
                        account = AccountManager.GenerateAccount();
                        packet = Packet.CreateAccount(account);
                        txt_account.Text = account;
                        txt_password.Text = account;                    
                    }
                    else {
                        packet = Packet.CreateAccount(txt_account.Text, txt_password.Text);
                    }

                    Program.Connections[n].Send(packet);
                }
            }
        }

        #region CheckBox
        private void chk_generate_CheckedChanged(object sender, EventArgs e) {
            generate = chk_generate.Checked;

            txt_account.Enabled = !generate;
            txt_password.Enabled = !generate;
        }

        private void chk_loop_CheckedChanged(object sender, EventArgs e) {
            loop = chk_loop.Checked;

            if (loop) {
                btn_send.Text = "Start";
            }
            else {
                btn_send.Text = "Stop";
            }
        }
        #endregion

        /// <summary>
        /// Inicia o timer e envia os dados.
        /// </summary>
        private void StartSend() {
            txt_account.Enabled = false;
            txt_password.Enabled = false;
            txt_looptime.Enabled = false;
            chk_loop.Enabled = false;
            btn_send.Text = "Stop";

            timer1.Start();
        }

        /// <summary>
        /// Desativa o timer.
        /// </summary>
        private void StopSend() {
            txt_account.Enabled = !generate;
            txt_password.Enabled = !generate;
            txt_looptime.Enabled = true;
            chk_loop.Enabled = true;           
            btn_send.Text = "Start";

            timer1.Stop();
        }

        private void btn_send_Click(object sender, EventArgs e) {
            var loopTime = Convert.ToInt32(txt_looptime.Text.Trim());
            timer1.Interval = loopTime;

            if (Program.Connections == null) {
                MessageBox.Show("Connect to server before send some packet.", "Message");
                return;
            }

            if (loop) {
                if (btn_send.Text == "Start") {
                    StartSend();
                }
                else {
                    StopSend();
                }
            }
            else {
                SendDataToAll();
            }
        }

        /// <summary>
        /// Ativa o timer e envia os dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            SendDataToAll();
        }

        /// <summary>
        /// Permite apenas números no textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_looptime_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Back) {
                e.Handled = false;
                return;
            }

            if (!char.IsNumber(e.KeyChar)) {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Recebe os dados e apresenta no log.
        /// </summary>
        private void ReceiveData() {
            if (Program.Connections == null) { return; }

            for (var n = 0; n < Program.Connections.MaxConnection; n++) {
                if (Program.Connections[n].Connected) {
                    var result = string.Empty;
                    var buffer = Program.Connections[n].ReceiveData();

                    if (buffer.Length > 1) {
                        result = $"Socket {n}:";

                        for (var y = 0; y < 8; y++) {
                            result += " " + buffer[y];
                        }

                        WriteLog(result, Color.DarkBlue);
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e) {
            ReceiveData();
        }
    }
}