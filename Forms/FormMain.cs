using System;
using System.Drawing;
using System.Windows.Forms;
using EngineDestroyer.Network;
using EngineDestroyer.Handler;

namespace EngineDestroyer {
    public partial class FormMain : Form {
        private FormAbout about;
        private FormChat chat;
        private FormOverflow overflow;
        private FormRandom random;
        FormCustom custom;

        private bool closing = false;

        private delegate void DelegateWriteLog(string text, Color color);

        public FormMain() {
            InitializeComponent();
        }

        private void Start(string ipAddress, int port, int maxConnections, int sleep) {
            GlobalHandler.ConnectionHandler.Port = port;
            GlobalHandler.ConnectionHandler.IpAddress = ipAddress;
            GlobalHandler.ConnectionHandler.NewConnectionTime = sleep;
            GlobalHandler.ConnectionHandler.MaxConnections = maxConnections;

            GlobalHandler.ConnectionHandler.Start();
        }

        private void Stop() {
            GlobalHandler.ConnectionHandler.Stop();
        }

        private void ButtonStart_Click(object sender, EventArgs e) {
            var text = ButtonStart.Text;

            if (text == "Start") {
                var ipAddress = TextIpAddress.Text.Trim();
                var port = Convert.ToInt32(TextPort.Text);
                var maxConnections = Convert.ToInt32(TextMaxConnection.Text.Trim());
                var sleep = Convert.ToInt32(TextSleepTime.Text.Trim());

                Start(ipAddress, port, maxConnections, sleep);

                ButtonStart.Text = "Stop";
                WriteLog("Connecting ...", Color.Black);
            }
            else {
                Stop();

                ButtonStart.Text = "Start";
                WriteLog("Stopped ...", Color.Black);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            GlobalHandler.Initialize();
            GlobalHandler.ConnectionHandler.ChangedStatus += ChangedStatus;

            chat = new FormChat();
            overflow = new FormOverflow();
            random = new FormRandom();
            custom = new FormCustom();
            about = new FormAbout();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            closing = true;
            e.Cancel = true;
            GlobalHandler.Close();
            e.Cancel = false;
        }

        public void ChangedStatus(object sender, ConnectionArgs args) {
            WriteLog("Index: " + args.Index + " Connected: " + args.Connected, args.Connected ? Color.Green : Color.Red);
        }

        public void WriteLog(string text, Color color) {
            if (closing) {
                return;
            }

            if (TextLogs.InvokeRequired) {
                var d = new DelegateWriteLog(WriteLog);
                TextLogs.Invoke(d, text, color);
            }
            else {
                TextLogs.SelectionStart = TextLogs.TextLength;
                TextLogs.SelectionLength = 0;
                TextLogs.SelectionColor = color;
                TextLogs.AppendText($"{DateTime.Now}: {text}{Environment.NewLine}");
                TextLogs.SelectionColor = color;
                TextLogs.ScrollToCaret();
            }
        }

        #region Menu 

        private void MenuExit_Click(object sender, EventArgs e) {
            GlobalHandler.Close();
            Application.Exit();
        }

        private void MenuMessages_Click(object sender, EventArgs e) {
            if (chat.IsDisposed) {
                chat = new FormChat();
            }

            chat.Show();
        }

        private void MenuOverflow_Click(object sender, EventArgs e) {
            if (overflow.IsDisposed) {
                overflow = new FormOverflow();
            }

            overflow.Show();
        }

        private void MenuAbout_Click(object sender, EventArgs e) {
            if (about.IsDisposed) {
                about = new FormAbout();
            }

            about.ShowDialog();
        }

        private void MenuRandomMode_Click(object sender, EventArgs e) {
            if (random.IsDisposed) {
                random = new FormRandom();
            }

            random.Show();
        }

        private void MenuCustom_Click(object sender, EventArgs e) {
            if (custom.IsDisposed) {
                custom = new FormCustom();
            }

            custom.Show();
        }

        #endregion

        /// <summary>
        /// Permite apenas números no textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Back) {
                return;
            }

            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}