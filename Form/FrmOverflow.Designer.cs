namespace EngineDestroyer {
    partial class FrmOverflow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOverflow));
            this.r_hotbarchange = new System.Windows.Forms.RadioButton();
            this.r_hotbaruse = new System.Windows.Forms.RadioButton();
            this.r_swapinv = new System.Windows.Forms.RadioButton();
            this.r_changebankslot = new System.Windows.Forms.RadioButton();
            this.r_login = new System.Windows.Forms.RadioButton();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_size = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // r_hotbarchange
            // 
            this.r_hotbarchange.AutoSize = true;
            this.r_hotbarchange.Checked = true;
            this.r_hotbarchange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_hotbarchange.Location = new System.Drawing.Point(49, 22);
            this.r_hotbarchange.Name = "r_hotbarchange";
            this.r_hotbarchange.Size = new System.Drawing.Size(109, 19);
            this.r_hotbarchange.TabIndex = 0;
            this.r_hotbarchange.TabStop = true;
            this.r_hotbarchange.Text = "Hot Bar Change";
            this.r_hotbarchange.UseVisualStyleBackColor = true;
            // 
            // r_hotbaruse
            // 
            this.r_hotbaruse.AutoSize = true;
            this.r_hotbaruse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_hotbaruse.Location = new System.Drawing.Point(49, 47);
            this.r_hotbaruse.Name = "r_hotbaruse";
            this.r_hotbaruse.Size = new System.Drawing.Size(87, 19);
            this.r_hotbaruse.TabIndex = 1;
            this.r_hotbaruse.Text = "Hot Bar Use";
            this.r_hotbaruse.UseVisualStyleBackColor = true;
            // 
            // r_swapinv
            // 
            this.r_swapinv.AutoSize = true;
            this.r_swapinv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_swapinv.Location = new System.Drawing.Point(49, 72);
            this.r_swapinv.Name = "r_swapinv";
            this.r_swapinv.Size = new System.Drawing.Size(100, 19);
            this.r_swapinv.TabIndex = 2;
            this.r_swapinv.Text = "Swap Inv Slots";
            this.r_swapinv.UseVisualStyleBackColor = true;
            // 
            // r_changebankslot
            // 
            this.r_changebankslot.AutoSize = true;
            this.r_changebankslot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_changebankslot.Location = new System.Drawing.Point(49, 97);
            this.r_changebankslot.Name = "r_changebankslot";
            this.r_changebankslot.Size = new System.Drawing.Size(123, 19);
            this.r_changebankslot.TabIndex = 3;
            this.r_changebankslot.Text = "Change Bank Slots";
            this.r_changebankslot.UseVisualStyleBackColor = true;
            // 
            // r_login
            // 
            this.r_login.AutoSize = true;
            this.r_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_login.Location = new System.Drawing.Point(49, 122);
            this.r_login.Name = "r_login";
            this.r_login.Size = new System.Drawing.Size(106, 19);
            this.r_login.TabIndex = 4;
            this.r_login.Text = "Login Overflow";
            this.r_login.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(52, 158);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(106, 24);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lbl_size
            // 
            this.lbl_size.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.Location = new System.Drawing.Point(-4, 195);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(221, 23);
            this.lbl_size.TabIndex = 6;
            this.lbl_size.Text = "Packet Size: 0 bytes";
            this.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmOverflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 247);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.r_login);
            this.Controls.Add(this.r_changebankslot);
            this.Controls.Add(this.r_swapinv);
            this.Controls.Add(this.r_hotbaruse);
            this.Controls.Add(this.r_hotbarchange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmOverflow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Overflow";
            this.Load += new System.EventHandler(this.FrmOverflow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton r_hotbarchange;
        private System.Windows.Forms.RadioButton r_hotbaruse;
        private System.Windows.Forms.RadioButton r_swapinv;
        private System.Windows.Forms.RadioButton r_changebankslot;
        private System.Windows.Forms.RadioButton r_login;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_size;
    }
}