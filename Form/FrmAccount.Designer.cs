namespace EngineDestroyer {
    partial class FrmAccount {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccount));
            this.txt_looptime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_generate = new System.Windows.Forms.CheckBox();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.log_textbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chk_loop = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_looptime
            // 
            this.txt_looptime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_looptime.Location = new System.Drawing.Point(13, 209);
            this.txt_looptime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_looptime.Multiline = true;
            this.txt_looptime.Name = "txt_looptime";
            this.txt_looptime.Size = new System.Drawing.Size(121, 21);
            this.txt_looptime.TabIndex = 11;
            this.txt_looptime.Text = "2000";
            this.txt_looptime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_looptime_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Send Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_generate
            // 
            this.chk_generate.AutoSize = true;
            this.chk_generate.Checked = true;
            this.chk_generate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_generate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_generate.Location = new System.Drawing.Point(13, 29);
            this.chk_generate.Name = "chk_generate";
            this.chk_generate.Size = new System.Drawing.Size(121, 19);
            this.chk_generate.TabIndex = 14;
            this.chk_generate.Text = "Generate Account";
            this.chk_generate.UseVisualStyleBackColor = true;
            this.chk_generate.CheckedChanged += new System.EventHandler(this.chk_generate_CheckedChanged);
            // 
            // txt_account
            // 
            this.txt_account.Enabled = false;
            this.txt_account.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_account.Location = new System.Drawing.Point(13, 74);
            this.txt_account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_account.Multiline = true;
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(121, 21);
            this.txt_account.TabIndex = 15;
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.Location = new System.Drawing.Point(13, 128);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(121, 21);
            this.txt_password.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(13, 237);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(121, 25);
            this.btn_send.TabIndex = 19;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // log_textbox
            // 
            this.log_textbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_textbox.Location = new System.Drawing.Point(151, 52);
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ReadOnly = true;
            this.log_textbox.Size = new System.Drawing.Size(389, 210);
            this.log_textbox.TabIndex = 20;
            this.log_textbox.Text = "";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(148, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Received Data Log";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chk_loop
            // 
            this.chk_loop.AutoSize = true;
            this.chk_loop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_loop.Location = new System.Drawing.Point(16, 163);
            this.chk_loop.Name = "chk_loop";
            this.chk_loop.Size = new System.Drawing.Size(53, 19);
            this.chk_loop.TabIndex = 13;
            this.chk_loop.Text = "Loop";
            this.chk_loop.UseVisualStyleBackColor = true;
            this.chk_loop.CheckedChanged += new System.EventHandler(this.chk_loop_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(10, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(498, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nota: Somente um usuário pode se criado por conexão devido à estrutura do servido" +
    "r.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.log_textbox);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.chk_generate);
            this.Controls.Add(this.chk_loop);
            this.Controls.Add(this.txt_looptime);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAccount_FormClosing);
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_looptime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_generate;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox log_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chk_loop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
    }
}