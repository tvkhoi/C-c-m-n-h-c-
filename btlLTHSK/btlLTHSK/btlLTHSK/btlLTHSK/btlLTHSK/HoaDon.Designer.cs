namespace btlLTHSK
{
    partial class HoaDon
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_HoaDon = new System.Windows.Forms.GroupBox();
            this.cb_MaKH = new System.Windows.Forms.ComboBox();
            this.cb_MaNV = new System.Windows.Forms.ComboBox();
            this.button_ThemHD = new System.Windows.Forms.Button();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dateTimePicker1_NgayBan = new System.Windows.Forms.DateTimePicker();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(696, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(818, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Khách Hàng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(818, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày Bán:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(962, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng Tiền:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox_HoaDon
            // 
            this.groupBox_HoaDon.Controls.Add(this.pictureBox1);
            this.groupBox_HoaDon.Controls.Add(this.cb_MaKH);
            this.groupBox_HoaDon.Controls.Add(this.cb_MaNV);
            this.groupBox_HoaDon.Controls.Add(this.button_ThemHD);
            this.groupBox_HoaDon.Controls.Add(this.btn_InHD);
            this.groupBox_HoaDon.Controls.Add(this.btn_LamMoi);
            this.groupBox_HoaDon.Controls.Add(this.btn_Xoa);
            this.groupBox_HoaDon.Controls.Add(this.btn_Sua);
            this.groupBox_HoaDon.Controls.Add(this.dateTimePicker1_NgayBan);
            this.groupBox_HoaDon.Controls.Add(this.txt_MaHD);
            this.groupBox_HoaDon.Controls.Add(this.label2);
            this.groupBox_HoaDon.Controls.Add(this.label3);
            this.groupBox_HoaDon.Controls.Add(this.label5);
            this.groupBox_HoaDon.Controls.Add(this.label4);
            this.groupBox_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox_HoaDon.Location = new System.Drawing.Point(52, 111);
            this.groupBox_HoaDon.Name = "groupBox_HoaDon";
            this.groupBox_HoaDon.Size = new System.Drawing.Size(1527, 369);
            this.groupBox_HoaDon.TabIndex = 2;
            this.groupBox_HoaDon.TabStop = false;
            this.groupBox_HoaDon.Text = "Hóa Đơn";
            this.groupBox_HoaDon.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_NgayBan_Validating);
            // 
            // cb_MaKH
            // 
            this.cb_MaKH.FormattingEnabled = true;
            this.cb_MaKH.Location = new System.Drawing.Point(1014, 122);
            this.cb_MaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_MaKH.Name = "cb_MaKH";
            this.cb_MaKH.Size = new System.Drawing.Size(292, 37);
            this.cb_MaKH.TabIndex = 7;
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.FormattingEnabled = true;
            this.cb_MaNV.Location = new System.Drawing.Point(240, 123);
            this.cb_MaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(396, 37);
            this.cb_MaNV.TabIndex = 6;
            this.cb_MaNV.Validating += new System.ComponentModel.CancelEventHandler(this.cb_MaNV_Validating);
            // 
            // button_ThemHD
            // 
            this.button_ThemHD.Location = new System.Drawing.Point(50, 298);
            this.button_ThemHD.Name = "button_ThemHD";
            this.button_ThemHD.Size = new System.Drawing.Size(148, 50);
            this.button_ThemHD.TabIndex = 5;
            this.button_ThemHD.Text = "Thêm";
            this.button_ThemHD.UseVisualStyleBackColor = true;
            this.button_ThemHD.Click += new System.EventHandler(this.button_ThemHD_Click);
            // 
            // btn_InHD
            // 
            this.btn_InHD.Location = new System.Drawing.Point(993, 298);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(159, 50);
            this.btn_InHD.TabIndex = 5;
            this.btn_InHD.Text = "In HD";
            this.btn_InHD.UseVisualStyleBackColor = true;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(762, 298);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(159, 50);
            this.btn_LamMoi.TabIndex = 5;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(534, 298);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(159, 50);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(296, 298);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(147, 50);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.button_Sua_HDMua_Click);
            // 
            // dateTimePicker1_NgayBan
            // 
            this.dateTimePicker1_NgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1_NgayBan.Location = new System.Drawing.Point(1014, 55);
            this.dateTimePicker1_NgayBan.Name = "dateTimePicker1_NgayBan";
            this.dateTimePicker1_NgayBan.Size = new System.Drawing.Size(292, 34);
            this.dateTimePicker1_NgayBan.TabIndex = 3;
            this.dateTimePicker1_NgayBan.Value = new System.DateTime(2024, 4, 10, 0, 0, 0, 0);
            this.dateTimePicker1_NgayBan.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_NgayBan_Validating);
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(240, 56);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(396, 34);
            this.txt_MaHD.TabIndex = 2;
            this.txt_MaHD.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MaHD_Validating);
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaHD,
            this.Column_MaNV,
            this.Column_MaKH,
            this.Column_NgayBan,
            this.Column1});
            this.dgv_HoaDon.Location = new System.Drawing.Point(102, 552);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 82;
            this.dgv_HoaDon.RowTemplate.Height = 33;
            this.dgv_HoaDon.Size = new System.Drawing.Size(1384, 341);
            this.dgv_HoaDon.TabIndex = 3;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::btlLTHSK.Properties.Resources.tải_xuống1;
            this.pictureBox1.Location = new System.Drawing.Point(1208, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 66);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Column_MaHD
            // 
            this.Column_MaHD.HeaderText = "Mã HD";
            this.Column_MaHD.MinimumWidth = 10;
            this.Column_MaHD.Name = "Column_MaHD";
            this.Column_MaHD.Width = 80;
            // 
            // Column_MaNV
            // 
            this.Column_MaNV.HeaderText = "Mã NV";
            this.Column_MaNV.MinimumWidth = 10;
            this.Column_MaNV.Name = "Column_MaNV";
            this.Column_MaNV.Width = 80;
            // 
            // Column_MaKH
            // 
            this.Column_MaKH.HeaderText = "Mã KH";
            this.Column_MaKH.MinimumWidth = 10;
            this.Column_MaKH.Name = "Column_MaKH";
            this.Column_MaKH.Width = 80;
            // 
            // Column_NgayBan
            // 
            this.Column_NgayBan.HeaderText = "Ngày Bán";
            this.Column_NgayBan.MinimumWidth = 10;
            this.Column_NgayBan.Name = "Column_NgayBan";
            this.Column_NgayBan.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1586, 905);
            this.Controls.Add(this.dgv_HoaDon);
            this.Controls.Add(this.groupBox_HoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "HoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox_HoaDon.ResumeLayout(false);
            this.groupBox_HoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_HoaDon;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_NgayBan;
        private System.Windows.Forms.Button button_ThemHD;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.ComboBox cb_MaKH;
        private System.Windows.Forms.ComboBox cb_MaNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}