using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using EngineDestroyer.Network.Packets;

namespace EngineDestroyer {
    public partial class FormCustom : Form {
        private List<Data> packets;
        private bool loop;
        private int interval = 2000;
        private bool running = false;
        private Thread sendThread;
        private bool closing;
        private bool automaticStringLength = false;

        private delegate void DelegateUpdateSendLog(int count);

        public FormCustom() {
            InitializeComponent();

            var names = Enum.GetNames(typeof(DataType));

            for (var i = 0; i < names.Length; ++i) {
                ComboDataType.Items.Add(names[i]);
            }

            ComboDataType.SelectedIndex = 0;
        }

        private void UpdateSendLog(int count) {
            if (closing) {
                return;
            }

            if (LabelSend.InvokeRequired) {
                var d = new DelegateUpdateSendLog(UpdateSendLog);
                LabelSend.Invoke(d, count);
            }
            else {
                LabelSend.Text = "Send Count: " + count;
            }
        }

        private void UpdatePacketInfo() {
            if (closing) {
                return;
            }

            var size = 0;

            for (var i = 0; i < packets.Count; i++) {
                size += packets[i].Array.Length;
            }

            LabelPacketSize.Text = "Packet Size: " + size + " Bytes";
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

        private void DisableSend() {
            TextData.Enabled = false;
            ButtonAdd.Enabled = false;
            CheckLoop.Enabled = false;
            ButtonRemove.Enabled = false;
            ButtonClear.Enabled = false;
            TextSendInterval.Enabled = false;
            ButtonOpen.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonSend.Text = "Stop";
        }

        private void EnableSend() {
            TextData.Enabled = true;
            ButtonAdd.Enabled = true;
            CheckLoop.Enabled = true;
            ButtonRemove.Enabled = true;
            ButtonClear.Enabled = true;
            TextSendInterval.Enabled = true;
            ButtonOpen.Enabled = true;
            ButtonSave.Enabled = true;
            ButtonSend.Text = "Start";
        }

        private void Send() {
            var count = 0;
            var msg = new CpCustom();

            for (var i = 0; i < packets.Count; ++i) {
                var data = packets[i];

                if (automaticStringLength && data.Type == DataType.String) {
                    msg.Write(data.Array.Length);
                }

                msg.Write(data.Array);
            }
            
            while (running) {
                count += msg.SendToAll();

                UpdateSendLog(count);

                Thread.Sleep(interval);
            }
        }

        private void SavePacket(string path) {
            using (var stream = new FileStream(path, FileMode.Create,  FileAccess.Write)) {
                using (var writer = new BinaryWriter(stream)) {
                    writer.Write(TextName.Text.Trim());
                    writer.Write(TextDescription.Text.Trim());

                    writer.Write(packets.Count);

                    for (var i = 0; i < packets.Count; ++i) {
                        writer.Write((int)packets[i].Type);
                        writer.Write(packets[i].Array.Length);
                        writer.Write(packets[i].Array);
                    }
               }
            }
        }

        private void OpenPacket(string path) {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read)) {
                using (var reader = new BinaryReader(stream)) {
                    TextName.Text = reader.ReadString();
                    TextDescription.Text = reader.ReadString();

                    var count = reader.ReadInt32();

                    for (var i = 0; i < count; ++i) {
                        var msg = new Data();
                        msg.Type = (DataType)reader.ReadInt32();

                        var length = reader.ReadInt32();
                        msg.Array = reader.ReadBytes(length);
                    }
                }
            }
        }

        private void ListDataType() {
            ListData.Items.Clear();
            ListData.BeginUpdate();

            for (var i = 0; i < packets.Count; ++i) {
                var data = packets[i];

                ListData.Items.Add($"Index: {i} Type: {data.Type}  Value: {data.GetData()} Bytes: {data.GetArrayString()}");
            }

            ListData.EndUpdate();
        }

