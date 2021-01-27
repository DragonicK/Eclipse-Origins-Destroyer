namespace EngineDestroyer {
    partial class FormMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPacket = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOverflow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRandomMode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TextLogs = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextIpAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextSleepTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextMaxConnection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonStart.Location = new System.Drawing.Point(211, 136);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(95, 27);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuPacket,
            this.MenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(47, 20);
            this.MenuFile.Text = "File";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(102, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuPacket
            // 
            this.MenuPacket.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMessages,
            this.MenuOverflow,
            this.MenuCustom,
            this.MenuRandomMode});
            this.MenuPacket.Name = "MenuPacket";
            this.MenuPacket.Size = new System.Drawing.Size(138, 20);
            this.MenuPacket.Text = "Logged Out Packet";
            // 
            // MenuMessages
            // 
            this.MenuMessages.Name = "MenuMessages";
            this.MenuMessages.Size = new System.Drawing.Size(151, 22);
            this.MenuMessages.Text = "Messages";
            this.MenuMessages.Click += new System.EventHandler(this.MenuMessages_Click);
            // 
            // MenuOverflow
            // 
            this.MenuOverflow.Name = "MenuOverflow";
            this.MenuOverflow.Size = new System.Drawing.Size(151, 22);
            this.MenuOverflow.Text = "Overflow";
            this.MenuOverflow.Click += new System.EventHandler(this.MenuOverflow_Click);
            // 
            // MenuCustom
            // 
            this.MenuCustom.Name = "MenuCustom";
            this.MenuCustom.Size = new System.Drawing.Size(151, 22);
            this.MenuCustom.Text = "Custom";
            this.MenuCustom.Click += new System.EventHandler(this.MenuCustom_Click);
            // 
            // MenuRandomMode
            // 
            this.MenuRandomMode.Name = "MenuRandomMode";
            this.MenuRandomMode.Size = new System.Drawing.Size(151, 22);
            this.MenuRandomMode.Text = "Random Mode";
            this.MenuRandomMode.Click += new System.EventHandler(this.MenuRandomMode_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(54, 20);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // TextLogs
            // 
            this.TextLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLogs.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextLogs.Location = new System.Drawing.Point(12, 201);
            this.TextLogs.Name = "TextLogs";
            this.TextLogs.ReadOnly = true;
            this.TextLogs.Size = new System.Drawing.Size(491, 133);
            this.TextLogs.TabIndex = 2;
            this.TextLogs.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextIpAddress);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(123, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextPort
            // 
            this.TextPort.Location = new System.Drawing.Point(123, 51);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(100, 22);
            this.TextPort.TabIndex = 2;
            this.TextPort.Text = "7001";
            this.TextPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ip Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextIpAddress
            // 
            this.TextIpAddress.Location = new System.Drawing.Point(17, 51);
            this.TextIpAddress.Name = "TextIpAddress";
            this.TextIpAddress.Size = new System.Drawing.Size(100, 22);
            this.TextIpAddress.TabIndex = 0;
            this.TextIpAddress.Text = "127.0.0.1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TextSleepTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TextMaxConnection);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox2.Location = new System.Drawing.Point(259, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connections";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 9F);
            this.label3.Location = new System.Drawing.Point(125, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextSleepTime
            // 
            this.TextSleepTime.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextSleepTime.Location = new System.Drawing.Point(125, 51);
            this.TextSleepTime.Name = "TextSleepTime";
            this.TextSleepTime.Size = new System.Drawing.Size(100, 22);
            this.TextSleepTime.TabIndex = 2;
            this.TextSleepTime.Text = "2000";
            this.TextSleepTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Maximmum";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextMaxConnection
            // 
            this.TextMaxConnection.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextMaxConnection.Location = new System.Drawing.Point(19, 51);
            this.TextMaxConnection.Name = "TextMaxConnection";
            this.TextMaxConnection.Size = new System.Drawing.Size(100, 22);
            this.TextMaxConnection.TabIndex = 0;
            this.TextMaxConnection.Text = "220";
            this.TextMaxConnection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 9F);
            this.label5.Location = new System.Drawing.Point(194, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Connection Logs";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextLogs);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eclipse Origins Destroyer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuPacket;
        private System.Windows.Forms.ToolStripMenuItem MenuMessages;
        private System.Windows.Forms.ToolStripMenuItem MenuOverflow;
        private System.Windows.Forms.ToolStripMenuItem MenuCustom;
        private System.Windows.Forms.ToolStripMenuItem MenuRandomMode;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.RichTextBox TextLogs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextIpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextSleepTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextMaxConnection;
        private System.Windows.Forms.Label label5;
    }
}