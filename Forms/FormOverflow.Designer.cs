namespace EngineDestroyer {
    partial class FormOverflow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOverflow));
            this.RadioHotbarChange = new System.Windows.Forms.RadioButton();
            this.RadioHotbarUse = new System.Windows.Forms.RadioButton();
            this.RadioSwapInv = new System.Windows.Forms.RadioButton();
            this.RadioChangeBankSlot = new System.Windows.Forms.RadioButton();
            this.RadioLogin = new System.Windows.Forms.RadioButton();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.LabelLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RadioHotbarChange
            // 
            this.RadioHotbarChange.AutoSize = true;
            this.RadioHotbarChange.Font = new System.Drawing.Font("Consolas", 9F);
            this.RadioHotbarChange.Location = new System.Drawing.Point(57, 26);
            this.RadioHotbarChange.Name = "RadioHotbarChange";
            this.RadioHotbarChange.Size = new System.Drawing.Size(123, 18);
            this.RadioHotbarChange.TabIndex = 0;
            this.RadioHotbarChange.Text = "Hot Bar Change";
            this.RadioHotbarChange.UseVisualStyleBackColor = true;
            this.RadioHotbarChange.CheckedChanged += new System.EventHandler(this.RadioHotbarChange_CheckedChanged);
            // 
            // RadioHotbarUse
            // 
            this.RadioHotbarUse.AutoSize = true;
            this.RadioHotbarUse.Checked = true;
            this.RadioHotbarUse.Font = new System.Drawing.Font("Consolas", 9F);
            this.RadioHotbarUse.Location = new System.Drawing.Point(57, 51);
            this.RadioHotbarUse.Name = "RadioHotbarUse";
            this.RadioHotbarUse.Size = new System.Drawing.Size(102, 18);
            this.RadioHotbarUse.TabIndex = 1;
            this.RadioHotbarUse.TabStop = true;
            this.RadioHotbarUse.Text = "Hot Bar Use";
            this.RadioHotbarUse.UseVisualStyleBackColor = true;
            this.RadioHotbarUse.CheckedChanged += new System.EventHandler(this.RadioHotbarUse_CheckedChanged);
            // 
            // RadioSwapInv
            // 
            this.RadioSwapInv.AutoSize = true;
            this.RadioSwapInv.Font = new System.Drawing.Font("Consolas", 9F);
            this.RadioSwapInv.Location = new System.Drawing.Point(57, 76);
            this.RadioSwapInv.Name = "RadioSwapInv";
            this.RadioSwapInv.Size = new System.Drawing.Size(123, 18);
            this.RadioSwapInv.TabIndex = 2;
            this.RadioSwapInv.Text = "Swap Inv Slots";
            this.RadioSwapInv.UseVisualStyleBackColor = true;
            this.RadioSwapInv.CheckedChanged += new System.EventHandler(this.RadioSwapInv_CheckedChanged);
            // 
            // RadioChangeBankSlot
            // 
            this.RadioChangeBankSlot.AutoSize = true;
            this.RadioChangeBankSlot.Font = new System.Drawing.Font("Consolas", 9F);
            this.RadioChangeBankSlot.Location = new System.Drawing.Point(57, 101);
            this.RadioChangeBankSlot.Name = "RadioChangeBankSlot";
            this.RadioChangeBankSlot.Size = new System.Drawing.Size(144, 18);
            this.RadioChangeBankSlot.TabIndex = 3;
            this.RadioChangeBankSlot.Text = "Change Bank Slots";
            this.RadioChangeBankSlot.UseVisualStyleBackColor = true;
            this.RadioChangeBankSlot.CheckedChanged += new System.EventHandler(this.RadioChangeBankSlot_CheckedChanged);
            // 
            // RadioLogin
            // 
            this.RadioLogin.AutoSize = true;
            this.RadioLogin.Font = new System.Drawing.Font("Consolas", 9F);
            this.RadioLogin.Location = new System.Drawing.Point(57, 126);
            this.RadioLogin.Name = "RadioLogin";
            this.RadioLogin.Size = new System.Drawing.Size(123, 18);
            this.RadioLogin.TabIndex = 4;
            this.RadioLogin.Text = "Login Overflow";
            this.RadioLogin.UseVisualStyleBackColor = true;
            this.RadioLogin.CheckedChanged += new System.EventHandler(this.RadioLogin_CheckedChanged);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonSend.Location = new System.Drawing.Point(12, 150);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(227, 28);
            this.ButtonSend.TabIndex = 5;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // LabelLog
            // 
            this.LabelLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLog.Location = new System.Drawing.Point(0, 181);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(252, 27);
            this.LabelLog.TabIndex = 6;
            this.LabelLog.Text = "Packet Size: 0 Bytes";
            this.LabelLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOverflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 222);
            this.Controls.Add(this.LabelLog);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.RadioLogin);
            this.Controls.Add(this.RadioChangeBankSlot);
            this.Controls.Add(this.RadioSwapInv);
            this.Controls.Add(this.RadioHotbarUse);
            this.Controls.Add(this.RadioHotbarChange);
            this.Font = new System.Drawing.Font("Consolas", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOverflow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overflow";
            this.Load += new System.EventHandler(this.FormOverflow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioHotbarChange;
        private System.Windows.Forms.RadioButton RadioHotbarUse;
        private System.Windows.Forms.RadioButton RadioSwapInv;
        private System.Windows.Forms.RadioButton RadioChangeBankSlot;
        private System.Windows.Forms.RadioButton RadioLogin;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label LabelLog;
    }
}