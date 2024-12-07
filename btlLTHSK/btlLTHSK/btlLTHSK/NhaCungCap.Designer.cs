namespace btlLTHSK
{
    partial class NhaCungCap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_diachiNCC = new System.Windows.Forms.TextBox();
            this.textBox_sdtNCC = new System.Windows.Forms.TextBox();
            this.textBox_maNCC = new System.Windows.Forms.TextBox();
            this.textBox_tenNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_NCC = new System.Windows.Forms.DataGridView();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.comboBox_timkiem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.Column_MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DiaChiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(439, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhà Cung Cấp:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.button_Huy);
            this.groupBox1.Controls.Add(this.button_sua);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.textBox_diachiNCC);
            this.groupBox1.Controls.Add(this.textBox_sdtNCC);
            this.groupBox1.Controls.Add(this.textBox_maNCC);
            this.groupBox1.Controls.Add(this.textBox_tenNCC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(958, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(770, 145);
            this.button_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(83, 31);
            this.button_Huy.TabIndex = 3;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(279, 145);
            this.button_sua.Margin = new System.Windows.Forms.Padding(2);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(83, 31);
            this.button_sua.TabIndex = 3;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(104, 145);
            this.button_Them.Margin = new System.Windows.Forms.Padding(2);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(83, 31);
            this.button_Them.TabIndex = 3;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_diachiNCC
            // 
            this.textBox_diachiNCC.Location = new System.Drawing.Point(675, 81);
            this.textBox_diachiNCC.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_diachiNCC.Name = "textBox_diachiNCC";
            this.textBox_diachiNCC.Size = new System.Drawing.Size(215, 22);
            this.textBox_diachiNCC.TabIndex = 2;
            this.textBox_diachiNCC.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_diachiNCC_Validating);
            // 
            // textBox_sdtNCC
            // 
            this.textBox_sdtNCC.Location = new System.Drawing.Point(675, 41);
            this.textBox_sdtNCC.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sdtNCC.Name = "textBox_sdtNCC";
            this.textBox_sdtNCC.Size = new System.Drawing.Size(215, 22);
            this.textBox_sdtNCC.TabIndex = 2;
            this.textBox_sdtNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sdtNCC_KeyPress);
            this.textBox_sdtNCC.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_sdtNCC_Validating);
            // 
            // textBox_maNCC
            // 
            this.textBox_maNCC.Location = new System.Drawing.Point(171, 41);
            this.textBox_maNCC.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_maNCC.Name = "textBox_maNCC";
            this.textBox_maNCC.Size = new System.Drawing.Size(215, 22);
            this.textBox_maNCC.TabIndex = 2;
            this.textBox_maNCC.TextChanged += new System.EventHandler(this.textBox_maNCC_TextChanged);
            this.textBox_maNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_maNCC_KeyPress);
            this.textBox_maNCC.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_maNCC_Validating);
            // 
            // textBox_tenNCC
            // 
            this.textBox_tenNCC.Location = new System.Drawing.Point(171, 81);
            this.textBox_tenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_tenNCC.Name = "textBox_tenNCC";
            this.textBox_tenNCC.Size = new System.Drawing.Size(215, 22);
            this.textBox_tenNCC.TabIndex = 2;
            this.textBox_tenNCC.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_tenNCC_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Nhà Cung Cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm Kiếm:";
            // 
            // dataGridView_NCC
            // 
            this.dataGridView_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaNCC,
            this.Column_TenNCC,
            this.Column_SDT,
            this.Column_DiaChiNCC,
            this.Column1});
            this.dataGridView_NCC.Location = new System.Drawing.Point(77, 348);
            this.dataGridView_NCC.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_NCC.Name = "dataGridView_NCC";
            this.dataGridView_NCC.ReadOnly = true;
            this.dataGridView_NCC.RowHeadersWidth = 82;
            this.dataGridView_NCC.RowTemplate.Height = 33;
            this.dataGridView_NCC.Size = new System.Drawing.Size(814, 164);
            this.dataGridView_NCC.TabIndex = 3;
            this.dataGridView_NCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NCC_CellClick);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(168, 317);
            this.textBox_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(285, 22);
            this.textBox_TimKiem.TabIndex = 4;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // comboBox_timkiem
            // 
            this.comboBox_timkiem.FormattingEnabled = true;
            this.comboBox_timkiem.Items.AddRange(new object[] {
            "Tên Nhà Cung Cấp",
            "Địa Chỉ",
            "Số Điện Thoại"});
            this.comboBox_timkiem.Location = new System.Drawing.Point(531, 317);
            this.comboBox_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_timkiem.Name = "comboBox_timkiem";
            this.comboBox_timkiem.Size = new System.Drawing.Size(179, 24);
            this.comboBox_timkiem.TabIndex = 6;
            this.comboBox_timkiem.Text = "Tên Nhà Cung Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(171, 109);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(215, 22);
            this.textBox_email.TabIndex = 4;
            // 
            // Column_MaNCC
            // 
            this.Column_MaNCC.HeaderText = "Mã NCC";
            this.Column_MaNCC.MinimumWidth = 10;
            this.Column_MaNCC.Name = "Column_MaNCC";
            this.Column_MaNCC.ReadOnly = true;
            this.Column_MaNCC.Width = 150;
            // 
            // Column_TenNCC
            // 
            this.Column_TenNCC.HeaderText = "Tên NCC";
            this.Column_TenNCC.MinimumWidth = 10;
            this.Column_TenNCC.Name = "Column_TenNCC";
            this.Column_TenNCC.ReadOnly = true;
            this.Column_TenNCC.Width = 150;
            // 
            // Column_SDT
            // 
            this.Column_SDT.HeaderText = "Liên Hệ";
            this.Column_SDT.MinimumWidth = 10;
            this.Column_SDT.Name = "Column_SDT";
            this.Column_SDT.ReadOnly = true;
            this.Column_SDT.Width = 125;
            // 
            // Column_DiaChiNCC
            // 
            this.Column_DiaChiNCC.HeaderText = "Địa Chỉ";
            this.Column_DiaChiNCC.MinimumWidth = 10;
            this.Column_DiaChiNCC.Name = "Column_DiaChiNCC";
            this.Column_DiaChiNCC.ReadOnly = true;
            this.Column_DiaChiNCC.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Email";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 600);
            this.Controls.Add(this.comboBox_timkiem);
            this.Controls.Add(this.textBox_TimKiem);
            this.Controls.Add(this.dataGridView_NCC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_diachiNCC;
        private System.Windows.Forms.TextBox textBox_sdtNCC;
        private System.Windows.Forms.TextBox textBox_maNCC;
        private System.Windows.Forms.TextBox textBox_tenNCC;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_NCC;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.ComboBox comboBox_timkiem;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DiaChiNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}