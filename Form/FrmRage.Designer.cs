namespace EngineDestroyer {
    partial class FrmRage {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRage));
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_send = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_totalsize = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 264);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(127, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_min
            // 
            this.txt_min.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_min.Location = new System.Drawing.Point(9, 40);
            this.txt_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_min.Multiline = true;
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(50, 21);
            this.txt_min.TabIndex = 13;
            this.txt_min.Text = "1";
            this.txt_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_max
            // 
            this.txt_max.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_max.Location = new System.Drawing.Point(65, 40);
            this.txt_max.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_max.Multiline = true;
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(50, 21);
            this.txt_max.TabIndex = 15;
            this.txt_max.Text = "400";
            this.txt_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(65, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_max);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_min);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 78);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_quant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 78);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "4 Bytes Data";
            // 
            // txt_quant
            // 
            this.txt_quant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_quant.Location = new System.Drawing.Point(9, 41);
            this.txt_quant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_quant.Multiline = true;
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(106, 21);
            this.txt_quant.TabIndex = 15;
            this.txt_quant.Text = "20";
            this.txt_quant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_time);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 78);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time";
            // 
            // txt_time
            // 
            this.txt_time.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_time.Location = new System.Drawing.Point(9, 41);
            this.txt_time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_time.Multiline = true;
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(106, 21);
            this.txt_time.TabIndex = 15;
            this.txt_time.Text = "2000";
            this.txt_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Send Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_send
            // 
            this.lbl_send.BackColor = System.Drawing.Color.Transparent;
            this.lbl_send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_send.Location = new System.Drawing.Point(145, 69);
            this.lbl_send.Name = "lbl_send";
            this.lbl_send.Size = new System.Drawing.Size(160, 20);
            this.lbl_send.TabIndex = 22;
            this.lbl_send.Text = "Send Count: 0";
            this.lbl_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_header.Location = new System.Drawing.Point(145, 32);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(160, 20);
            this.lbl_header.TabIndex = 21;
            this.lbl_header.Text = "Header: 0";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totalsize
            // 
            this.lbl_totalsize.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalsize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_totalsize.Location = new System.Drawing.Point(145, 12);
            this.lbl_totalsize.Name = "lbl_totalsize";
            this.lbl_totalsize.Size = new System.Drawing.Size(160, 20);
            this.lbl_totalsize.TabIndex = 20;
            this.lbl_totalsize.Text = "Packet Size: 0 bytes";
            this.lbl_totalsize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmRage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 301);
            this.Controls.Add(this.lbl_send);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lbl_totalsize);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rage Mode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_send;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_totalsize;
        private System.Windows.Forms.Timer timer1;
    }
}