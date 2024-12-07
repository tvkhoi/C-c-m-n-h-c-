namespace btlLTHSK
{
    partial class SanPham
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Luu = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_GiaBan = new System.Windows.Forms.TextBox();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.textBox_MaSanPham = new System.Windows.Forms.TextBox();
            this.textBox_TenSanPham = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_ten_NCC = new System.Windows.Forms.ComboBox();
            this.comboBox_ten_loai = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(442, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sản Phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Sản Phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Hãng Sản Xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giá Bán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nhà Cung Cấp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_ten_loai);
            this.groupBox1.Controls.Add(this.comboBox_ten_NCC);
            this.groupBox1.Controls.Add(this.button_Huy);
            this.groupBox1.Controls.Add(this.button_Xoa);
            this.groupBox1.Controls.Add(this.button_Luu);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.textBox_GiaBan);
            this.groupBox1.Controls.Add(this.textBox_SoLuong);
            this.groupBox1.Controls.Add(this.textBox_MaSanPham);
            this.groupBox1.Controls.Add(this.textBox_TenSanPham);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1019, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(817, 163);
            this.button_Huy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(79, 31);
            this.button_Huy.TabIndex = 3;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(647, 163);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(79, 31);
            this.button_Xoa.TabIndex = 3;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Luu
            // 
            this.button_Luu.Location = new System.Drawing.Point(258, 163);
            this.button_Luu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(79, 31);
            this.button_Luu.TabIndex = 3;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.UseVisualStyleBackColor = true;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(97, 163);
            this.button_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(79, 31);
            this.button_Them.TabIndex = 3;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // textBox_GiaBan
            // 
            this.textBox_GiaBan.Location = new System.Drawing.Point(675, 104);
            this.textBox_GiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_GiaBan.Name = "textBox_GiaBan";
            this.textBox_GiaBan.Size = new System.Drawing.Size(272, 22);
            this.textBox_GiaBan.TabIndex = 2;
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Location = new System.Drawing.Point(675, 68);
            this.textBox_SoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(272, 22);
            this.textBox_SoLuong.TabIndex = 2;
            // 
            // textBox_MaSanPham
            // 
            this.textBox_MaSanPham.Location = new System.Drawing.Point(180, 34);
            this.textBox_MaSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_MaSanPham.Name = "textBox_MaSanPham";
            this.textBox_MaSanPham.Size = new System.Drawing.Size(272, 22);
            this.textBox_MaSanPham.TabIndex = 2;
            // 
            // textBox_TenSanPham
            // 
            this.textBox_TenSanPham.Location = new System.Drawing.Point(180, 68);
            this.textBox_TenSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_TenSanPham.Name = "textBox_TenSanPham";
            this.textBox_TenSanPham.Size = new System.Drawing.Size(272, 22);
            this.textBox_TenSanPham.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaSanPham,
            this.Column_TenSP,
            this.Column_Loai,
            this.Column_MaNCC,
            this.Column_Soluong,
            this.Column_GiaBan});
            this.dataGridView1.Location = new System.Drawing.Point(29, 372);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(959, 161);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column_MaSanPham
            // 
            this.Column_MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.Column_MaSanPham.MinimumWidth = 10;
            this.Column_MaSanPham.Name = "Column_MaSanPham";
            this.Column_MaSanPham.Width = 150;
            // 
            // Column_TenSP
            // 
            this.Column_TenSP.HeaderText = "Tên Sản Phẩm";
            this.Column_TenSP.MinimumWidth = 10;
            this.Column_TenSP.Name = "Column_TenSP";
            this.Column_TenSP.Width = 150;
            // 
            // Column_Loai
            // 
            this.Column_Loai.HeaderText = "Hãng SX";
            this.Column_Loai.MinimumWidth = 10;
            this.Column_Loai.Name = "Column_Loai";
            this.Column_Loai.Width = 125;
            // 
            // Column_MaNCC
            // 
            this.Column_MaNCC.HeaderText = "Nhà CC";
            this.Column_MaNCC.MinimumWidth = 10;
            this.Column_MaNCC.Name = "Column_MaNCC";
            this.Column_MaNCC.Width = 125;
            // 
            // Column_Soluong
            // 
            this.Column_Soluong.HeaderText = "Số Lượng";
            this.Column_Soluong.MinimumWidth = 10;
            this.Column_Soluong.Name = "Column_Soluong";
            this.Column_Soluong.Width = 80;
            // 
            // Column_GiaBan
            // 
            this.Column_GiaBan.HeaderText = "Giá";
            this.Column_GiaBan.MinimumWidth = 10;
            this.Column_GiaBan.Name = "Column_GiaBan";
            this.Column_GiaBan.Width = 80;
            // 
            // comboBox_ten_NCC
            // 
            this.comboBox_ten_NCC.FormattingEnabled = true;
            this.comboBox_ten_NCC.Location = new System.Drawing.Point(675, 32);
            this.comboBox_ten_NCC.Name = "comboBox_ten_NCC";
            this.comboBox_ten_NCC.Size = new System.Drawing.Size(221, 24);
            this.comboBox_ten_NCC.TabIndex = 4;
            // 
            // comboBox_ten_loai
            // 
            this.comboBox_ten_loai.FormattingEnabled = true;
            this.comboBox_ten_loai.Location = new System.Drawing.Point(180, 104);
            this.comboBox_ten_loai.Name = "comboBox_ten_loai";
            this.comboBox_ten_loai.Size = new System.Drawing.Size(272, 24);
            this.comboBox_ten_loai.TabIndex = 5;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_GiaBan;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.TextBox textBox_MaSanPham;
        private System.Windows.Forms.TextBox textBox_TenSanPham;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GiaBan;
        private System.Windows.Forms.ComboBox comboBox_ten_loai;
        private System.Windows.Forms.ComboBox comboBox_ten_NCC;
    }
}