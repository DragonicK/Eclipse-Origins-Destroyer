using System;
using System.Drawing;
using System.Windows.Forms;

namespace EngineDestroyer {
    public partial class FrmMain : Form {
        FrmChat chat;
        FrmOverflow overflow;
        FrmCustom custom;
        FrmRage rage;
        FrmAbout about;
        FrmAccount account;

        /// <summary>
        /// Indica que o formulário está sendo fechado.
        /// </summary>
        bool closing = false;

        public FrmMain() {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void ButtonStart_Click(object sender, EventArgs e) {
            var text = ButtonStart.Text;

            if (text == "Start") {
                var ip = TxtIp.Text.Trim();
                var port = Convert.ToInt32(TxtPort.Text);
                var maxConnection = Convert.ToInt32(TxtMaxConnection.Text.Trim());
                var sleep = Convert.ToInt32(TxtSleepTime.Text.Trim());

                Program.Connections = new ConnectionManager(maxConnection) {
                    IpAddress = ip,
                    Port = port,
                    ConnectionTime = sleep
                };

                Program.Connections.Connect();

                ButtonStart.Text = "Stop";
                WriteLog("Connecting ...", Color.Black);
            }
            else {
                Program.Connections.Disconnect();
                ButtonStart.Text = "Start";
                WriteLog("Stopped ...", Color.Black);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            chat = new FrmChat();
            overflow = new FrmOverflow();
            rage = new FrmRage();
            custom = new FrmCustom();
            about = new FrmAbout();
            account = new FrmAccount();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            closing = true;

            if (Program.Connections != null) {
                Program.Connections.Disconnect();
            }
        }

        /// <summary>
        /// Escreve no log.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public void WriteLog(string text, Color color) {
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

        #region Menu Item
        private void MenuExit_Click(object sender, EventArgs e) {
            if (Program.Connections != null) {
                Program.Connections.Disconnect();
            }

            Program.Connections = null;

            Application.Exit();
        }

        private void MenuMessages_Click(object sender, EventArgs e) {
            if (chat.IsDisposed) {
                chat = new FrmChat();
            }

            chat.Show();
        }

        private void MenuOverflow_Click(object sender, EventArgs e) {
            if (overflow.IsDisposed) {
                overflow = new FrmOverflow();
            }

            overflow.Show();
        }

        private void MenuAbout_Click(object sender, EventArgs e) {
            if (about.IsDisposed) {
                about = new FrmAbout();
            }

            about.ShowDialog();
        }

        private void MenuRageMode_Click(object sender, EventArgs e) {
            if (rage.IsDisposed) {
                rage = new FrmRage();
            }

            rage.Show();
        }

        private void MenuCustom_Click(object sender, EventArgs e) {
            if (custom.IsDisposed) {
                custom = new FrmCustom();
            }

            custom.Show();
        }

        private void MenuAccount_Click(object sender, EventArgs e) {
            if (account.IsDisposed) {
                account = new FrmAccount();
            }

            account.Show();
        }
        #endregion

        /// <summary>
        /// Permite apenas números no textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}