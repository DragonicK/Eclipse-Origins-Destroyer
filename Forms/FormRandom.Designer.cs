namespace EngineDestroyer {
    partial class FormRandom {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRandom));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TextHeaderMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextHeaderMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextSendTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelSendCount = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonStart.Location = new System.Drawing.Point(17, 344);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(148, 27);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // TextHeaderMin
            // 
            this.TextHeaderMin.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextHeaderMin.Location = new System.Drawing.Point(10, 47);
            this.TextHeaderMin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextHeaderMin.Multiline = true;
            this.TextHeaderMin.Name = "TextHeaderMin";
            this.TextHeaderMin.Size = new System.Drawing.Size(58, 24);
            this.TextHeaderMin.TabIndex = 13;
            this.TextHeaderMin.Text = "1";
            this.TextHeaderMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F);
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextHeaderMax
            // 
            this.TextHeaderMax.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextHeaderMax.Location = new System.Drawing.Point(76, 47);
            this.TextHeaderMax.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextHeaderMax.Multiline = true;
            this.TextHeaderMax.Name = "TextHeaderMax";
            this.TextHeaderMax.Size = new System.Drawing.Size(58, 24);
            this.TextHeaderMax.TabIndex = 15;
            this.TextHeaderMax.Text = "400";
            this.TextHeaderMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F);
            this.label2.Location = new System.Drawing.Point(76, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextHeaderMax);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextHeaderMin);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 91);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextQuantity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox2.Location = new System.Drawing.Point(17, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 91);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "4 Bytes Data";
            // 
            // TextQuantity
            // 
            this.TextQuantity.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextQuantity.Location = new System.Drawing.Point(10, 48);
            this.TextQuantity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextQuantity.Multiline = true;
            this.TextQuantity.Name = "TextQuantity";
            this.TextQuantity.Size = new System.Drawing.Size(123, 24);
            this.TextQuantity.TabIndex = 15;
            this.TextQuantity.Text = "20";
            this.TextQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F);
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextSendTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox3.Location = new System.Drawing.Point(17, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 91);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time";
            // 
            // TextSendTime
            // 
            this.TextSendTime.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextSendTime.Location = new System.Drawing.Point(10, 48);
            this.TextSendTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextSendTime.Multiline = true;
            this.TextSendTime.Name = "TextSendTime";
            this.TextSendTime.Size = new System.Drawing.Size(123, 24);
            this.TextSendTime.TabIndex = 15;
            this.TextSendTime.Text = "2000";
            this.TextSendTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F);
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Send Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSendCount
            // 
            this.LabelSendCount.BackColor = System.Drawing.Color.Transparent;
            this.LabelSendCount.Font = new System.Drawing.Font("Consolas", 9F);
            this.LabelSendCount.Location = new System.Drawing.Point(14, 318);
            this.LabelSendCount.Name = "LabelSendCount";
            this.LabelSendCount.Size = new System.Drawing.Size(151, 23);
            this.LabelSendCount.TabIndex = 22;
            this.LabelSendCount.Text = "Send Count: 0";
            this.LabelSendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.ButtonStart);
            this.groupBox4.Controls.Add(this.LabelSendCount);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(14, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 391);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // FormRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 417);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRandom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Mode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRandom_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TextBox TextHeaderMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextHeaderMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextSendTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelSendCount;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}