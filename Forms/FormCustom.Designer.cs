namespace EngineDestroyer {
    partial class FormCustom {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustom));
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonListType = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.TextSendInterval = new System.Windows.Forms.TextBox();
            this.ListData = new System.Windows.Forms.ListBox();
            this.CheckLoop = new System.Windows.Forms.CheckBox();
            this.ComboDataType = new System.Windows.Forms.ComboBox();
            this.TextData = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.LabelPacketSize = new System.Windows.Forms.Label();
            this.LabelSend = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextDescription = new System.Windows.Forms.TextBox();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.CheckAutomaticStringLength = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonClear.Location = new System.Drawing.Point(318, 313);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(98, 25);
            this.ButtonClear.TabIndex = 3;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonListType
            // 
            this.ButtonListType.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonListType.Location = new System.Drawing.Point(7, 313);
            this.ButtonListType.Name = "ButtonListType";
            this.ButtonListType.Size = new System.Drawing.Size(205, 25);
            this.ButtonListType.TabIndex = 7;
            this.ButtonListType.Text = "List Types";
            this.ButtonListType.UseVisualStyleBackColor = true;
            this.ButtonListType.Click += new System.EventHandler(this.ButtonListType_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonSend.Location = new System.Drawing.Point(425, 313);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(130, 25);
            this.ButtonSend.TabIndex = 9;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextSendInterval
            // 
            this.TextSendInterval.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextSendInterval.Location = new System.Drawing.Point(425, 285);
            this.TextSendInterval.Name = "TextSendInterval";
            this.TextSendInterval.Size = new System.Drawing.Size(130, 22);
            this.TextSendInterval.TabIndex = 10;
            this.TextSendInterval.Text = "2000";
            this.TextSendInterval.TextChanged += new System.EventHandler(this.TextSendInterval_TextChanged);
            this.TextSendInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            // 
            // ListData
            // 
            this.ListData.Font = new System.Drawing.Font("Consolas", 9F);
            this.ListData.FormattingEnabled = true;
            this.ListData.HorizontalScrollbar = true;
            this.ListData.ItemHeight = 14;
            this.ListData.Location = new System.Drawing.Point(7, 34);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(409, 270);
            this.ListData.TabIndex = 11;
            // 
            // CheckLoop
            // 
            this.CheckLoop.AutoSize = true;
            this.CheckLoop.Font = new System.Drawing.Font("Consolas", 9F);
            this.CheckLoop.Location = new System.Drawing.Point(425, 243);
            this.CheckLoop.Name = "CheckLoop";
            this.CheckLoop.Size = new System.Drawing.Size(54, 18);
            this.CheckLoop.TabIndex = 12;
            this.CheckLoop.Text = "Loop";
            this.CheckLoop.UseVisualStyleBackColor = true;
            this.CheckLoop.CheckedChanged += new System.EventHandler(this.CheckLoop_CheckedChanged);
            // 
            // ComboDataType
            // 
            this.ComboDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDataType.Font = new System.Drawing.Font("Consolas", 9F);
            this.ComboDataType.FormattingEnabled = true;
            this.ComboDataType.Location = new System.Drawing.Point(422, 135);
            this.ComboDataType.Name = "ComboDataType";
            this.ComboDataType.Size = new System.Drawing.Size(130, 22);
            this.ComboDataType.TabIndex = 15;
            // 
            // TextData
            // 
            this.TextData.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextData.Location = new System.Drawing.Point(422, 36);
            this.TextData.Name = "TextData";
            this.TextData.Size = new System.Drawing.Size(130, 22);
            this.TextData.TabIndex = 14;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonAdd.Location = new System.Drawing.Point(422, 164);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(130, 25);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 9F);
            this.label2.Location = new System.Drawing.Point(419, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 9F);
            this.label4.Location = new System.Drawing.Point(422, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Send Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 9F);
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Packet Data Types";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonRemove.Location = new System.Drawing.Point(218, 313);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(98, 25);
            this.ButtonRemove.TabIndex = 20;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // LabelPacketSize
            // 
            this.LabelPacketSize.Font = new System.Drawing.Font("Consolas", 9F);
            this.LabelPacketSize.Location = new System.Drawing.Point(422, 196);
            this.LabelPacketSize.Name = "LabelPacketSize";
            this.LabelPacketSize.Size = new System.Drawing.Size(141, 20);
            this.LabelPacketSize.TabIndex = 21;
            this.LabelPacketSize.Text = "Packet Size: 0 Bytes";
            this.LabelPacketSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSend
            // 
            this.LabelSend.Font = new System.Drawing.Font("Consolas", 9F);
            this.LabelSend.Location = new System.Drawing.Point(422, 216);
            this.LabelSend.Name = "LabelSend";
            this.LabelSend.Size = new System.Drawing.Size(138, 20);
            this.LabelSend.TabIndex = 23;
            this.LabelSend.Text = "Send Count: 0 ";
            this.LabelSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 9F);
            this.label3.Location = new System.Drawing.Point(422, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckAutomaticStringLength);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelSend);
            this.panel1.Controls.Add(this.ButtonListType);
            this.panel1.Controls.Add(this.ButtonClear);
            this.panel1.Controls.Add(this.LabelPacketSize);
            this.panel1.Controls.Add(this.ButtonSend);
            this.panel1.Controls.Add(this.ButtonRemove);
            this.panel1.Controls.Add(this.TextSendInterval);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ListData);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CheckLoop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ButtonAdd);
            this.panel1.Controls.Add(this.ComboDataType);
            this.panel1.Controls.Add(this.TextData);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 346);
            this.panel1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 9F);
            this.label6.Location = new System.Drawing.Point(16, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextName.Location = new System.Drawing.Point(12, 38);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(292, 22);
            this.TextName.TabIndex = 27;
            this.TextName.Text = "packet #01";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 9F);
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Description";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextDescription
            // 
            this.TextDescription.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextDescription.Location = new System.Drawing.Point(12, 90);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(564, 22);
            this.TextDescription.TabIndex = 29;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonOpen.Location = new System.Drawing.Point(310, 36);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(130, 25);
            this.ButtonOpen.TabIndex = 31;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonSave.Location = new System.Drawing.Point(446, 36);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(130, 25);
            this.ButtonSave.TabIndex = 32;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // CheckAutomaticStringLength
            // 
            this.CheckAutomaticStringLength.Font = new System.Drawing.Font("Consolas", 9F);
            this.CheckAutomaticStringLength.Location = new System.Drawing.Point(422, 64);
            this.CheckAutomaticStringLength.Name = "CheckAutomaticStringLength";
            this.CheckAutomaticStringLength.Size = new System.Drawing.Size(138, 42);
            this.CheckAutomaticStringLength.TabIndex = 26;
            this.CheckAutomaticStringLength.Text = "Automatic String Length";
            this.CheckAutomaticStringLength.UseVisualStyleBackColor = true;
            this.CheckAutomaticStringLength.CheckedChanged += new System.EventHandler(this.CheckAutomaticStringLength_CheckedChanged);
            // 
            // FormCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 476);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Packet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustom_FormClosing);
            this.Load += new System.EventHandler(this.FormCustom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonListType;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.TextBox TextSendInterval;
        private System.Windows.Forms.ListBox ListData;
        private System.Windows.Forms.CheckBox CheckLoop;
        private System.Windows.Forms.ComboBox ComboDataType;
        private System.Windows.Forms.TextBox TextData;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Label LabelPacketSize;
        private System.Windows.Forms.Label LabelSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextDescription;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.CheckBox CheckAutomaticStringLength;
    }
}