using System;
using System.Threading;
using System.Windows.Forms;
using EngineDestroyer.Handler;
using EngineDestroyer.Network;
using EngineDestroyer.Network.Packets;

namespace EngineDestroyer {
    public partial class FormChat : Form {
        private bool loop;
        private bool allConnections;
        private bool overflow;
        private ClientHeader header;
        private int interval = 2000;
        private bool running;
        private bool closing;
        private Thread sendThread;

        private delegate void DelegateUpdateSendLog(int size, int count);

        public FormChat() {
            InitializeComponent();
        }

        private void FormChat_Load(object sender, EventArgs e) {
            ComboMessageType.SelectedIndex = 0;
        }
        
        private void UpdateSendLog(int size, int count) {
            if (closing) {
                return;
            }

            if (LabelPacketSize.InvokeRequired) {
                var d = new DelegateUpdateSendLog(UpdateSendLog);
                LabelPacketSize.Invoke(d, size, count);
            }
            else {
                LabelPacketSize.Text = "Packet Size: " + size + " Bytes";
                LabelSendCount.Text = "Send Count: " + count;
            }
        }

        private void EnableSend() {
            CheckLoop.Enabled = false;
            ComboMessageType.Enabled = false;
            TextMessage.Enabled = false;
            TextPlayer.Enabled = false;
            CheckOverflow.Enabled = false;
            CheckLoop.Enabled = false;
            CheckAllConnections.Enabled = false;
            TextLoopTime.Enabled = false;
            ButtonSend.Text = "Stop";
        }
        
        private void DisableSend() {
            TextLoopTime.Enabled = true;
            CheckOverflow.Enabled = true;
            CheckLoop.Enabled = true;
            CheckAllConnections.Enabled = true;
            ComboMessageType.Enabled = true;
            TextMessage.Enabled = true;
            TextPlayer.Enabled = true;
            ButtonSend.Text = "Start";

            UpdateSendLog(0, 0);
        }

        private void StartSend() {
            running = true;

            sendThread = new Thread(Send);
            sendThread.Start();
        }

        private void StopSend() {
            running = false;

            sendThread?.Abort();
        }

        private void Send() {
            ClientPacket msg = null;

            var message = TextMessage.Text.Trim();
            var target = TextPlayer.Text.Trim();
            var count = 0;

            var connection = GlobalHandler.ConnectionHandler.GetValidConnection();

            switch (header) {
                case ClientHeader.CSayMsg:
                    msg = new CpSayMessage(message, overflow);
                    break;
                case ClientHeader.CEmoteMsg:
                    msg = new CpEmoteMessage(message, overflow);
                    break;
                case ClientHeader.CPlayerMsg:
                    msg = new CpPlayerMessage(message, target, overflow);
                    break;
                case ClientHeader.CBroadcastMsg:
                    msg = new CpBroadcastMessage(message, overflow);
                    break;
            }

            while (running) {
                if (allConnections) {
                    count += msg.SendToAll();
                }
                else {
                    if (connection != null) {
                        msg.Send(connection);
                        ++count;
                    }
                }

                UpdateSendLog(msg.Size, count);

                Thread.Sleep(interval);
            }
        }

        private void TextLoopTime_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(TextLoopTime.Text, out var result)) {
                interval = result;
            }
            else {
                interval = 2000;
            }
        }

        private void TextLoopTime_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Back) {
                return;
            }

            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void CheckOverflow_CheckedChanged(object sender, EventArgs e) {
            overflow = CheckOverflow.Checked;
        }

        private void CheckAllConnections_CheckedChanged(object sender, EventArgs e) {
            allConnections = CheckAllConnections.Checked;
        }

        private void CheckLoop_CheckedChanged(object sender, EventArgs e) {
            loop = CheckLoop.Checked;

            if (loop) {
                ButtonSend.Text = "Start";
            }
            else {
                ButtonSend.Text = "Send";
            }
        }

        private void ComboMessageType_SelectedIndexChanged(object sender, EventArgs e) {
            var index = ComboMessageType.SelectedIndex;

            switch (index) {
                case 0:
                    header = ClientHeader.CSayMsg;
                    break;
                case 1:
                    header = ClientHeader.CEmoteMsg;
                    break;
                case 2:
                    header = ClientHeader.CPlayerMsg;
                    break;
                case 3:
                    header = ClientHeader.CBroadcastMsg;
                    break;
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e) {
            if (loop) {
                if (ButtonSend.Text == "Start") {
                    EnableSend();
                    StartSend();
                }
                else {
                    DisableSend();
                    StopSend();
                }          
            }
            else {
                ClientPacket msg = null;

                var message = TextMessage.Text.Trim();
                var target = TextPlayer.Text.Trim();
                var count = 0;

                switch (header) {
                    case ClientHeader.CSayMsg:
                        msg = new CpSayMessage(message, overflow);
                        break;
                    case ClientHeader.CEmoteMsg:
                        msg = new CpEmoteMessage(message, overflow);
                        break;
                    case ClientHeader.CPlayerMsg:
                        msg = new CpPlayerMessage(message, target, overflow);
                        break;
                    case ClientHeader.CBroadcastMsg:
                        msg = new CpBroadcastMessage(message, overflow);
                        break;
                }

                if (!allConnections) {
                    var connection = GlobalHandler.ConnectionHandler.GetValidConnection();

                    if (connection != null) {
                        msg.Send(connection);

                        count = 1;
                    }
                }
                else {
                   count = msg.SendToAll();
                }

                UpdateSendLog(msg.Size, count);
            }
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e) {
            closing = true;

            e.Cancel = true;

            StopSend();

            e.Cancel = false;
        }
    }
}