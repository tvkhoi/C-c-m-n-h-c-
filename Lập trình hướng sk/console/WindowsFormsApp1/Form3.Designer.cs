namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label_thongtinSV = new System.Windows.Forms.Label();
            this.label_maSV = new System.Windows.Forms.Label();
            this.label_hovaten = new System.Windows.Forms.Label();
            this.label_sdt = new System.Windows.Forms.Label();
            this.label_diachi = new System.Windows.Forms.Label();
            this.label_ngaysinh = new System.Windows.Forms.Label();
            this.label_gioitinh = new System.Windows.Forms.Label();
            this.textBox_maSV = new System.Windows.Forms.TextBox();
            this.textBox_hovaten = new System.Windows.Forms.TextBox();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.textBox_diachi = new System.Windows.Forms.TextBox();
            this.maskedTextBox_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.button_themmoi = new System.Windows.Forms.Button();
            this.button_boqua = new System.Windows.Forms.Button();
            this.button_chinhsua = new System.Windows.Forms.Button();
            this.button_xoabo = new System.Windows.Forms.Button();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_thongtinSV
            // 
            this.label_thongtinSV.AutoSize = true;
            this.label_thongtinSV.Location = new System.Drawing.Point(24, 32);
            this.label_thongtinSV.Name = "label_thongtinSV";
            this.label_thongtinSV.Size = new System.Drawing.Size(117, 16);
            this.label_thongtinSV.TabIndex = 0;
            this.label_thongtinSV.Text = "Thông tin sinh viên";
            // 
            // label_maSV
            // 
            this.label_maSV.AutoSize = true;
            this.label_maSV.Location = new System.Drawing.Point(40, 76);
            this.label_maSV.Name = "label_maSV";
            this.label_maSV.Size = new System.Drawing.Size(81, 16);
            this.label_maSV.TabIndex = 1;
            this.label_maSV.Text = "Mã sinh viên";
            // 
            // label_hovaten
            // 
            this.label_hovaten.AutoSize = true;
            this.label_hovaten.Location = new System.Drawing.Point(40, 114);
            this.label_hovaten.Name = "label_hovaten";
            this.label_hovaten.Size = new System.Drawing.Size(101, 16);
            this.label_hovaten.TabIndex = 1;
            this.label_hovaten.Text = "Họ tên sinh viên";
            // 
            // label_sdt
            // 
            this.label_sdt.AutoSize = true;
            this.label_sdt.Location = new System.Drawing.Point(40, 151);
            this.label_sdt.Name = "label_sdt";
            this.label_sdt.Size = new System.Drawing.Size(85, 16);
            this.label_sdt.TabIndex = 1;
            this.label_sdt.Text = "Số điện thoại";
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Location = new System.Drawing.Point(40, 187);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(47, 16);
            this.label_diachi.TabIndex = 1;
            this.label_diachi.Text = "Địa chỉ";
            this.label_diachi.Click += new System.EventHandler(this.label_diachi_Click);
            // 
            // label_ngaysinh
            // 
            this.label_ngaysinh.AutoSize = true;
            this.label_ngaysinh.Location = new System.Drawing.Point(40, 228);
            this.label_ngaysinh.Name = "label_ngaysinh";
            this.label_ngaysinh.Size = new System.Drawing.Size(67, 16);
            this.label_ngaysinh.TabIndex = 1;
            this.label_ngaysinh.Text = "Ngày sinh";
            this.label_ngaysinh.Click += new System.EventHandler(this.label_diachi_Click);
            // 
            // label_gioitinh
            // 
            this.label_gioitinh.AutoSize = true;
            this.label_gioitinh.Location = new System.Drawing.Point(40, 266);
            this.label_gioitinh.Name = "label_gioitinh";
            this.label_gioitinh.Size = new System.Drawing.Size(54, 16);
            this.label_gioitinh.TabIndex = 1;
            this.label_gioitinh.Text = "Giới tính";
            this.label_gioitinh.Click += new System.EventHandler(this.label_diachi_Click);
            // 
            // textBox_maSV
            // 
            this.textBox_maSV.Location = new System.Drawing.Point(218, 73);
            this.textBox_maSV.Name = "textBox_maSV";
            this.textBox_maSV.Size = new System.Drawing.Size(294, 22);
            this.textBox_maSV.TabIndex = 2;
            this.textBox_maSV.TextChanged += new System.EventHandler(this.textBox_maSV_TextChanged);
            this.textBox_maSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_maSV_KeyPress);
            this.textBox_maSV.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_maSV_Validating);
            // 
            // textBox_hovaten
            // 
            this.textBox_hovaten.Location = new System.Drawing.Point(218, 114);
            this.textBox_hovaten.Name = "textBox_hovaten";
            this.textBox_hovaten.Size = new System.Drawing.Size(294, 22);
            this.textBox_hovaten.TabIndex = 3;
            this.textBox_hovaten.TextChanged += new System.EventHandler(this.textBox_hovaten_TextChanged);
            this.textBox_hovaten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hovaten_KeyPress);
            this.textBox_hovaten.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_hovaten_Validating);
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Location = new System.Drawing.Point(218, 145);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(294, 22);
            this.textBox_sdt.TabIndex = 3;
            this.textBox_sdt.TextChanged += new System.EventHandler(this.textBox_sdt_TextChanged);
            this.textBox_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sdt_KeyPress);
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Location = new System.Drawing.Point(218, 187);
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(294, 22);
            this.textBox_diachi.TabIndex = 3;
            // 
            // maskedTextBox_ngaysinh
            // 
            this.maskedTextBox_ngaysinh.Location = new System.Drawing.Point(218, 221);
            this.maskedTextBox_ngaysinh.Mask = "00/00/0000";
            this.maskedTextBox_ngaysinh.Name = "maskedTextBox_ngaysinh";
            this.maskedTextBox_ngaysinh.Size = new System.Drawing.Size(294, 22);
            this.maskedTextBox_ngaysinh.TabIndex = 4;
            this.maskedTextBox_ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Location = new System.Drawing.Point(218, 306);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(57, 20);
            this.radioButton_Nam.TabIndex = 0;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Location = new System.Drawing.Point(371, 306);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(45, 20);
            this.radioButton_Nu.TabIndex = 1;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // button_themmoi
            // 
            this.button_themmoi.BackColor = System.Drawing.Color.Salmon;
            this.button_themmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_themmoi.Location = new System.Drawing.Point(575, 68);
            this.button_themmoi.Name = "button_themmoi";
            this.button_themmoi.Size = new System.Drawing.Size(85, 32);
            this.button_themmoi.TabIndex = 5;
            this.button_themmoi.Text = "Thêm mới";
            this.button_themmoi.UseVisualStyleBackColor = false;
            this.button_themmoi.Click += new System.EventHandler(this.button_themmoi_Click);
            this.button_themmoi.Validating += new System.ComponentModel.CancelEventHandler(this.button_them_validating);
            // 
            // button_boqua
            // 
            this.button_boqua.BackColor = System.Drawing.Color.Salmon;
            this.button_boqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_boqua.Location = new System.Drawing.Point(575, 114);
            this.button_boqua.Name = "button_boqua";
            this.button_boqua.Size = new System.Drawing.Size(85, 32);
            this.button_boqua.TabIndex = 5;
            this.button_boqua.Text = "Bỏ qua";
            this.button_boqua.UseVisualStyleBackColor = false;
            // 
            // button_chinhsua
            // 
            this.button_chinhsua.BackColor = System.Drawing.Color.Salmon;
            this.button_chinhsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chinhsua.Location = new System.Drawing.Point(575, 159);
            this.button_chinhsua.Name = "button_chinhsua";
            this.button_chinhsua.Size = new System.Drawing.Size(85, 33);
            this.button_chinhsua.TabIndex = 5;
            this.button_chinhsua.Text = "Chỉnh sửa";
            this.button_chinhsua.UseVisualStyleBackColor = false;
            this.button_chinhsua.Click += new System.EventHandler(this.button_chinhsua_Click);
            // 
            // button_xoabo
            // 
            this.button_xoabo.BackColor = System.Drawing.Color.Salmon;
            this.button_xoabo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoabo.Location = new System.Drawing.Point(575, 208);
            this.button_xoabo.Name = "button_xoabo";
            this.button_xoabo.Size = new System.Drawing.Size(85, 35);
            this.button_xoabo.TabIndex = 5;
            this.button_xoabo.Text = "Xóa bỏ";
            this.button_xoabo.UseVisualStyleBackColor = false;
            // 
            // button_timkiem
            // 
            this.button_timkiem.BackColor = System.Drawing.Color.Salmon;
            this.button_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_timkiem.Location = new System.Drawing.Point(575, 259);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(85, 37);
            this.button_timkiem.TabIndex = 5;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.hotensinhvien,
            this.sdt,
            this.diachi,
            this.ngaysinh,
            this.gioitinh});
            this.dataGridView1.Location = new System.Drawing.Point(27, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 182);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // masv
            // 
            this.masv.HeaderText = "Mã sinh viên";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            this.masv.Width = 125;
            // 
            // hotensinhvien
            // 
            this.hotensinhvien.FillWeight = 110F;
            this.hotensinhvien.HeaderText = "Họ tên sinh viên";
            this.hotensinhvien.MinimumWidth = 6;
            this.hotensinhvien.Name = "hotensinhvien";
            this.hotensinhvien.Width = 140;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.button_xoabo);
            this.Controls.Add(this.button_chinhsua);
            this.Controls.Add(this.button_boqua);
            this.Controls.Add(this.button_themmoi);
            this.Controls.Add(this.radioButton_Nu);
            this.Controls.Add(this.radioButton_Nam);
            this.Controls.Add(this.maskedTextBox_ngaysinh);
            this.Controls.Add(this.textBox_diachi);
            this.Controls.Add(this.textBox_sdt);
            this.Controls.Add(this.textBox_hovaten);
            this.Controls.Add(this.textBox_maSV);
            this.Controls.Add(this.label_gioitinh);
            this.Controls.Add(this.label_ngaysinh);
            this.Controls.Add(this.label_diachi);
            this.Controls.Add(this.label_sdt);
            this.Controls.Add(this.label_hovaten);
            this.Controls.Add(this.label_maSV);
            this.Controls.Add(this.label_thongtinSV);
            this.Name = "Form3";
            this.Text = "Thông tin sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_thongtinSV;
        private System.Windows.Forms.Label label_maSV;
        private System.Windows.Forms.Label label_hovaten;
        private System.Windows.Forms.Label label_sdt;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.Label label_ngaysinh;
        private System.Windows.Forms.Label label_gioitinh;
        private System.Windows.Forms.TextBox textBox_maSV;
        private System.Windows.Forms.TextBox textBox_hovaten;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.TextBox textBox_diachi;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ngaysinh;
        private System.Windows.Forms.RadioButton radioButton_Nam;
        private System.Windows.Forms.RadioButton radioButton_Nu;
        private System.Windows.Forms.Button button_themmoi;
        private System.Windows.Forms.Button button_boqua;
        private System.Windows.Forms.Button button_chinhsua;
        private System.Windows.Forms.Button button_xoabo;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotensinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
    }
}