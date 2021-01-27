namespace EngineDestroyer {
    partial class FormChat {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.TextPlayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckOverflow = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextLoopTime = new System.Windows.Forms.TextBox();
            this.CheckLoop = new System.Windows.Forms.CheckBox();
            this.CheckAllConnections = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboMessageType = new System.Windows.Forms.ComboBox();
            this.LabelPacketSize = new System.Windows.Forms.Label();
            this.LabelSendCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextMessage
            // 
            this.TextMessage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMessage.Location = new System.Drawing.Point(15, 90);
            this.TextMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(235, 21);
            this.TextMessage.TabIndex = 3;
            // 
            // TextPlayer
            // 
            this.TextPlayer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlayer.Location = new System.Drawing.Point(15, 42);
            this.TextPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextPlayer.Multiline = true;
            this.TextPlayer.Name = "TextPlayer";
            this.TextPlayer.Size = new System.Drawing.Size(105, 21);
            this.TextPlayer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSend.Location = new System.Drawing.Point(24, 442);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(271, 25);
            this.ButtonSend.TabIndex = 6;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckOverflow
            // 
            this.CheckOverflow.AutoSize = true;
            this.CheckOverflow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOverflow.Location = new System.Drawing.Point(24, 79);
            this.CheckOverflow.Name = "CheckOverflow";
            this.CheckOverflow.Size = new System.Drawing.Size(82, 18);
            this.CheckOverflow.TabIndex = 8;
            this.CheckOverflow.Text = "Overflow";
            this.CheckOverflow.UseVisualStyleBackColor = true;
            this.CheckOverflow.CheckedChanged += new System.EventHandler(this.CheckOverflow_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Send Time (ms)  :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextLoopTime
            // 
            this.TextLoopTime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLoopTime.Location = new System.Drawing.Point(152, 18);
            this.TextLoopTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextLoopTime.Multiline = true;
            this.TextLoopTime.Name = "TextLoopTime";
            this.TextLoopTime.Size = new System.Drawing.Size(74, 21);
            this.TextLoopTime.TabIndex = 9;
            this.TextLoopTime.Text = "2000";
            this.TextLoopTime.TextChanged += new System.EventHandler(this.TextLoopTime_TextChanged);
            this.TextLoopTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextLoopTime_KeyPress);
            // 
            // CheckLoop
            // 
            this.CheckLoop.AutoSize = true;
            this.CheckLoop.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLoop.Location = new System.Drawing.Point(24, 127);
            this.CheckLoop.Name = "CheckLoop";
            this.CheckLoop.Size = new System.Drawing.Size(54, 18);
            this.CheckLoop.TabIndex = 11;
            this.CheckLoop.Text = "Loop";
            this.CheckLoop.UseVisualStyleBackColor = true;
            this.CheckLoop.CheckedChanged += new System.EventHandler(this.CheckLoop_CheckedChanged);
            // 
            // CheckAllConnections
            // 
            this.CheckAllConnections.AutoSize = true;
            this.CheckAllConnections.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAllConnections.Location = new System.Drawing.Point(24, 103);
            this.CheckAllConnections.Name = "CheckAllConnections";
            this.CheckAllConnections.Size = new System.Drawing.Size(159, 18);
            this.CheckAllConnections.TabIndex = 9;
            this.CheckAllConnections.Text = "Use All Connections";
            this.CheckAllConnections.UseVisualStyleBackColor = true;
            this.CheckAllConnections.CheckedChanged += new System.EventHandler(this.CheckAllConnections_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboMessageType
            // 
            this.ComboMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMessageType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboMessageType.Items.AddRange(new object[] {
            "Say Message",
            "Emote Message",
            "Player Message",
            "Broadcast Message"});
            this.ComboMessageType.Location = new System.Drawing.Point(24, 41);
            this.ComboMessageType.Name = "ComboMessageType";
            this.ComboMessageType.Size = new System.Drawing.Size(271, 22);
            this.ComboMessageType.TabIndex = 3;
            this.ComboMessageType.SelectedIndexChanged += new System.EventHandler(this.ComboMessageType_SelectedIndexChanged);
            // 
            // LabelPacketSize
            // 
            this.LabelPacketSize.BackColor = System.Drawing.Color.Transparent;
            this.LabelPacketSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPacketSize.Location = new System.Drawing.Point(18, 15);
            this.LabelPacketSize.Name = "LabelPacketSize";
            this.LabelPacketSize.Size = new System.Drawing.Size(160, 20);
            this.LabelPacketSize.TabIndex = 15;
            this.LabelPacketSize.Text = "Packet Size: 0 Bytes";
            this.LabelPacketSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSendCount
            // 
            this.LabelSendCount.BackColor = System.Drawing.Color.Transparent;
            this.LabelSendCount.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSendCount.Location = new System.Drawing.Point(18, 35);
            this.LabelSendCount.Name = "LabelSendCount";
            this.LabelSendCount.Size = new System.Drawing.Size(160, 20);
            this.LabelSendCount.TabIndex = 17;
            this.LabelSendCount.Text = "Send Count: 0";
            this.LabelSendCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CheckLoop);
            this.groupBox1.Controls.Add(this.CheckAllConnections);
            this.groupBox1.Controls.Add(this.ComboMessageType);
            this.groupBox1.Controls.Add(this.ButtonSend);
            this.groupBox1.Controls.Add(this.CheckOverflow);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 487);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LabelSendCount);
            this.groupBox4.Controls.Add(this.LabelPacketSize);
            this.groupBox4.Location = new System.Drawing.Point(24, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 67);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Log";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextPlayer);
            this.groupBox3.Controls.Add(this.TextMessage);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(24, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 132);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TextLoopTime);
            this.groupBox2.Location = new System.Drawing.Point(24, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 53);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loop Time";
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 512);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.TextBox TextPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckOverflow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextLoopTime;
        private System.Windows.Forms.CheckBox CheckLoop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboMessageType;
        private System.Windows.Forms.Label LabelPacketSize;
        private System.Windows.Forms.Label LabelSendCount;
        private System.Windows.Forms.CheckBox CheckAllConnections;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}