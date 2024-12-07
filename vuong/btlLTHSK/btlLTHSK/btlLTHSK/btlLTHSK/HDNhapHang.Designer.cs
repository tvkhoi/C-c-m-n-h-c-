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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_NhaCC = new System.Windows.Forms.ComboBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.groupBox_HDNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDonPN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(573, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Nhập Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // groupBox_HDNhap
            // 
            this.groupBox_HDNhap.Controls.Add(this.pictureBox1);
            this.groupBox_HDNhap.Controls.Add(this.comboBox_NhaCC);
            this.groupBox_HDNhap.Controls.Add(this.comboBox_MaNV);
            this.groupBox_HDNhap.Controls.Add(this.button_Huy);
            this.groupBox_HDNhap.Controls.Add(this.button_Xoa);
            this.groupBox_HDNhap.Controls.Add(this.button_Xua);
            this.groupBox_HDNhap.Controls.Add(this.button_Them);
            this.groupBox_HDNhap.Controls.Add(this.dateTimePicker_NgayNhap);
            this.groupBox_HDNhap.Controls.Add(this.textBox_MaHDNhap);
            this.groupBox_HDNhap.Controls.Add(this.label5);
            this.groupBox_HDNhap.Controls.Add(this.label4);
            this.groupBox_HDNhap.Controls.Add(this.label3);
            this.groupBox_HDNhap.Controls.Add(this.label2);
            this.groupBox_HDNhap.Location = new System.Drawing.Point(33, 112);
            this.groupBox_HDNhap.Name = "groupBox_HDNhap";
            this.groupBox_HDNhap.Size = new System.Drawing.Size(1334, 395);
            this.groupBox_HDNhap.TabIndex = 2;
            this.groupBox_HDNhap.TabStop = false;
            this.groupBox_HDNhap.Text = "Hóa Đơn Lấy Hàng";
            this.groupBox_HDNhap.Enter += new System.EventHandler(this.groupBox_HDNhap_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::btlLTHSK.Properties.Resources.tải_xuống1;
            this.pictureBox1.Location = new System.Drawing.Point(1147, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 81);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox_NhaCC
            // 
            this.comboBox_NhaCC.FormattingEnabled = true;
            this.comboBox_NhaCC.Location = new System.Drawing.Point(874, 50);
            this.comboBox_NhaCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_NhaCC.Name = "comboBox_NhaCC";
            this.comboBox_NhaCC.Size = new System.Drawing.Size(308, 33);
            this.comboBox_NhaCC.TabIndex = 6;
            this.comboBox_NhaCC.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_NhaCC_Validating);
            // 
            // comboBox_MaNV
            // 
            this.comboBox_MaNV.FormattingEnabled = true;
            this.comboBox_MaNV.Location = new System.Drawing.Point(244, 117);
            this.comboBox_MaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_MaNV.Name = "comboBox_MaNV";
            this.comboBox_MaNV.Size = new System.Drawing.Size(308, 33);
            this.comboBox_MaNV.TabIndex = 5;
            this.comboBox_MaNV.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaNV_SelectedIndexChanged);
            this.comboBox_MaNV.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_MaNV_Validating);
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(956, 258);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(126, 45);
            this.button_Huy.TabIndex = 4;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(710, 258);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(126, 45);
            this.button_Xoa.TabIndex = 4;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Xua
            // 
            this.button_Xua.Location = new System.Drawing.Point(320, 258);
            this.button_Xua.Name = "button_Xua";
            this.button_Xua.Size = new System.Drawing.Size(126, 45);
            this.button_Xua.TabIndex = 4;
            this.button_Xua.Text = "Sửa";
            this.button_Xua.UseVisualStyleBackColor = true;
            this.button_Xua.Click += new System.EventHandler(this.button_Xua_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(130, 258);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(126, 45);
            this.button_Them.TabIndex = 4;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // dateTimePicker_NgayNhap
            // 
            this.dateTimePicker_NgayNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePicker_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayNhap.Location = new System.Drawing.Point(874, 112);
            this.dateTimePicker_NgayNhap.Name = "dateTimePicker_NgayNhap";
            this.dateTimePicker_NgayNhap.Size = new System.Drawing.Size(308, 31);
            this.dateTimePicker_NgayNhap.TabIndex = 3;
            this.dateTimePicker_NgayNhap.ValueChanged += new System.EventHandler(this.dateTimePicker_NgayNhap_ValueChanged);
            // 
            // textBox_MaHDNhap
            // 
            this.textBox_MaHDNhap.Location = new System.Drawing.Point(244, 52);
            this.textBox_MaHDNhap.Name = "textBox_MaHDNhap";
            this.textBox_MaHDNhap.Size = new System.Drawing.Size(308, 31);
            this.textBox_MaHDNhap.TabIndex = 2;
            this.textBox_MaHDNhap.TextChanged += new System.EventHandler(this.textBox_MaHDNhap_TextChanged);
            this.textBox_MaHDNhap.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaHDNhap_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(662, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Nhà Cung Cấp:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // dataGridView_HoaDonPN
            // 
            this.dataGridView_HoaDonPN.AllowUserToOrderColumns = true;
            this.dataGridView_HoaDonPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaDonPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaHD,
            this.Column_MaNV,
            this.Column_MaNCC,
            this.Column_NgayNhap,
            this.Column1});
            this.dataGridView_HoaDonPN.Location = new System.Drawing.Point(33, 617);
            this.dataGridView_HoaDonPN.Name = "dataGridView_HoaDonPN";
            this.dataGridView_HoaDonPN.RowHeadersWidth = 82;
            this.dataGridView_HoaDonPN.RowTemplate.Height = 33;
            this.dataGridView_HoaDonPN.Size = new System.Drawing.Size(1334, 345);
            this.dataGridView_HoaDonPN.TabIndex = 3;
            this.dataGridView_HoaDonPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HoaDonPN_CellClick);
            this.dataGridView_HoaDonPN.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HoaDonPN_RowEnter);
            // 
            // Column_MaHD
            // 
            this.Column_MaHD.HeaderText = "Mã HD Nhập";
            this.Column_MaHD.MinimumWidth = 10;
            this.Column_MaHD.Name = "Column_MaHD";
            this.Column_MaHD.Width = 125;
            // 
            // Column_MaNV
            // 
            this.Column_MaNV.HeaderText = "Mã NV";
            this.Column_MaNV.MinimumWidth = 10;
            this.Column_MaNV.Name = "Column_MaNV";
            this.Column_MaNV.Width = 125;
            // 
            // Column_MaNCC
            // 
            this.Column_MaNCC.HeaderText = "Người Bán";
            this.Column_MaNCC.MinimumWidth = 10;
            this.Column_MaNCC.Name = "Column_MaNCC";
            this.Column_MaNCC.Width = 125;
            // 
            // Column_NgayNhap
            // 
            this.Column_NgayNhap.HeaderText = "Ngày Nhập";
            this.Column_NgayNhap.MinimumWidth = 10;
            this.Column_NgayNhap.Name = "Column_NgayNhap";
            this.Column_NgayNhap.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm Kiếm:";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 572);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Image = global::btlLTHSK.Properties.Resources.tải_xuống__1_1;
            this.button_timkiem.Location = new System.Drawing.Point(554, 572);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(44, 39);
            this.button_timkiem.TabIndex = 17;
            this.button_timkiem.UseVisualStyleBackColor = true;
            // 
            // HDNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 981);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.dataGridView_HoaDonPN);
            this.Controls.Add(this.groupBox_HDNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NgayNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.ComboBox comboBox_NhaCC;
        private System.Windows.Forms.ComboBox comboBox_MaNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}