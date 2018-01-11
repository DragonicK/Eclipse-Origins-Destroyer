namespace EngineDestroyer {
    partial class FrmChat {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChat));
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_overflow = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_loop = new System.Windows.Forms.TextBox();
            this.chk_loop = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_allcon = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_msgtype = new System.Windows.Forms.ComboBox();
            this.lbl_totalsize = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_send = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_msg
            // 
            this.txt_msg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_msg.Location = new System.Drawing.Point(17, 45);
            this.txt_msg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(275, 21);
            this.txt_msg.TabIndex = 3;
            // 
            // txt_target
            // 
            this.txt_target.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_target.Location = new System.Drawing.Point(187, 16);
            this.txt_target.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_target.Multiline = true;
            this.txt_target.Name = "txt_target";
            this.txt_target.Size = new System.Drawing.Size(105, 21);
            this.txt_target.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(141, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(233, 215);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(89, 25);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_overflow
            // 
            this.chk_overflow.AutoSize = true;
            this.chk_overflow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_overflow.Location = new System.Drawing.Point(15, 62);
            this.chk_overflow.Name = "chk_overflow";
            this.chk_overflow.Size = new System.Drawing.Size(74, 19);
            this.chk_overflow.TabIndex = 8;
            this.chk_overflow.Text = "Overflow";
            this.chk_overflow.UseVisualStyleBackColor = true;
            this.chk_overflow.CheckedChanged += new System.EventHandler(this.chk_overflow_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(11, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Send Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_loop
            // 
            this.txt_loop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_loop.Location = new System.Drawing.Point(14, 66);
            this.txt_loop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_loop.Multiline = true;
            this.txt_loop.Name = "txt_loop";
            this.txt_loop.Size = new System.Drawing.Size(105, 21);
            this.txt_loop.TabIndex = 9;
            this.txt_loop.Text = "5000";
            this.txt_loop.TextChanged += new System.EventHandler(this.txt_loop_TextChanged);
            this.txt_loop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loop_KeyPress);
            // 
            // chk_loop
            // 
            this.chk_loop.AutoSize = true;
            this.chk_loop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_loop.Location = new System.Drawing.Point(14, 17);
            this.chk_loop.Name = "chk_loop";
            this.chk_loop.Size = new System.Drawing.Size(53, 19);
            this.chk_loop.TabIndex = 11;
            this.chk_loop.Text = "Loop";
            this.chk_loop.UseVisualStyleBackColor = true;
            this.chk_loop.CheckedChanged += new System.EventHandler(this.chk_loop_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_loop);
            this.panel1.Controls.Add(this.chk_loop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(185, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 109);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_msg);
            this.panel2.Controls.Add(this.txt_target);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 82);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chk_allcon);
            this.panel3.Controls.Add(this.chk_overflow);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmb_msgtype);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 109);
            this.panel3.TabIndex = 14;
            // 
            // chk_allcon
            // 
            this.chk_allcon.AutoSize = true;
            this.chk_allcon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_allcon.Location = new System.Drawing.Point(15, 85);
            this.chk_allcon.Name = "chk_allcon";
            this.chk_allcon.Size = new System.Drawing.Size(132, 19);
            this.chk_allcon.TabIndex = 9;
            this.chk_allcon.Text = "Use All Connections";
            this.chk_allcon.UseVisualStyleBackColor = true;
            this.chk_allcon.CheckedChanged += new System.EventHandler(this.chk_allcon_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_msgtype
            // 
            this.cmb_msgtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_msgtype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_msgtype.Items.AddRange(new object[] {
            "Say Msg",
            "Emote Msg",
            "Player Msg",
            "Broadcast Msg"});
            this.cmb_msgtype.Location = new System.Drawing.Point(17, 33);
            this.cmb_msgtype.Name = "cmb_msgtype";
            this.cmb_msgtype.Size = new System.Drawing.Size(133, 23);
            this.cmb_msgtype.TabIndex = 3;
            this.cmb_msgtype.SelectedIndexChanged += new System.EventHandler(this.cmb_msgtype_SelectedIndexChanged);
            // 
            // lbl_totalsize
            // 
            this.lbl_totalsize.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalsize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_totalsize.Location = new System.Drawing.Point(328, 12);
            this.lbl_totalsize.Name = "lbl_totalsize";
            this.lbl_totalsize.Size = new System.Drawing.Size(160, 20);
            this.lbl_totalsize.TabIndex = 15;
            this.lbl_totalsize.Text = "Packet Size: 0 bytes";
            this.lbl_totalsize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_header.Location = new System.Drawing.Point(328, 32);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(160, 20);
            this.lbl_header.TabIndex = 16;
            this.lbl_header.Text = "Header: 0";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_send
            // 
            this.lbl_send.BackColor = System.Drawing.Color.Transparent;
            this.lbl_send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_send.Location = new System.Drawing.Point(328, 69);
            this.lbl_send.Name = "lbl_send";
            this.lbl_send.Size = new System.Drawing.Size(160, 20);
            this.lbl_send.TabIndex = 17;
            this.lbl_send.Text = "Send Count: 0";
            this.lbl_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 250);
            this.Controls.Add(this.lbl_send);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lbl_totalsize);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.FrmChatcs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox txt_target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_overflow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_loop;
        private System.Windows.Forms.CheckBox chk_loop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_msgtype;
        private System.Windows.Forms.Label lbl_totalsize;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_send;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chk_allcon;
    }
}