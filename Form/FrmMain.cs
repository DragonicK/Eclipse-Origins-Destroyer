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

        bool closing = false;

        public FrmMain() {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_start_Click(object sender, EventArgs e) {
            var text = btn_start.Text;

            if (text == "Start") {
                var ip = txt_ip.Text.Trim();
                var port = Convert.ToInt32(txt_port.Text);
                var max = Convert.ToInt32(txt_max.Text.Trim());
                var sleep = Convert.ToInt32(txt_sleep.Text.Trim());

                Program.Connections = new ConnectionManager(max);
                Program.Connections.IpAddress = ip;
                Program.Connections.Port = port;
                Program.Connections.ConnectionTime = sleep;
                Program.Connections.Connect();

                btn_start.Text = "Stop";
                WriteLog("Connecting ...", Color.Black);
            }
            else {
                Program.Connections.Disconnect();
                btn_start.Text = "Start";
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

            Environment.Exit(0);
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
        private void exit_item_Click(object sender, EventArgs e) {
            if (Program.Connections != null) {
                Program.Connections.Disconnect();
            }

            Program.Connections = null;

            Application.Exit();
        }

        private void message_item_Click(object sender, EventArgs e) {
            if (chat.IsDisposed) {
                chat = new FrmChat();
            }

            chat.Show();
        }

        private void overflow_item_Click(object sender, EventArgs e) {
            if (overflow.IsDisposed) {
                overflow = new FrmOverflow();
            }

            overflow.Show();
        }

        private void about_item_Click(object sender, EventArgs e) {
            if (about.IsDisposed) {
                about = new FrmAbout();
            }

            about.ShowDialog();
        }

        private void rage_item_Click(object sender, EventArgs e) {
            if (rage.IsDisposed) {
                rage = new FrmRage();
            }

            rage.Show();
        }

        private void custom_item_Click(object sender, EventArgs e) {
            if (custom.IsDisposed) {
                custom = new FrmCustom();
            }

            custom.Show();
        }

        private void account_item_Click(object sender, EventArgs e) {
            if (account.IsDisposed) {
                account = new FrmAccount();
            }

            account.Show();
        }
        #endregion

        #region Permite apenas números no textbox
        private void txt_port_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txt_max_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txt_sleep_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        #endregion


    }
}