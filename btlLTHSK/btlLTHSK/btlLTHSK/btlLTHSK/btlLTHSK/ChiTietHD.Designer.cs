namespace btlLTHSK
{
    partial class ChiTietHD
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
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.textBox_GiaBan = new System.Windows.Forms.TextBox();
            this.textBox_GiamGia = new System.Windows.Forms.TextBox();
            this.dgv_CTHD = new System.Windows.Forms.DataGridView();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ThanhTien = new System.Windows.Forms.TextBox();
            this.cb_MaSP = new System.Windows.Forms.ComboBox();
            this.comboBox_MaHD = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Column_MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(834, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá Bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thành Tiền:";
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Location = new System.Drawing.Point(280, 261);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(298, 31);
            this.textBox_SoLuong.TabIndex = 1;
            this.textBox_SoLuong.TextChanged += new System.EventHandler(this.textBox_SoLuong_TextChanged);
            this.textBox_SoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_SoLuong_Validating);
            // 
            // textBox_GiaBan
            // 
            this.textBox_GiaBan.Location = new System.Drawing.Point(998, 112);
            this.textBox_GiaBan.Name = "textBox_GiaBan";
            this.textBox_GiaBan.Size = new System.Drawing.Size(298, 31);
            this.textBox_GiaBan.TabIndex = 1;
            this.textBox_GiaBan.TextChanged += new System.EventHandler(this.textBox_GiaBan_TextChanged);
            this.textBox_GiaBan.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_GiaBan_Validating);
            // 
            // textBox_GiamGia
            // 
            this.textBox_GiamGia.Location = new System.Drawing.Point(998, 191);
            this.textBox_GiamGia.Name = "textBox_GiamGia";
            this.textBox_GiamGia.Size = new System.Drawing.Size(298, 31);
            this.textBox_GiamGia.TabIndex = 1;
            this.textBox_GiamGia.TextChanged += new System.EventHandler(this.textBox_GiamGia_TextChanged);
            this.textBox_GiamGia.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_GiamGia_Validating);
            // 
            // dgv_CTHD
            // 
            this.dgv_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaHoaDon,
            this.Column_MaSP,
            this.Column_DonGia,
            this.Column_SoLuong,
            this.Column_GiamGia,
            this.Column_ThanhTien});
            this.dgv_CTHD.Location = new System.Drawing.Point(162, 469);
            this.dgv_CTHD.Name = "dgv_CTHD";
            this.dgv_CTHD.RowHeadersWidth = 82;
            this.dgv_CTHD.RowTemplate.Height = 33;
            this.dgv_CTHD.Size = new System.Drawing.Size(1256, 361);
            this.dgv_CTHD.TabIndex = 2;
            this.dgv_CTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTHD_CellClick);
            this.dgv_CTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTHD_CellContentClick);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(202, 352);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(118, 39);
            this.button_Them.TabIndex = 3;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xua
            // 
            this.button_Xua.Location = new System.Drawing.Point(408, 352);
            this.button_Xua.Name = "button_Xua";
            this.button_Xua.Size = new System.Drawing.Size(118, 39);
            this.button_Xua.TabIndex = 3;
            this.button_Xua.Text = "Sửa";
            this.button_Xua.UseVisualStyleBackColor = true;
            this.button_Xua.Click += new System.EventHandler(this.button_Xua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(624, 352);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(118, 39);
            this.button_Xoa.TabIndex = 3;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(630, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chi Tiết Hóa Đơn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(834, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giảm Giá:";
            // 
            // textBox_ThanhTien
            // 
            this.textBox_ThanhTien.Location = new System.Drawing.Point(998, 267);
            this.textBox_ThanhTien.Name = "textBox_ThanhTien";
            this.textBox_ThanhTien.Size = new System.Drawing.Size(298, 31);
            this.textBox_ThanhTien.TabIndex = 1;
            this.textBox_ThanhTien.TextChanged += new System.EventHandler(this.textBox_ThanhTien_TextChanged);
            this.textBox_ThanhTien.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ThanhTien_Validating);
            // 
            // cb_MaSP
            // 
            this.cb_MaSP.FormattingEnabled = true;
            this.cb_MaSP.Location = new System.Drawing.Point(280, 189);
            this.cb_MaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_MaSP.Name = "cb_MaSP";
            this.cb_MaSP.Size = new System.Drawing.Size(298, 33);
            this.cb_MaSP.TabIndex = 6;
            this.cb_MaSP.SelectedIndexChanged += new System.EventHandler(this.cb_MaSP_SelectedIndexChanged);
            this.cb_MaSP.Validating += new System.ComponentModel.CancelEventHandler(this.cb_MaSP_Validating);
            // 
            // comboBox_MaHD
            // 
            this.comboBox_MaHD.FormattingEnabled = true;
            this.comboBox_MaHD.Location = new System.Drawing.Point(280, 119);
            this.comboBox_MaHD.Name = "comboBox_MaHD";
            this.comboBox_MaHD.Size = new System.Drawing.Size(298, 33);
            this.comboBox_MaHD.TabIndex = 7;
            this.comboBox_MaHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_MaHD_KeyPress);
            this.comboBox_MaHD.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_MaHD_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column_MaHoaDon
            // 
            this.Column_MaHoaDon.HeaderText = "Mã HD";
            this.Column_MaHoaDon.MinimumWidth = 10;
            this.Column_MaHoaDon.Name = "Column_MaHoaDon";
            this.Column_MaHoaDon.Width = 85;
            // 
            // Column_MaSP
            // 
            this.Column_MaSP.HeaderText = "Mã Sản Phẩm";
            this.Column_MaSP.MinimumWidth = 10;
            this.Column_MaSP.Name = "Column_MaSP";
            this.Column_MaSP.Width = 80;
            // 
            // Column_DonGia
            // 
            this.Column_DonGia.HeaderText = "Đơn Giá";
            this.Column_DonGia.MinimumWidth = 10;
            this.Column_DonGia.Name = "Column_DonGia";
            // 
            // Column_SoLuong
            // 
            this.Column_SoLuong.HeaderText = "Số lượng";
            this.Column_SoLuong.MinimumWidth = 10;
            this.Column_SoLuong.Name = "Column_SoLuong";
            this.Column_SoLuong.Width = 80;
            // 
            // Column_GiamGia
            // 
            this.Column_GiamGia.HeaderText = "Giảm Giá";
            this.Column_GiamGia.MinimumWidth = 10;
            this.Column_GiamGia.Name = "Column_GiamGia";
            this.Column_GiamGia.Width = 80;
            // 
            // Column_ThanhTien
            // 
            this.Column_ThanhTien.HeaderText = "Thành Tiền";
            this.Column_ThanhTien.MinimumWidth = 10;
            this.Column_ThanhTien.Name = "Column_ThanhTien";
            this.Column_ThanhTien.Width = 125;
            // 
            // ChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 892);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_MaHD);
            this.Controls.Add(this.cb_MaSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Xua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.dgv_CTHD);
            this.Controls.Add(this.textBox_SoLuong);
            this.Controls.Add(this.textBox_ThanhTien);
            this.Controls.Add(this.textBox_GiamGia);
            this.Controls.Add(this.textBox_GiaBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietHD";
            this.Text = "ChiTietHD";
            this.Load += new System.EventHandler(this.ChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.TextBox textBox_GiaBan;
        private System.Windows.Forms.TextBox textBox_GiamGia;
        private System.Windows.Forms.DataGridView dgv_CTHD;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ThanhTien;
        private System.Windows.Forms.ComboBox cb_MaSP;
        private System.Windows.Forms.ComboBox comboBox_MaHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ThanhTien;
    }
}