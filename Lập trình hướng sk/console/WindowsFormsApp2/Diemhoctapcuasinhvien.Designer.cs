namespace WindowsFormsApp2
{
    partial class Diemhoctapcuasinhvien
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
            this.label_hovaten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_monhoc = new System.Windows.Forms.Label();
            this.label_lophc = new System.Windows.Forms.Label();
            this.label_diemchuyencan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_mon_hoc = new System.Windows.Forms.ComboBox();
            this.comboBox_lophanh_chinh = new System.Windows.Forms.ComboBox();
            this.textBox_diemchuyencan = new System.Windows.Forms.TextBox();
            this.textBox_hovaten = new System.Windows.Forms.TextBox();
            this.textBox_diem_giua_ky = new System.Windows.Forms.TextBox();
            this.textBox_diem_cuoi_ky = new System.Windows.Forms.TextBox();
            this.radioButton_ctdt_2022 = new System.Windows.Forms.RadioButton();
            this.radioButton_ctdt_2017 = new System.Windows.Forms.RadioButton();
            this.button_tinh_diem = new System.Windows.Forms.Button();
            this.button_tiep_tuc = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_ketqua = new System.Windows.Forms.ListBox();
            this.groupBox_thongtinsinhvien = new System.Windows.Forms.GroupBox();
            this.groupBox_thongtinsinhvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_hovaten
            // 
            this.label_hovaten.AutoSize = true;
            this.label_hovaten.Location = new System.Drawing.Point(19, 53);
            this.label_hovaten.Name = "label_hovaten";
            this.label_hovaten.Size = new System.Drawing.Size(64, 16);
            this.label_hovaten.TabIndex = 0;
            this.label_hovaten.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chương trình đào tạo";
            // 
            // label_monhoc
            // 
            this.label_monhoc.AutoSize = true;
            this.label_monhoc.Location = new System.Drawing.Point(19, 153);
            this.label_monhoc.Name = "label_monhoc";
            this.label_monhoc.Size = new System.Drawing.Size(58, 16);
            this.label_monhoc.TabIndex = 0;
            this.label_monhoc.Text = "Môn học";
            // 
            // label_lophc
            // 
            this.label_lophc.AutoSize = true;
            this.label_lophc.Location = new System.Drawing.Point(402, 150);
            this.label_lophc.Name = "label_lophc";
            this.label_lophc.Size = new System.Drawing.Size(52, 16);
            this.label_lophc.TabIndex = 0;
            this.label_lophc.Text = "Lớp HC";
            this.label_lophc.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_diemchuyencan
            // 
            this.label_diemchuyencan.AutoSize = true;
            this.label_diemchuyencan.Location = new System.Drawing.Point(402, 191);
            this.label_diemchuyencan.Name = "label_diemchuyencan";
            this.label_diemchuyencan.Size = new System.Drawing.Size(109, 16);
            this.label_diemchuyencan.TabIndex = 0;
            this.label_diemchuyencan.Text = "Điểm chuyên cần";
            this.label_diemchuyencan.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Điểm giữa kỳ";
            this.label9.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Điểm cuối kỳ";
            this.label10.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox_mon_hoc
            // 
            this.comboBox_mon_hoc.FormattingEnabled = true;
            this.comboBox_mon_hoc.Location = new System.Drawing.Point(81, 150);
            this.comboBox_mon_hoc.Name = "comboBox_mon_hoc";
            this.comboBox_mon_hoc.Size = new System.Drawing.Size(244, 24);
            this.comboBox_mon_hoc.TabIndex = 1;
            this.comboBox_mon_hoc.SelectedIndexChanged += new System.EventHandler(this.comboBox_mon_hoc_SelectedIndexChanged);
            // 
            // comboBox_lophanh_chinh
            // 
            this.comboBox_lophanh_chinh.FormattingEnabled = true;
            this.comboBox_lophanh_chinh.Location = new System.Drawing.Point(516, 147);
            this.comboBox_lophanh_chinh.Name = "comboBox_lophanh_chinh";
            this.comboBox_lophanh_chinh.Size = new System.Drawing.Size(133, 24);
            this.comboBox_lophanh_chinh.TabIndex = 1;
            this.comboBox_lophanh_chinh.SelectedIndexChanged += new System.EventHandler(this.comboBox_lophanh_chinh_SelectedIndexChanged);
            // 
            // textBox_diemchuyencan
            // 
            this.textBox_diemchuyencan.Location = new System.Drawing.Point(516, 184);
            this.textBox_diemchuyencan.Name = "textBox_diemchuyencan";
            this.textBox_diemchuyencan.Size = new System.Drawing.Size(100, 22);
            this.textBox_diemchuyencan.TabIndex = 2;
            this.textBox_diemchuyencan.TextChanged += new System.EventHandler(this.textBox_diemchuyencan_TextChanged_1);
            this.textBox_diemchuyencan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_diem_giua_ky_KeyPress);
            // 
            // textBox_hovaten
            // 
            this.textBox_hovaten.Location = new System.Drawing.Point(132, 50);
            this.textBox_hovaten.Name = "textBox_hovaten";
            this.textBox_hovaten.Size = new System.Drawing.Size(193, 22);
            this.textBox_hovaten.TabIndex = 2;
            this.textBox_hovaten.TextChanged += new System.EventHandler(this.textBox_hovaten_TextChanged);
            this.textBox_hovaten.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_hovaten_Validating);
            // 
            // textBox_diem_giua_ky
            // 
            this.textBox_diem_giua_ky.Location = new System.Drawing.Point(516, 228);
            this.textBox_diem_giua_ky.Name = "textBox_diem_giua_ky";
            this.textBox_diem_giua_ky.Size = new System.Drawing.Size(100, 22);
            this.textBox_diem_giua_ky.TabIndex = 2;
            this.textBox_diem_giua_ky.TextChanged += new System.EventHandler(this.textBox_diem_giua_ky_TextChanged);
            this.textBox_diem_giua_ky.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_diem_giua_ky_KeyPress);
            // 
            // textBox_diem_cuoi_ky
            // 
            this.textBox_diem_cuoi_ky.Location = new System.Drawing.Point(516, 272);
            this.textBox_diem_cuoi_ky.Name = "textBox_diem_cuoi_ky";
            this.textBox_diem_cuoi_ky.Size = new System.Drawing.Size(100, 22);
            this.textBox_diem_cuoi_ky.TabIndex = 2;
            this.textBox_diem_cuoi_ky.TextChanged += new System.EventHandler(this.textBox_diem_cuoi_ky_TextChanged);
            this.textBox_diem_cuoi_ky.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_diem_giua_ky_KeyPress);
            // 
            // radioButton_ctdt_2022
            // 
            this.radioButton_ctdt_2022.AutoSize = true;
            this.radioButton_ctdt_2022.Location = new System.Drawing.Point(306, 106);
            this.radioButton_ctdt_2022.Name = "radioButton_ctdt_2022";
            this.radioButton_ctdt_2022.Size = new System.Drawing.Size(95, 20);
            this.radioButton_ctdt_2022.TabIndex = 4;
            this.radioButton_ctdt_2022.TabStop = true;
            this.radioButton_ctdt_2022.Text = "CTĐT 2022";
            this.radioButton_ctdt_2022.UseVisualStyleBackColor = true;
            this.radioButton_ctdt_2022.CheckedChanged += new System.EventHandler(this.radioButton_ctdt_2022_CheckedChanged);
            // 
            // radioButton_ctdt_2017
            // 
            this.radioButton_ctdt_2017.AutoSize = true;
            this.radioButton_ctdt_2017.Location = new System.Drawing.Point(178, 106);
            this.radioButton_ctdt_2017.Name = "radioButton_ctdt_2017";
            this.radioButton_ctdt_2017.Size = new System.Drawing.Size(95, 20);
            this.radioButton_ctdt_2017.TabIndex = 5;
            this.radioButton_ctdt_2017.TabStop = true;
            this.radioButton_ctdt_2017.Text = "CTĐT 2017";
            this.radioButton_ctdt_2017.UseVisualStyleBackColor = true;
            this.radioButton_ctdt_2017.CheckedChanged += new System.EventHandler(this.radioButton_ctdt_2017_CheckedChanged);
            this.radioButton_ctdt_2017.Validating += new System.ComponentModel.CancelEventHandler(this.radioButton_ctdt_2017_Validating);
            // 
            // button_tinh_diem
            // 
            this.button_tinh_diem.Location = new System.Drawing.Point(64, 348);
            this.button_tinh_diem.Name = "button_tinh_diem";
            this.button_tinh_diem.Size = new System.Drawing.Size(93, 23);
            this.button_tinh_diem.TabIndex = 6;
            this.button_tinh_diem.Text = "Tính điểm";
            this.button_tinh_diem.UseVisualStyleBackColor = true;
            this.button_tinh_diem.Click += new System.EventHandler(this.button_tinh_diem_Click);
            // 
            // button_tiep_tuc
            // 
            this.button_tiep_tuc.Location = new System.Drawing.Point(228, 347);
            this.button_tiep_tuc.Name = "button_tiep_tuc";
            this.button_tiep_tuc.Size = new System.Drawing.Size(75, 23);
            this.button_tiep_tuc.TabIndex = 7;
            this.button_tiep_tuc.Text = "Tiếp tục";
            this.button_tiep_tuc.UseVisualStyleBackColor = true;
            this.button_tiep_tuc.Click += new System.EventHandler(this.button_tiep_tuc_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(405, 347);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(75, 23);
            this.button_thoat.TabIndex = 8;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(19, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết quả";
            // 
            // listBox_ketqua
            // 
            this.listBox_ketqua.FormattingEnabled = true;
            this.listBox_ketqua.ItemHeight = 16;
            this.listBox_ketqua.Location = new System.Drawing.Point(22, 435);
            this.listBox_ketqua.Name = "listBox_ketqua";
            this.listBox_ketqua.Size = new System.Drawing.Size(627, 116);
            this.listBox_ketqua.TabIndex = 10;
            // 
            // groupBox_thongtinsinhvien
            // 
            this.groupBox_thongtinsinhvien.Controls.Add(this.listBox_ketqua);
            this.groupBox_thongtinsinhvien.Controls.Add(this.label4);
            this.groupBox_thongtinsinhvien.Controls.Add(this.button_thoat);
            this.groupBox_thongtinsinhvien.Controls.Add(this.button_tiep_tuc);
            this.groupBox_thongtinsinhvien.Controls.Add(this.button_tinh_diem);
            this.groupBox_thongtinsinhvien.Controls.Add(this.radioButton_ctdt_2017);
            this.groupBox_thongtinsinhvien.Controls.Add(this.radioButton_ctdt_2022);
            this.groupBox_thongtinsinhvien.Controls.Add(this.textBox_diem_cuoi_ky);
            this.groupBox_thongtinsinhvien.Controls.Add(this.textBox_diem_giua_ky);
            this.groupBox_thongtinsinhvien.Controls.Add(this.textBox_hovaten);
            this.groupBox_thongtinsinhvien.Controls.Add(this.textBox_diemchuyencan);
            this.groupBox_thongtinsinhvien.Controls.Add(this.comboBox_lophanh_chinh);
            this.groupBox_thongtinsinhvien.Controls.Add(this.comboBox_mon_hoc);
            this.groupBox_thongtinsinhvien.Controls.Add(this.label10);
            this.groupBox_thongtinsinhvien.Controls.Add(this.label9);
            this.groupBox_thongtinsinhvien.Controls.Add(this.label_diemchuyencan);
            this.groupBox_thongtinsinhvien.Controls.Add(this.label_lophc);
            this.groupBox_thongtinsinhvien.Controls.Add(this.label_monhoc);
            this.groupBox_thongtinsinhvien.Controls.Add(this.label3);
            this.groupBox_thongtinsinhvien.Controls.Add(this.label_hovaten);
            this.groupBox_thongtinsinhvien.Location = new System.Drawing.Point(32, 47);
            this.groupBox_thongtinsinhvien.Name = "groupBox_thongtinsinhvien";
            this.groupBox_thongtinsinhvien.Size = new System.Drawing.Size(735, 615);
            this.groupBox_thongtinsinhvien.TabIndex = 0;
            this.groupBox_thongtinsinhvien.TabStop = false;
            this.groupBox_thongtinsinhvien.Text = "Thông tin sinh viên";
            this.groupBox_thongtinsinhvien.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Diemhoctapcuasinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.groupBox_thongtinsinhvien);
            this.Name = "Diemhoctapcuasinhvien";
            this.Text = "Diemhoctapcuasinhvien";
            this.groupBox_thongtinsinhvien.ResumeLayout(false);
            this.groupBox_thongtinsinhvien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_hovaten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_monhoc;
        private System.Windows.Forms.Label label_lophc;
        private System.Windows.Forms.Label label_diemchuyencan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_mon_hoc;
        private System.Windows.Forms.ComboBox comboBox_lophanh_chinh;
        private System.Windows.Forms.TextBox textBox_diemchuyencan;
        private System.Windows.Forms.TextBox textBox_hovaten;
        private System.Windows.Forms.TextBox textBox_diem_giua_ky;
        private System.Windows.Forms.TextBox textBox_diem_cuoi_ky;
        private System.Windows.Forms.RadioButton radioButton_ctdt_2022;
        private System.Windows.Forms.RadioButton radioButton_ctdt_2017;
        private System.Windows.Forms.Button button_tinh_diem;
        private System.Windows.Forms.Button button_tiep_tuc;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_ketqua;
        private System.Windows.Forms.GroupBox groupBox_thongtinsinhvien;
    }
}