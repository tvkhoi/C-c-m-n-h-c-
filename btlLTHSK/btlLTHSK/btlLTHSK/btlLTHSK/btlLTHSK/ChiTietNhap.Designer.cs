namespace btlLTHSK
{
    partial class ChiTietNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_XuatHD = new System.Windows.Forms.Button();
            this.comboBox_maSP = new System.Windows.Forms.ComboBox();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_tenSP = new System.Windows.Forms.TextBox();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.textBox_MaHDNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_HDNhap = new System.Windows.Forms.DataGridView();
            this.Column_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.comboBox_TimKiem = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_XuatHD);
            this.groupBox1.Controls.Add(this.comboBox_maSP);
            this.groupBox1.Controls.Add(this.button_Xoa);
            this.groupBox1.Controls.Add(this.button_Huy);
            this.groupBox1.Controls.Add(this.button_Sua);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.textBox_tenSP);
            this.groupBox1.Controls.Add(this.textBox_Gia);
            this.groupBox1.Controls.Add(this.textBox_SoLuong);
            this.groupBox1.Controls.Add(this.textBox_MaHDNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1386, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_XuatHD
            // 
            this.button_XuatHD.Location = new System.Drawing.Point(607, 239);
            this.button_XuatHD.Name = "button_XuatHD";
            this.button_XuatHD.Size = new System.Drawing.Size(154, 49);
            this.button_XuatHD.TabIndex = 5;
            this.button_XuatHD.Text = "In Hóa Đơn";
            this.button_XuatHD.UseVisualStyleBackColor = true;
            this.button_XuatHD.Click += new System.EventHandler(this.button_XuatHD_Click);
            // 
            // comboBox_maSP
            // 
            this.comboBox_maSP.FormattingEnabled = true;
            this.comboBox_maSP.Location = new System.Drawing.Point(225, 87);
            this.comboBox_maSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_maSP.Name = "comboBox_maSP";
            this.comboBox_maSP.Size = new System.Drawing.Size(356, 33);
            this.comboBox_maSP.TabIndex = 4;
            this.comboBox_maSP.SelectedIndexChanged += new System.EventHandler(this.comboBox_maSP_SelectedIndexChanged);
            this.comboBox_maSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_maSP_KeyPress);
            this.comboBox_maSP.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_maSP_Validating);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(916, 239);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(136, 50);
            this.button_Xoa.TabIndex = 3;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(1149, 239);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(136, 50);
            this.button_Huy.TabIndex = 3;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(336, 238);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(136, 50);
            this.button_Sua.TabIndex = 3;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(93, 239);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(136, 50);
            this.button_Them.TabIndex = 3;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_tenSP
            // 
            this.textBox_tenSP.Location = new System.Drawing.Point(225, 142);
            this.textBox_tenSP.Name = "textBox_tenSP";
            this.textBox_tenSP.Size = new System.Drawing.Size(356, 31);
            this.textBox_tenSP.TabIndex = 2;
            this.textBox_tenSP.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_tenSP_Validating);
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.Location = new System.Drawing.Point(879, 89);
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.Size = new System.Drawing.Size(356, 31);
            this.textBox_Gia.TabIndex = 2;
            this.textBox_Gia.TextChanged += new System.EventHandler(this.textBox_Gia_TextChanged);
            this.textBox_Gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Gia_KeyPress);
            this.textBox_Gia.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Gia_Validating);
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Location = new System.Drawing.Point(879, 31);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(356, 31);
            this.textBox_SoLuong.TabIndex = 2;
            this.textBox_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SoLuong_KeyPress);
            this.textBox_SoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_SoLuong_Validating);
            // 
            // textBox_MaHDNhap
            // 
            this.textBox_MaHDNhap.Location = new System.Drawing.Point(225, 30);
            this.textBox_MaHDNhap.Name = "textBox_MaHDNhap";
            this.textBox_MaHDNhap.Size = new System.Drawing.Size(356, 31);
            this.textBox_MaHDNhap.TabIndex = 2;
            this.textBox_MaHDNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MaHDNhap_KeyPress);
            this.textBox_MaHDNhap.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MHDNhap_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá nhập:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HD Nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(610, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Tiết Nhập Hàng";
            // 
            // dataGridView_HDNhap
            // 
            this.dataGridView_HDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HDNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaHD,
            this.Column_MaPhieu,
            this.Column_TenSP,
            this.Column_SoLuong,
            this.Column_Gia});
            this.dataGridView_HDNhap.Location = new System.Drawing.Point(104, 620);
            this.dataGridView_HDNhap.Name = "dataGridView_HDNhap";
            this.dataGridView_HDNhap.RowHeadersWidth = 82;
            this.dataGridView_HDNhap.RowTemplate.Height = 33;
            this.dataGridView_HDNhap.Size = new System.Drawing.Size(1293, 356);
            this.dataGridView_HDNhap.TabIndex = 2;
            this.dataGridView_HDNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HDNhap_CellClick);
            this.dataGridView_HDNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView_HDNhap.Click += new System.EventHandler(this.dataGridView_HDNhap_Click);
            // 
            // Column_MaHD
            // 
            this.Column_MaHD.HeaderText = "Mã HD Nhập";
            this.Column_MaHD.MinimumWidth = 10;
            this.Column_MaHD.Name = "Column_MaHD";
            this.Column_MaHD.Width = 125;
            // 
            // Column_MaPhieu
            // 
            this.Column_MaPhieu.HeaderText = "Mã Sản phẩm";
            this.Column_MaPhieu.MinimumWidth = 10;
            this.Column_MaPhieu.Name = "Column_MaPhieu";
            this.Column_MaPhieu.Width = 125;
            // 
            // Column_TenSP
            // 
            this.Column_TenSP.HeaderText = "Ten SP";
            this.Column_TenSP.MinimumWidth = 10;
            this.Column_TenSP.Name = "Column_TenSP";
            this.Column_TenSP.Width = 200;
            // 
            // Column_SoLuong
            // 
            this.Column_SoLuong.HeaderText = "Số Lượng";
            this.Column_SoLuong.MinimumWidth = 10;
            this.Column_SoLuong.Name = "Column_SoLuong";
            this.Column_SoLuong.Width = 125;
            // 
            // Column_Gia
            // 
            this.Column_Gia.HeaderText = "Đơn Giá";
            this.Column_Gia.MinimumWidth = 10;
            this.Column_Gia.Name = "Column_Gia";
            this.Column_Gia.Width = 125;
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(314, 562);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(356, 31);
            this.textBox_TimKiem.TabIndex = 2;
            // 
            // comboBox_TimKiem
            // 
            this.comboBox_TimKiem.FormattingEnabled = true;
            this.comboBox_TimKiem.Items.AddRange(new object[] {
            "Mã HD Nhập",
            "Mã Phiếu",
            "Tên Sản Phẩm"});
            this.comboBox_TimKiem.Location = new System.Drawing.Point(104, 564);
            this.comboBox_TimKiem.Name = "comboBox_TimKiem";
            this.comboBox_TimKiem.Size = new System.Drawing.Size(192, 33);
            this.comboBox_TimKiem.TabIndex = 4;
            this.comboBox_TimKiem.Text = "Mã HD Nhập";
            // 
            // ChiTietNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 977);
            this.Controls.Add(this.comboBox_TimKiem);
            this.Controls.Add(this.dataGridView_HDNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_TimKiem);
            this.Name = "ChiTietNhap";
            this.Text = "ChiTietNhap";
            this.Load += new System.EventHandler(this.ChiTietNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tenSP;
        private System.Windows.Forms.TextBox textBox_MaHDNhap;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_Gia;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.DataGridView dataGridView_HDNhap;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.ComboBox comboBox_TimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gia;
        private System.Windows.Forms.Button button_XuatHD;
    }
}