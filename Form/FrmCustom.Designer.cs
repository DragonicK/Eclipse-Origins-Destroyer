namespace EngineDestroyer {
    partial class FrmCustom {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustom));
            this.btn_clear = new System.Windows.Forms.Button();
            this.list_rawdata = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bytearray = new System.Windows.Forms.Button();
            this.list_4bytes = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_sendtime = new System.Windows.Forms.TextBox();
            this.list_datatype = new System.Windows.Forms.ListBox();
            this.chk_loop = new System.Windows.Forms.CheckBox();
            this.cmb_datatype = new System.Windows.Forms.ComboBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_send = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(318, 313);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 25);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // list_rawdata
            // 
            this.list_rawdata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_rawdata.FormattingEnabled = true;
            this.list_rawdata.ItemHeight = 15;
            this.list_rawdata.Location = new System.Drawing.Point(3, 34);
            this.list_rawdata.Name = "list_rawdata";
            this.list_rawdata.Size = new System.Drawing.Size(200, 274);
            this.list_rawdata.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Packet Raw Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_bytearray
            // 
            this.btn_bytearray.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bytearray.Location = new System.Drawing.Point(3, 314);
            this.btn_bytearray.Name = "btn_bytearray";
            this.btn_bytearray.Size = new System.Drawing.Size(98, 25);
            this.btn_bytearray.TabIndex = 6;
            this.btn_bytearray.Text = "List Byte Array";
            this.btn_bytearray.UseVisualStyleBackColor = true;
            this.btn_bytearray.Click += new System.EventHandler(this.btn_bytearray_Click);
            // 
            // list_4bytes
            // 
            this.list_4bytes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_4bytes.Location = new System.Drawing.Point(105, 314);
            this.list_4bytes.Name = "list_4bytes";
            this.list_4bytes.Size = new System.Drawing.Size(98, 25);
            this.list_4bytes.TabIndex = 7;
            this.list_4bytes.Text = "List 4 Bytes";
            this.list_4bytes.UseVisualStyleBackColor = true;
            this.list_4bytes.Click += new System.EventHandler(this.list_4bytes_Click);
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(425, 313);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(130, 25);
            this.btn_send.TabIndex = 9;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_sendtime
            // 
            this.txt_sendtime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sendtime.Location = new System.Drawing.Point(425, 285);
            this.txt_sendtime.Name = "txt_sendtime";
            this.txt_sendtime.Size = new System.Drawing.Size(130, 23);
            this.txt_sendtime.TabIndex = 10;
            this.txt_sendtime.Text = "2000";
            this.txt_sendtime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sendtime_KeyPress);
            // 
            // list_datatype
            // 
            this.list_datatype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_datatype.FormattingEnabled = true;
            this.list_datatype.HorizontalScrollbar = true;
            this.list_datatype.ItemHeight = 15;
            this.list_datatype.Location = new System.Drawing.Point(218, 34);
            this.list_datatype.Name = "list_datatype";
            this.list_datatype.Size = new System.Drawing.Size(198, 274);
            this.list_datatype.TabIndex = 11;
            // 
            // chk_loop
            // 
            this.chk_loop.AutoSize = true;
            this.chk_loop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_loop.Location = new System.Drawing.Point(425, 232);
            this.chk_loop.Name = "chk_loop";
            this.chk_loop.Size = new System.Drawing.Size(53, 19);
            this.chk_loop.TabIndex = 12;
            this.chk_loop.Text = "Loop";
            this.chk_loop.UseVisualStyleBackColor = true;
            this.chk_loop.CheckedChanged += new System.EventHandler(this.chk_loop_CheckedChanged);
            // 
            // cmb_datatype
            // 
            this.cmb_datatype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_datatype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_datatype.FormattingEnabled = true;
            this.cmb_datatype.Items.AddRange(new object[] {
            "1 Byte",
            "2 Bytes",
            "4 Bytes",
            "String"});
            this.cmb_datatype.Location = new System.Drawing.Point(422, 95);
            this.cmb_datatype.Name = "cmb_datatype";
            this.cmb_datatype.Size = new System.Drawing.Size(130, 23);
            this.cmb_datatype.TabIndex = 15;
            this.cmb_datatype.SelectedIndexChanged += new System.EventHandler(this.cmb_datatype_SelectedIndexChanged);
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(422, 36);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(130, 23);
            this.txt_data.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(422, 124);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 25);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Send Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Packet Data Types";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(218, 313);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(98, 25);
            this.btn_remove.TabIndex = 20;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_size
            // 
            this.lbl_size.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.Location = new System.Drawing.Point(422, 153);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(141, 23);
            this.lbl_size.TabIndex = 21;
            this.lbl_size.Text = "Packet Size: 0 bytes";
            this.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_header
            // 
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(422, 176);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(141, 23);
            this.lbl_header.TabIndex = 22;
            this.lbl_header.Text = "Header: 0 ";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_send
            // 
            this.lbl_send.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_send.Location = new System.Drawing.Point(422, 199);
            this.lbl_send.Name = "lbl_send";
            this.lbl_send.Size = new System.Drawing.Size(141, 23);
            this.lbl_send.TabIndex = 23;
            this.lbl_send.Text = "Send Count: 0 ";
            this.lbl_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.list_rawdata);
            this.panel1.Controls.Add(this.btn_bytearray);
            this.panel1.Controls.Add(this.lbl_send);
            this.panel1.Controls.Add(this.list_4bytes);
            this.panel1.Controls.Add(this.lbl_header);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.lbl_size);
            this.panel1.Controls.Add(this.btn_send);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.txt_sendtime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.list_datatype);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chk_loop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.cmb_datatype);
            this.panel1.Controls.Add(this.txt_data);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 346);
            this.panel1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(12, 38);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(292, 23);
            this.txt_name.TabIndex = 27;
            this.txt_name.Text = "packet #01";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Description";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(12, 90);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(564, 23);
            this.txt_desc.TabIndex = 29;
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Location = new System.Drawing.Point(310, 36);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(130, 25);
            this.btn_open.TabIndex = 31;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(446, 36);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(130, 25);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 476);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Packet";
            this.Load += new System.EventHandler(this.FrmCustom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox list_rawdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bytearray;
        private System.Windows.Forms.Button list_4bytes;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_sendtime;
        private System.Windows.Forms.ListBox list_datatype;
        private System.Windows.Forms.CheckBox chk_loop;
        private System.Windows.Forms.ComboBox cmb_datatype;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Timer timer1;
    }
}