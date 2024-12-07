namespace btlLTHSK
{
    partial class HDNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_HDNhap = new System.Windows.Forms.GroupBox();
            this.comboBox_NhaCC = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_MaNV = new System.Windows.Forms.ComboBox();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Xua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.dateTimePicker_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.textBox_MaHDNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_HoaDonPN = new System.Windows.Forms.DataGridView();
            this.Column_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.button_InHD_HDNhap = new System.Windows.Forms.Button();
            this.comboBox_Chon_Timkiem = new System.Windows.Forms.ComboBox();
            this.textBox_timkiem_sl_banghi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_tim_sl = new System.Windows.Forms.Button();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_HDNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDonPN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(382, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Nhập Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // groupBox_HDNhap
            // 
            this.groupBox_HDNhap.Controls.Add(this.button_tim_sl);
            this.groupBox_HDNhap.Controls.Add(this.textBox_timkiem_sl_banghi);
            this.groupBox_HDNhap.Controls.Add(this.comboBox_NhaCC);
            this.groupBox_HDNhap.Controls.Add(this.pictureBox1);
            this.groupBox_HDNhap.Controls.Add(this.comboBox_MaNV);
            this.groupBox_HDNhap.Controls.Add(this.button_Huy);
            this.groupBox_HDNhap.Controls.Add(this.button_Xoa);
            this.groupBox_HDNhap.Controls.Add(this.button_Xua);
            this.groupBox_HDNhap.Controls.Add(this.button_Them);
            this.groupBox_HDNhap.Controls.Add(this.dateTimePicker_NgayNhap);
            this.groupBox_HDNhap.Controls.Add(this.textBox_MaHDNhap);
            this.groupBox_HDNhap.Controls.Add(this.label5);
            this.groupBox_HDNhap.Controls.Add(this.label4);
            this.groupBox_HDNhap.Controls.Add(this.label7);
            this.groupBox_HDNhap.Controls.Add(this.label3);
            this.groupBox_HDNhap.Controls.Add(this.label2);
            this.groupBox_HDNhap.Location = new System.Drawing.Point(22, 72);
            this.groupBox_HDNhap.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_HDNhap.Name = "groupBox_HDNhap";
            this.groupBox_HDNhap.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_HDNhap.Size = new System.Drawing.Size(889, 253);
            this.groupBox_HDNhap.TabIndex = 2;
            this.groupBox_HDNhap.TabStop = false;
            this.groupBox_HDNhap.Text = "Hóa Đơn Lấy Hàng";
            // 
            // comboBox_NhaCC
            // 
            this.comboBox_NhaCC.FormattingEnabled = true;
            this.comboBox_NhaCC.Location = new System.Drawing.Point(583, 32);
            this.comboBox_NhaCC.Name = "comboBox_NhaCC";
            this.comboBox_NhaCC.Size = new System.Drawing.Size(207, 24);
            this.comboBox_NhaCC.TabIndex = 6;
            this.comboBox_NhaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_NhaCC_KeyPress);
            this.comboBox_NhaCC.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_NhaCC_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::btlLTHSK.Properties.Resources.tải_xuống__1_2;
            this.pictureBox1.Location = new System.Drawing.Point(794, 165);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 52);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_MaNV
            // 
            this.comboBox_MaNV.FormattingEnabled = true;
            this.comboBox_MaNV.Location = new System.Drawing.Point(163, 75);
            this.comboBox_MaNV.Name = "comboBox_MaNV";
            this.comboBox_MaNV.Size = new System.Drawing.Size(207, 24);
            this.comboBox_MaNV.TabIndex = 5;
            this.comboBox_MaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_MaNV_KeyPress);
            this.comboBox_MaNV.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_MaNV_Validating);
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(637, 165);
            this.button_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(84, 29);
            this.button_Huy.TabIndex = 4;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(473, 165);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(84, 29);
            this.button_Xoa.TabIndex = 4;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Xua
            // 
            this.button_Xua.Location = new System.Drawing.Point(213, 165);
            this.button_Xua.Margin = new System.Windows.Forms.Padding(2);
            this.button_Xua.Name = "button_Xua";
            this.button_Xua.Size = new System.Drawing.Size(84, 29);
            this.button_Xua.TabIndex = 4;
            this.button_Xua.Text = "Sửa";
            this.button_Xua.UseVisualStyleBackColor = true;
            this.button_Xua.Click += new System.EventHandler(this.button_Xua_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(87, 165);
            this.button_Them.Margin = new System.Windows.Forms.Padding(2);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(84, 29);
            this.button_Them.TabIndex = 4;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // dateTimePicker_NgayNhap
            // 
            this.dateTimePicker_NgayNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePicker_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayNhap.Location = new System.Drawing.Point(583, 75);
            this.dateTimePicker_NgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_NgayNhap.Name = "dateTimePicker_NgayNhap";
            this.dateTimePicker_NgayNhap.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker_NgayNhap.TabIndex = 3;
            this.dateTimePicker_NgayNhap.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_NgayNhap_Validating);
            // 
            // textBox_MaHDNhap
            // 
            this.textBox_MaHDNhap.Location = new System.Drawing.Point(163, 33);
            this.textBox_MaHDNhap.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MaHDNhap.Name = "textBox_MaHDNhap";
            this.textBox_MaHDNhap.Size = new System.Drawing.Size(207, 22);
            this.textBox_MaHDNhap.TabIndex = 2;
            this.textBox_MaHDNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MaHDNhap_KeyPress);
            this.textBox_MaHDNhap.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaHDNhap_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Nhà Cung Cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // dataGridView_HoaDonPN
            // 
            this.dataGridView_HoaDonPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaDonPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaHD,
            this.Column_MaNV,
            this.Column_MaNCC,
            this.Column_NgayNhap,
            this.Column1});
            this.dataGridView_HoaDonPN.Location = new System.Drawing.Point(22, 399);
            this.dataGridView_HoaDonPN.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_HoaDonPN.Name = "dataGridView_HoaDonPN";
            this.dataGridView_HoaDonPN.ReadOnly = true;
            this.dataGridView_HoaDonPN.RowHeadersWidth = 82;
            this.dataGridView_HoaDonPN.RowTemplate.Height = 33;
            this.dataGridView_HoaDonPN.Size = new System.Drawing.Size(889, 221);
            this.dataGridView_HoaDonPN.TabIndex = 3;
            this.dataGridView_HoaDonPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HoaDonPN_CellClick);
            // 
            // Column_MaHD
            // 
            this.Column_MaHD.HeaderText = "Mã HD Nhập";
            this.Column_MaHD.MinimumWidth = 10;
            this.Column_MaHD.Name = "Column_MaHD";
            this.Column_MaHD.ReadOnly = true;
            this.Column_MaHD.Width = 125;
            // 
            // Column_MaNV
            // 
            this.Column_MaNV.HeaderText = "Mã NV";
            this.Column_MaNV.MinimumWidth = 10;
            this.Column_MaNV.Name = "Column_MaNV";
            this.Column_MaNV.ReadOnly = true;
            this.Column_MaNV.Width = 125;
            // 
            // Column_MaNCC
            // 
            this.Column_MaNCC.HeaderText = "Mã NCC";
            this.Column_MaNCC.MinimumWidth = 10;
            this.Column_MaNCC.Name = "Column_MaNCC";
            this.Column_MaNCC.ReadOnly = true;
            this.Column_MaNCC.Width = 125;
            // 
            // Column_NgayNhap
            // 
            this.Column_NgayNhap.HeaderText = "Ngày Nhập";
            this.Column_NgayNhap.MinimumWidth = 10;
            this.Column_NgayNhap.Name = "Column_NgayNhap";
            this.Column_NgayNhap.ReadOnly = true;
            this.Column_NgayNhap.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm Kiếm:";
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(158, 366);
            this.textBox_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(207, 22);
            this.textBox_TimKiem.TabIndex = 2;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // button_InHD_HDNhap
            // 
            this.button_InHD_HDNhap.Location = new System.Drawing.Point(816, 329);
            this.button_InHD_HDNhap.Margin = new System.Windows.Forms.Padding(2);
            this.button_InHD_HDNhap.Name = "button_InHD_HDNhap";
            this.button_InHD_HDNhap.Size = new System.Drawing.Size(124, 29);
            this.button_InHD_HDNhap.TabIndex = 19;
            this.button_InHD_HDNhap.Text = "in hóa đơn";
            this.button_InHD_HDNhap.UseVisualStyleBackColor = true;
            this.button_InHD_HDNhap.Click += new System.EventHandler(this.button_InHD_HDNhap_Click);
            // 
            // comboBox_Chon_Timkiem
            // 
            this.comboBox_Chon_Timkiem.FormattingEnabled = true;
            this.comboBox_Chon_Timkiem.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Mã nhà cung cấp"});
            this.comboBox_Chon_Timkiem.Location = new System.Drawing.Point(393, 364);
            this.comboBox_Chon_Timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Chon_Timkiem.Name = "comboBox_Chon_Timkiem";
            this.comboBox_Chon_Timkiem.Size = new System.Drawing.Size(153, 24);
            this.comboBox_Chon_Timkiem.TabIndex = 20;
            this.comboBox_Chon_Timkiem.Text = "Mã nhân viên";
            this.comboBox_Chon_Timkiem.SelectedIndexChanged += new System.EventHandler(this.comboBox_Chon_Timkiem_SelectedIndexChanged);
            // 
            // textBox_timkiem_sl_banghi
            // 
            this.textBox_timkiem_sl_banghi.Location = new System.Drawing.Point(335, 212);
            this.textBox_timkiem_sl_banghi.Name = "textBox_timkiem_sl_banghi";
            this.textBox_timkiem_sl_banghi.Size = new System.Drawing.Size(244, 22);
            this.textBox_timkiem_sl_banghi.TabIndex = 19;
            this.textBox_timkiem_sl_banghi.TextChanged += new System.EventHandler(this.textBox_timkiem_sl_banghi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tìm kiếm dựa số lượng bản ghi  dựa vào mã ncc";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button_tim_sl
            // 
            this.button_tim_sl.Location = new System.Drawing.Point(612, 210);
            this.button_tim_sl.Name = "button_tim_sl";
            this.button_tim_sl.Size = new System.Drawing.Size(75, 23);
            this.button_tim_sl.TabIndex = 20;
            this.button_tim_sl.Text = "Tìm kiếm";
            this.button_tim_sl.UseVisualStyleBackColor = true;
            this.button_tim_sl.Click += new System.EventHandler(this.button_tim_sl_Click);
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Items.AddRange(new object[] {
            "Mã NCC",
            "Tên NCC",
            "Địa Chỉ",
            "SDT",
            "Email"});
            this.cbo.Location = new System.Drawing.Point(605, 364);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(121, 24);
            this.cbo.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HDNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.comboBox_Chon_Timkiem);
            this.Controls.Add(this.button_InHD_HDNhap);
            this.Controls.Add(this.dataGridView_HoaDonPN);
            this.Controls.Add(this.groupBox_HDNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_TimKiem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HDNhapHang";
            this.Text = "Thông tin hóa đơn";
            this.Load += new System.EventHandler(this.HDNhapHang_Load);
            this.groupBox_HDNhap.ResumeLayout(false);
            this.groupBox_HDNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDonPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_HDNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayNhap;
        private System.Windows.Forms.TextBox textBox_MaHDNhap;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Xua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.DataGridView dataGridView_HoaDonPN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.ComboBox comboBox_NhaCC;
        private System.Windows.Forms.ComboBox comboBox_MaNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_InHD_HDNhap;
        private System.Windows.Forms.ComboBox comboBox_Chon_Timkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox_timkiem_sl_banghi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_tim_sl;
        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.Button button1;
    }
}