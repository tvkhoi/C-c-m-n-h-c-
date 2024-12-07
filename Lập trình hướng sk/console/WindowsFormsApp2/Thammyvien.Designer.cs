namespace WindowsFormsApp2
{
    partial class thammyvien_TVK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thammyvien_TVK));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_sokhambenh = new System.Windows.Forms.Button();
            this.textBox_ngay_TVK = new System.Windows.Forms.TextBox();
            this.textBox_thang_TVK = new System.Windows.Forms.TextBox();
            this.textBox_nam_TVK = new System.Windows.Forms.TextBox();
            this.listBox_ketqua_TVK = new System.Windows.Forms.ListBox();
            this.listBox_dsdichvu_TVK = new System.Windows.Forms.ListBox();
            this.button_chuyenform_TVK = new System.Windows.Forms.Button();
            this.button_thoat_TVK = new System.Windows.Forms.Button();
            this.button_tieptuc_TVK = new System.Windows.Forms.Button();
            this.button_chon_TVK = new System.Windows.Forms.Button();
            this.comboBox_maBN_TVK = new System.Windows.Forms.ComboBox();
            this.comboBox_chondichvu_TVK = new System.Windows.Forms.ComboBox();
            this.textBox_tenbenhnhan_TVK = new System.Windows.Forms.TextBox();
            this.label_thang = new System.Windows.Forms.Label();
            this.label_nam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_chondichvu = new System.Windows.Forms.Label();
            this.label_ngay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tenbenhnhan = new System.Windows.Forms.Label();
            this.label_ketqua = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Salmon;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_sokhambenh);
            this.groupBox1.Controls.Add(this.textBox_ngay_TVK);
            this.groupBox1.Controls.Add(this.textBox_thang_TVK);
            this.groupBox1.Controls.Add(this.textBox_nam_TVK);
            this.groupBox1.Controls.Add(this.listBox_ketqua_TVK);
            this.groupBox1.Controls.Add(this.listBox_dsdichvu_TVK);
            this.groupBox1.Controls.Add(this.button_chuyenform_TVK);
            this.groupBox1.Controls.Add(this.button_thoat_TVK);
            this.groupBox1.Controls.Add(this.button_tieptuc_TVK);
            this.groupBox1.Controls.Add(this.button_chon_TVK);
            this.groupBox1.Controls.Add(this.comboBox_maBN_TVK);
            this.groupBox1.Controls.Add(this.comboBox_chondichvu_TVK);
            this.groupBox1.Controls.Add(this.textBox_tenbenhnhan_TVK);
            this.groupBox1.Controls.Add(this.label_thang);
            this.groupBox1.Controls.Add(this.label_nam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_chondichvu);
            this.groupBox1.Controls.Add(this.label_ngay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_tenbenhnhan);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_sokhambenh
            // 
            this.button_sokhambenh.Location = new System.Drawing.Point(554, 312);
            this.button_sokhambenh.Name = "button_sokhambenh";
            this.button_sokhambenh.Size = new System.Drawing.Size(111, 23);
            this.button_sokhambenh.TabIndex = 10;
            this.button_sokhambenh.Text = "Sổ khám bệnh";
            this.button_sokhambenh.UseVisualStyleBackColor = true;
            this.button_sokhambenh.Click += new System.EventHandler(this.button_sokhambenh_Click);
            // 
            // textBox_ngay_TVK
            // 
            this.textBox_ngay_TVK.Location = new System.Drawing.Point(112, 105);
            this.textBox_ngay_TVK.Name = "textBox_ngay_TVK";
            this.textBox_ngay_TVK.Size = new System.Drawing.Size(49, 22);
            this.textBox_ngay_TVK.TabIndex = 9;
            this.textBox_ngay_TVK.TextChanged += new System.EventHandler(this.textBox_ngay_TextChanged);
            this.textBox_ngay_TVK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ngay_KeyPress_1);
            this.textBox_ngay_TVK.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ngay_Validating);
            // 
            // textBox_thang_TVK
            // 
            this.textBox_thang_TVK.Location = new System.Drawing.Point(258, 102);
            this.textBox_thang_TVK.Name = "textBox_thang_TVK";
            this.textBox_thang_TVK.Size = new System.Drawing.Size(49, 22);
            this.textBox_thang_TVK.TabIndex = 8;
            this.textBox_thang_TVK.TextChanged += new System.EventHandler(this.textBox_thang_TextChanged);
            this.textBox_thang_TVK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ngay_KeyPress_1);
            this.textBox_thang_TVK.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_thang_Validating);
            // 
            // textBox_nam_TVK
            // 
            this.textBox_nam_TVK.Location = new System.Drawing.Point(371, 98);
            this.textBox_nam_TVK.Name = "textBox_nam_TVK";
            this.textBox_nam_TVK.Size = new System.Drawing.Size(100, 22);
            this.textBox_nam_TVK.TabIndex = 7;
            this.textBox_nam_TVK.TextChanged += new System.EventHandler(this.textBox_nam_TextChanged);
            this.textBox_nam_TVK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ngay_KeyPress_1);
            this.textBox_nam_TVK.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_nam_Validating);
            // 
            // listBox_ketqua_TVK
            // 
            this.listBox_ketqua_TVK.FormattingEnabled = true;
            this.listBox_ketqua_TVK.ItemHeight = 16;
            this.listBox_ketqua_TVK.Location = new System.Drawing.Point(68, 417);
            this.listBox_ketqua_TVK.Name = "listBox_ketqua_TVK";
            this.listBox_ketqua_TVK.Size = new System.Drawing.Size(602, 148);
            this.listBox_ketqua_TVK.TabIndex = 6;
            // 
            // listBox_dsdichvu_TVK
            // 
            this.listBox_dsdichvu_TVK.FormattingEnabled = true;
            this.listBox_dsdichvu_TVK.ItemHeight = 16;
            this.listBox_dsdichvu_TVK.Location = new System.Drawing.Point(470, 138);
            this.listBox_dsdichvu_TVK.Name = "listBox_dsdichvu_TVK";
            this.listBox_dsdichvu_TVK.Size = new System.Drawing.Size(200, 132);
            this.listBox_dsdichvu_TVK.TabIndex = 5;
            this.listBox_dsdichvu_TVK.Validating += new System.ComponentModel.CancelEventHandler(this.listBox_dsdichvu_Validating);
            // 
            // button_chuyenform_TVK
            // 
            this.button_chuyenform_TVK.Image = ((System.Drawing.Image)(resources.GetObject("button_chuyenform_TVK.Image")));
            this.button_chuyenform_TVK.Location = new System.Drawing.Point(470, 300);
            this.button_chuyenform_TVK.Name = "button_chuyenform_TVK";
            this.button_chuyenform_TVK.Size = new System.Drawing.Size(57, 43);
            this.button_chuyenform_TVK.TabIndex = 4;
            this.button_chuyenform_TVK.UseVisualStyleBackColor = true;
            this.button_chuyenform_TVK.Click += new System.EventHandler(this.button_chuyenform_TVK_Click);
            // 
            // button_thoat_TVK
            // 
            this.button_thoat_TVK.Location = new System.Drawing.Point(326, 305);
            this.button_thoat_TVK.Name = "button_thoat_TVK";
            this.button_thoat_TVK.Size = new System.Drawing.Size(75, 31);
            this.button_thoat_TVK.TabIndex = 4;
            this.button_thoat_TVK.Text = "Thoát";
            this.button_thoat_TVK.UseVisualStyleBackColor = true;
            this.button_thoat_TVK.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_tieptuc_TVK
            // 
            this.button_tieptuc_TVK.Location = new System.Drawing.Point(209, 305);
            this.button_tieptuc_TVK.Name = "button_tieptuc_TVK";
            this.button_tieptuc_TVK.Size = new System.Drawing.Size(75, 31);
            this.button_tieptuc_TVK.TabIndex = 4;
            this.button_tieptuc_TVK.Text = "Tiếp tục";
            this.button_tieptuc_TVK.UseVisualStyleBackColor = true;
            this.button_tieptuc_TVK.Click += new System.EventHandler(this.button_tieptuc_Click);
            this.button_tieptuc_TVK.Validating += new System.ComponentModel.CancelEventHandler(this.button_tieptuc_Validating);
            // 
            // button_chon_TVK
            // 
            this.button_chon_TVK.Location = new System.Drawing.Point(86, 305);
            this.button_chon_TVK.Name = "button_chon_TVK";
            this.button_chon_TVK.Size = new System.Drawing.Size(75, 31);
            this.button_chon_TVK.TabIndex = 4;
            this.button_chon_TVK.Text = "Chọn";
            this.button_chon_TVK.UseVisualStyleBackColor = true;
            this.button_chon_TVK.Click += new System.EventHandler(this.button_chon_Click);
            // 
            // comboBox_maBN_TVK
            // 
            this.comboBox_maBN_TVK.FormattingEnabled = true;
            this.comboBox_maBN_TVK.Location = new System.Drawing.Point(209, 25);
            this.comboBox_maBN_TVK.Name = "comboBox_maBN_TVK";
            this.comboBox_maBN_TVK.Size = new System.Drawing.Size(155, 24);
            this.comboBox_maBN_TVK.TabIndex = 2;
            this.comboBox_maBN_TVK.SelectedIndexChanged += new System.EventHandler(this.comboBox_maBN_TVK_SelectedIndexChanged);
            this.comboBox_maBN_TVK.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_maBN_TVK_Validating);
            // 
            // comboBox_chondichvu_TVK
            // 
            this.comboBox_chondichvu_TVK.FormattingEnabled = true;
            this.comboBox_chondichvu_TVK.Location = new System.Drawing.Point(171, 137);
            this.comboBox_chondichvu_TVK.Name = "comboBox_chondichvu_TVK";
            this.comboBox_chondichvu_TVK.Size = new System.Drawing.Size(137, 24);
            this.comboBox_chondichvu_TVK.TabIndex = 2;
            this.comboBox_chondichvu_TVK.SelectedIndexChanged += new System.EventHandler(this.comboBox_chondichvu_SelectedIndexChanged);
            this.comboBox_chondichvu_TVK.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_chondichvu_Validating);
            // 
            // textBox_tenbenhnhan_TVK
            // 
            this.textBox_tenbenhnhan_TVK.Location = new System.Drawing.Point(209, 64);
            this.textBox_tenbenhnhan_TVK.Name = "textBox_tenbenhnhan_TVK";
            this.textBox_tenbenhnhan_TVK.Size = new System.Drawing.Size(210, 22);
            this.textBox_tenbenhnhan_TVK.TabIndex = 1;
            this.textBox_tenbenhnhan_TVK.TextChanged += new System.EventHandler(this.textBox_tenbenhnhan_TextChanged);
            this.textBox_tenbenhnhan_TVK.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label_thang
            // 
            this.label_thang.AutoSize = true;
            this.label_thang.Location = new System.Drawing.Point(206, 105);
            this.label_thang.Name = "label_thang";
            this.label_thang.Size = new System.Drawing.Size(46, 16);
            this.label_thang.TabIndex = 0;
            this.label_thang.Text = "Tháng";
            // 
            // label_nam
            // 
            this.label_nam.AutoSize = true;
            this.label_nam.Location = new System.Drawing.Point(328, 105);
            this.label_nam.Name = "label_nam";
            this.label_nam.Size = new System.Drawing.Size(36, 16);
            this.label_nam.TabIndex = 0;
            this.label_nam.Text = "Năm";
            this.label_nam.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách dịch vụ";
            // 
            // label_chondichvu
            // 
            this.label_chondichvu.AutoSize = true;
            this.label_chondichvu.Location = new System.Drawing.Point(65, 145);
            this.label_chondichvu.Name = "label_chondichvu";
            this.label_chondichvu.Size = new System.Drawing.Size(83, 16);
            this.label_chondichvu.TabIndex = 0;
            this.label_chondichvu.Text = "Chọn dịch vụ";
            // 
            // label_ngay
            // 
            this.label_ngay.AutoSize = true;
            this.label_ngay.Location = new System.Drawing.Point(65, 105);
            this.label_ngay.Name = "label_ngay";
            this.label_ngay.Size = new System.Drawing.Size(40, 16);
            this.label_ngay.TabIndex = 0;
            this.label_ngay.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bệnh nhân";
            // 
            // label_tenbenhnhan
            // 
            this.label_tenbenhnhan.AutoSize = true;
            this.label_tenbenhnhan.Location = new System.Drawing.Point(65, 67);
            this.label_tenbenhnhan.Name = "label_tenbenhnhan";
            this.label_tenbenhnhan.Size = new System.Drawing.Size(96, 16);
            this.label_tenbenhnhan.TabIndex = 0;
            this.label_tenbenhnhan.Text = "Tên bệnh nhân";
            // 
            // label_ketqua
            // 
            this.label_ketqua.AutoSize = true;
            this.label_ketqua.BackColor = System.Drawing.Color.Transparent;
            this.label_ketqua.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_ketqua.Location = new System.Drawing.Point(70, 392);
            this.label_ketqua.Name = "label_ketqua";
            this.label_ketqua.Size = new System.Drawing.Size(52, 16);
            this.label_ketqua.TabIndex = 1;
            this.label_ketqua.Text = "Kết quả";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Danh sách bệnh nhân";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thammyvien_TVK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(748, 575);
            this.Controls.Add(this.label_ketqua);
            this.Controls.Add(this.groupBox1);
            this.Name = "thammyvien_TVK";
            this.Text = "Thẩm mỹ viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_thang;
        private System.Windows.Forms.Label label_ngay;
        private System.Windows.Forms.Label label_tenbenhnhan;
        private System.Windows.Forms.Label label_nam;
        private System.Windows.Forms.ComboBox comboBox_chondichvu_TVK;
        private System.Windows.Forms.Label label_chondichvu;
        private System.Windows.Forms.Button button_thoat_TVK;
        private System.Windows.Forms.Button button_tieptuc_TVK;
        private System.Windows.Forms.Button button_chon_TVK;
        private System.Windows.Forms.Label label_ketqua;
        private System.Windows.Forms.ListBox listBox_dsdichvu_TVK;
        private System.Windows.Forms.ListBox listBox_ketqua_TVK;
        private System.Windows.Forms.TextBox textBox_tenbenhnhan_TVK;
        private System.Windows.Forms.TextBox textBox_nam_TVK;
        private System.Windows.Forms.TextBox textBox_thang_TVK;
        private System.Windows.Forms.TextBox textBox_ngay_TVK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_maBN_TVK;
        private System.Windows.Forms.Button button_chuyenform_TVK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_sokhambenh;
        private System.Windows.Forms.Button button1;
    }
}

