using System;
using System.Windows.Forms;

namespace EngineDestroyer {
    public partial class FormAbout : Form {
        public FormAbout() {
            InitializeComponent();

            LabelProduct.Text = ProductName;
            LabelVersion.Text = ProductVersion;
        }

        private void ButtonOK_Click(object sender, EventArgs e) {
            Close();
        }
    }
}