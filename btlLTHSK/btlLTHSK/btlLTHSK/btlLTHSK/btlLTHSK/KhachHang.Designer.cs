namespace btlLTHSK
{
    partial class QLKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Khach_Hang = new System.Windows.Forms.DataGridView();
            this.Column_Ten_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Ma_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label_DanhMuc_KhachHang = new System.Windows.Forms.Label();
            this.textBox_Ma_KhachHang = new System.Windows.Forms.TextBox();
            this.label_Ten_KhachHang = new System.Windows.Forms.Label();
            this.textBox_Ten_KhachHang = new System.Windows.Forms.TextBox();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_DienThoai = new System.Windows.Forms.Label();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Luu = new System.Windows.Forms.Button();
            this.button_Xóa = new System.Windows.Forms.Button();
            this.button_Huy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.comboBox_TimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Khach_Hang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Khach_Hang
            // 
            this.dataGridView_Khach_Hang.AllowUserToAddRows = false;
            this.dataGridView_Khach_Hang.AllowUserToDeleteRows = false;
            this.dataGridView_Khach_Hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Khach_Hang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Ten_KhachHang,
            this.Column_Ma_KhachHang,
            this.Column_DienThoai,
            this.Column_DiaChi});
            this.dataGridView_Khach_Hang.Location = new System.Drawing.Point(140, 481);
            this.dataGridView_Khach_Hang.Name = "dataGridView_Khach_Hang";
            this.dataGridView_Khach_Hang.ReadOnly = true;
            this.dataGridView_Khach_Hang.RowHeadersWidth = 82;
            this.dataGridView_Khach_Hang.RowTemplate.Height = 33;
            this.dataGridView_Khach_Hang.Size = new System.Drawing.Size(1042, 308);
            this.dataGridView_Khach_Hang.TabIndex = 0;
            this.dataGridView_Khach_Hang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Khach_Hang_CellClick);
            this.dataGridView_Khach_Hang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Khach_Hang_CellContentClick);
            // 
            // Column_Ten_KhachHang
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Column_Ten_KhachHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_Ten_KhachHang.HeaderText = "Tên Khách Hàng";
            this.Column_Ten_KhachHang.MinimumWidth = 10;
            this.Column_Ten_KhachHang.Name = "Column_Ten_KhachHang";
            this.Column_Ten_KhachHang.ReadOnly = true;
            this.Column_Ten_KhachHang.Width = 120;
            // 
            // Column_Ma_KhachHang
            // 
            this.Column_Ma_KhachHang.HeaderText = "Mã Khách Hàng";
            this.Column_Ma_KhachHang.MinimumWidth = 10;
            this.Column_Ma_KhachHang.Name = "Column_Ma_KhachHang";
            this.Column_Ma_KhachHang.ReadOnly = true;
            this.Column_Ma_KhachHang.Width = 120;
            // 
            // Column_DienThoai
            // 
            this.Column_DienThoai.HeaderText = "Điện Thoại";
            this.Column_DienThoai.MinimumWidth = 10;
            this.Column_DienThoai.Name = "Column_DienThoai";
            this.Column_DienThoai.ReadOnly = true;
            this.Column_DienThoai.Width = 125;
            // 
            // Column_DiaChi
            // 
            this.Column_DiaChi.HeaderText = "Địa Chỉ";
            this.Column_DiaChi.MinimumWidth = 10;
            this.Column_DiaChi.Name = "Column_DiaChi";
            this.Column_DiaChi.ReadOnly = true;
            this.Column_DiaChi.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // label_DanhMuc_KhachHang
            // 
            this.label_DanhMuc_KhachHang.AutoSize = true;
            this.label_DanhMuc_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DanhMuc_KhachHang.Location = new System.Drawing.Point(567, 9);
            this.label_DanhMuc_KhachHang.Name = "label_DanhMuc_KhachHang";
            this.label_DanhMuc_KhachHang.Size = new System.Drawing.Size(293, 31);
            this.label_DanhMuc_KhachHang.TabIndex = 4;
            this.label_DanhMuc_KhachHang.Text = "Danh Mục Khách Hàng";
            // 
            // textBox_Ma_KhachHang
            // 
            this.textBox_Ma_KhachHang.Location = new System.Drawing.Point(190, 131);
            this.textBox_Ma_KhachHang.Name = "textBox_Ma_KhachHang";
            this.textBox_Ma_KhachHang.Size = new System.Drawing.Size(373, 31);
            this.textBox_Ma_KhachHang.TabIndex = 5;
            this.textBox_Ma_KhachHang.TextChanged += new System.EventHandler(this.textBox_Ma_KhachHang_TextChanged);
            this.textBox_Ma_KhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ma_KhachHang_KeyPress);
            this.textBox_Ma_KhachHang.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Ma_KhachHang_Validating);
            // 
            // label_Ten_KhachHang
            // 
            this.label_Ten_KhachHang.AutoSize = true;
            this.label_Ten_KhachHang.Location = new System.Drawing.Point(12, 197);
            this.label_Ten_KhachHang.Name = "label_Ten_KhachHang";
            this.label_Ten_KhachHang.Size = new System.Drawing.Size(179, 25);
            this.label_Ten_KhachHang.TabIndex = 6;
            this.label_Ten_KhachHang.Text = "Tên Khách Hàng:";
            // 
            // textBox_Ten_KhachHang
            // 
            this.textBox_Ten_KhachHang.Location = new System.Drawing.Point(190, 191);
            this.textBox_Ten_KhachHang.Name = "textBox_Ten_KhachHang";
            this.textBox_Ten_KhachHang.Size = new System.Drawing.Size(373, 31);
            this.textBox_Ten_KhachHang.TabIndex = 7;
            this.textBox_Ten_KhachHang.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Ten_KhachHang_Validating);
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(190, 248);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(373, 31);
            this.textBox_DiaChi.TabIndex = 7;
            this.textBox_DiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_DiaChi_Validating);
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Location = new System.Drawing.Point(12, 255);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(88, 25);
            this.label_DiaChi.TabIndex = 6;
            this.label_DiaChi.Text = "Địa Chỉ:";
            // 
            // label_DienThoai
            // 
            this.label_DienThoai.AutoSize = true;
            this.label_DienThoai.Location = new System.Drawing.Point(12, 306);
            this.label_DienThoai.Name = "label_DienThoai";
            this.label_DienThoai.Size = new System.Drawing.Size(122, 25);
            this.label_DienThoai.TabIndex = 6;
            this.label_DienThoai.Text = "Điện Thoại:";
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Location = new System.Drawing.Point(190, 302);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(373, 31);
            this.textBox_sdt.TabIndex = 7;
            this.textBox_sdt.TextChanged += new System.EventHandler(this.textBox_sdt_TextChanged);
            this.textBox_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sdt_KeyPress);
            this.textBox_sdt.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_sdt_Validating);
            // 
            // button_Them
            // 
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Them.Location = new System.Drawing.Point(687, 128);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(110, 42);
            this.button_Them.TabIndex = 9;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Luu
            // 
            this.button_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Luu.Location = new System.Drawing.Point(687, 197);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(110, 42);
            this.button_Luu.TabIndex = 10;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.UseVisualStyleBackColor = true;
            this.button_Luu.Click += new System.EventHandler(this.button_Luu_Click);
            // 
            // button_Xóa
            // 
            this.button_Xóa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Xóa.Location = new System.Drawing.Point(687, 275);
            this.button_Xóa.Name = "button_Xóa";
            this.button_Xóa.Size = new System.Drawing.Size(110, 42);
            this.button_Xóa.TabIndex = 11;
            this.button_Xóa.Text = "Xóa";
            this.button_Xóa.UseVisualStyleBackColor = true;
            this.button_Xóa.Click += new System.EventHandler(this.button_Xóa_Click);
            // 
            // button_Huy
            // 
            this.button_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Huy.Location = new System.Drawing.Point(882, 189);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(158, 59);
            this.button_Huy.TabIndex = 12;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(342, 414);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(438, 31);
            this.textBox_TimKiem.TabIndex = 14;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // comboBox_TimKiem
            // 
            this.comboBox_TimKiem.FormattingEnabled = true;
            this.comboBox_TimKiem.Items.AddRange(new object[] {
            "Tên Khách Hàng",
            "Điện Thoại"});
            this.comboBox_TimKiem.Location = new System.Drawing.Point(882, 412);
            this.comboBox_TimKiem.Name = "comboBox_TimKiem";
            this.comboBox_TimKiem.Size = new System.Drawing.Size(310, 33);
            this.comboBox_TimKiem.TabIndex = 15;
            this.comboBox_TimKiem.Text = "Tên Khách Hàng";
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1821, 997);
            this.Controls.Add(this.comboBox_TimKiem);
            this.Controls.Add(this.textBox_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_Xóa);
            this.Controls.Add(this.button_Luu);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.textBox_sdt);
            this.Controls.Add(this.textBox_DiaChi);
            this.Controls.Add(this.textBox_Ten_KhachHang);
            this.Controls.Add(this.label_DienThoai);
            this.Controls.Add(this.label_DiaChi);
            this.Controls.Add(this.label_Ten_KhachHang);
            this.Controls.Add(this.textBox_Ma_KhachHang);
            this.Controls.Add(this.label_DanhMuc_KhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Khach_Hang);
            this.Name = "QLKhachHang";
            this.Text = "QLKhachHang";
            this.Load += new System.EventHandler(this.QLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Khach_Hang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Khach_Hang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_DanhMuc_KhachHang;
        private System.Windows.Forms.TextBox textBox_Ma_KhachHang;
        private System.Windows.Forms.Label label_Ten_KhachHang;
        private System.Windows.Forms.TextBox textBox_Ten_KhachHang;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_DienThoai;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.Button button_Xóa;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.ComboBox comboBox_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ten_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ma_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DiaChi;
    }
}