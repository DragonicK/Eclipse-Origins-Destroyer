using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using EngineDestroyer.Network.Packets;

namespace EngineDestroyer {
    public partial class FormRandom : Form {
        private int headerMin =1;
        private int headerMax = 400;
        private int quantity = 20;
        private int interval = 2000;
        private bool running = false;
        private Thread sendThread;

        private delegate void DelegateUpdateSendLog(int count);
        private bool closing;

        public FormRandom() {
            InitializeComponent();
        }

        private void UpdateSendLog(int count) {
            if (closing) {
                return;
            }

            if (LabelSendCount.InvokeRequired) {
                var d = new DelegateUpdateSendLog(UpdateSendLog);
                LabelSendCount.Invoke(d, count);
            }
            else {
                LabelSendCount.Text = "Send Count: " + count;
            }
        }
        
        private void Send() {
            var list = new List<CpRandomOverflow>();

            for (var i = headerMin; i < headerMax; ++i) {
                list.Add(new CpRandomOverflow(i, quantity));
            }

            while (running) {
                var count = 0;

                for (var i = 0; i < list.Count; ++i) {
                    count += list[i].SendToAll();
                }

                UpdateSendLog(count);

                Thread.Sleep(interval);
            }

            list.Clear();
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

        private void EnableSend() {
            TextHeaderMin.Enabled = true;
            TextHeaderMax.Enabled = true;
            TextQuantity.Enabled = true;
            TextSendTime.Enabled = true;
            ButtonStart.Text = "Start";
        }

        private void DisableSend() {
            TextHeaderMin.Enabled = false;
            TextHeaderMax.Enabled = false;
            TextQuantity.Enabled = false;
            TextSendTime.Enabled = false;
            ButtonStart.Text = "Stop";
        }

        private void AllowOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Back) {
                return;
            }

            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e) {
            headerMin = Convert.ToInt32(TextHeaderMin.Text.Trim());
            headerMax = Convert.ToInt32(TextHeaderMax.Text.Trim());
            quantity = Convert.ToInt32(TextQuantity.Text.Trim());
            interval = Convert.ToInt32(TextSendTime.Text.Trim());

            if (ButtonStart.Text == "Start") {
                UpdateSendLog(0);

                DisableSend();
                StartSend();
            }
            else {
                EnableSend();
                StopSend();
            }
        }

        private void FormRandom_FormClosing(object sender, FormClosingEventArgs e) {
            closing = true;

            e.Cancel = true;

            StopSend();

            e.Cancel = false;
        }
    }
}