        private void AllowOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Back) {
                return;
            }

            if (!char.IsNumber(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void FormCustom_Load(object sender, EventArgs e) {
            packets = new List<Data>();
            ListDataType();
        }

        private void AddValue(object value, DataType type) {
            var msg = new Data();

            switch (type) {
                case DataType.Byte:
                    msg.Write((byte)value);
                    break;

                case DataType.Short:
                    msg.Write((short)value);
                    break;

                case DataType.Integer:
                    msg.Write((int)value);
                    break;

                case DataType.String:
                    msg.Write((string)value);
                    break;
            }

            packets.Add(msg);
        }

        private bool IsNumber(string data) {
            foreach (var c in data) {
                if (!char.IsNumber(c)) {
                    return false;
                }
            }

            return true;
        }

        private string CreateIncorretRangeValueMessage(DataType dataType) {
            switch (dataType) {
                case DataType.Byte: return $"Incorret value. Use {byte.MinValue} ~ {byte.MaxValue} values.";
                case DataType.Short: return $"Incorret value. Use {short.MinValue} ~ {short.MaxValue} values.";
                case DataType.Integer: return $"Incorret value. Use {int.MinValue} ~ {int.MaxValue} values.";
            }

            return string.Empty;
        }

        private void ButtonClear_Click(object sender, EventArgs e) {
            packets.Clear();
            ListDataType();
            UpdatePacketInfo();
        }

        private void ButtonRemove_Click(object sender, EventArgs e) {
            var index = ListData.SelectedIndex;

            if (index >= 0) {
                packets.RemoveAt(index);
                ListDataType();

                UpdatePacketInfo();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e) {
            string data = TextData.Text.Trim();

            if (string.IsNullOrWhiteSpace(data)) {
                return;
            }

            object value = 0;
            var onlyNumberMessage = "Please, use only numbers when you're not using string";
            var dataType = (DataType)ComboDataType.SelectedIndex;

            switch (dataType) {
                case DataType.Byte:
                    if (!IsNumber(data)) {
                        MessageBox.Show(onlyNumberMessage, "Message");
                        return;
                    }

                    if (!byte.TryParse(data, out var resultedByte)) {
                        MessageBox.Show(CreateIncorretRangeValueMessage(DataType.Byte), "Message");
                        return;
                    }

                    value = resultedByte;

                    break;
                case DataType.Short:
                    if (!IsNumber(data)) {
                        MessageBox.Show(onlyNumberMessage, "Message");
                        return;
                    }

                    if (!short.TryParse(data, out var resultedShort)) {
                        MessageBox.Show(CreateIncorretRangeValueMessage(DataType.Short), "Message");
                        return;
                    }

                    value = resultedShort;

                    break;
                case DataType.Integer:
                    if (!IsNumber(data)) {
                        MessageBox.Show(onlyNumberMessage, "Message");
                        return;
                    }

                    if (!int.TryParse(data, out var resultedInt)) {
                        MessageBox.Show(CreateIncorretRangeValueMessage(DataType.Integer), "Message");
                        return;
                    }

                    value = resultedInt;

                    break;
                case DataType.String:
                    value = data;
                    break;
            }

            AddValue(value, dataType);
            ListDataType();

            TextData.Text = string.Empty;
            UpdatePacketInfo();
        }

        private void ButtonListType_Click(object sender, EventArgs e) {
            ListDataType();
        }

        private void CheckLoop_CheckedChanged(object sender, EventArgs e) {
            loop = CheckLoop.Checked;

            if (loop) {
                ButtonSend.Text = "Start";
            }
            else {
                ButtonSend.Text = "Stop";
            }
        }

        private void TextSendInterval_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(TextSendInterval.Text, out var result)) {
                interval = result;
            }
            else {
                interval = 2000;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            var dialog = new SaveFileDialog {
                InitialDirectory = Application.StartupPath,
                Filter = "Binary Files | *.bin",
                FilterIndex = 0
            };

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                SavePacket(dialog.FileName);
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog {
                Multiselect = false,
                InitialDirectory = Application.StartupPath,
                Filter = "Binary Files | *.bin",
                FilterIndex = 0
            };

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                OpenPacket(dialog.FileName);
                ListDataType();
                UpdatePacketInfo();
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e) {
            if (loop) {
                if (ButtonSend.Text == "Start") {
                    UpdateSendLog(0);
                    EnableSend();
                    StartSend();
                }
                else {
                    DisableSend();
                    StopSend();
                }
            }
            else {
                var msg = new CpCustom();

                for (var i = 0; i < packets.Count; ++i) {
                    var data = packets[i];

                    if (automaticStringLength && data.Type == DataType.String) {
                        msg.Write(data.Array.Length);
                    }
   
                    msg.Write(data.Array);
                }

                var count = msg.SendToAll();

                UpdateSendLog(count);
            }
        }

        private void FormCustom_FormClosing(object sender, FormClosingEventArgs e) {
            closing = true;

            e.Cancel = true;

            StopSend();

            e.Cancel = false;
        }

        private void CheckAutomaticStringLength_CheckedChanged(object sender, EventArgs e) {
            automaticStringLength = CheckAutomaticStringLength.Checked;
        }
    }
}