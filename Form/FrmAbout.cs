using System;
using System.Windows.Forms;

namespace EngineDestroyer {
    public partial class FrmAbout : Form {
        public FrmAbout() {
            InitializeComponent();


            lbl_product.Text = ProductName;
            lbl_version.Text = ProductVersion;
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            Close();
        }
    }
}