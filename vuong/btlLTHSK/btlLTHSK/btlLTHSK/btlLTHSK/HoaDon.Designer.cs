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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_ThemHD = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox_HoaDon.Controls.Add(this.comboBox2);
            this.groupBox_HoaDon.Controls.Add(this.comboBox1);
            this.groupBox_HoaDon.Controls.Add(this.button_ThemHD);
            this.groupBox_HoaDon.Controls.Add(this.button5);
            this.groupBox_HoaDon.Controls.Add(this.button6);
            this.groupBox_HoaDon.Controls.Add(this.button4);
            this.groupBox_HoaDon.Controls.Add(this.button3);
            this.groupBox_HoaDon.Controls.Add(this.button1);
            this.groupBox_HoaDon.Controls.Add(this.dateTimePicker1);
            this.groupBox_HoaDon.Controls.Add(this.textBox1);
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
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1014, 122);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(396, 37);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 123);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(396, 37);
            this.comboBox1.TabIndex = 6;
            // 
            // button_ThemHD
            // 
            this.button_ThemHD.Location = new System.Drawing.Point(50, 298);
            this.button_ThemHD.Name = "button_ThemHD";
            this.button_ThemHD.Size = new System.Drawing.Size(148, 50);
            this.button_ThemHD.TabIndex = 5;
            this.button_ThemHD.Text = "Thêm";
            this.button_ThemHD.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1275, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "In HD";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1028, 298);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "Làm mới";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(782, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "Chi Tiết";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1014, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 34);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 34);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1106, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(292, 31);
            this.textBox3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaHD,
            this.Column_MaNV,
            this.Column_MaKH,
            this.Column_NgayBan});
            this.dataGridView1.Location = new System.Drawing.Point(128, 553);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 341);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column_MaHD
            // 
            this.Column_MaHD.HeaderText = "Mã HD";
            this.Column_MaHD.MinimumWidth = 10;
            this.Column_MaHD.Name = "Column_MaHD";
            this.Column_MaHD.Width = 200;
            // 
            // Column_MaNV
            // 
            this.Column_MaNV.HeaderText = "Mã NV";
            this.Column_MaNV.MinimumWidth = 10;
            this.Column_MaNV.Name = "Column_MaNV";
            this.Column_MaNV.Width = 200;
            // 
            // Column_MaKH
            // 
            this.Column_MaKH.HeaderText = "Mã KH";
            this.Column_MaKH.MinimumWidth = 10;
            this.Column_MaKH.Name = "Column_MaKH";
            this.Column_MaKH.Width = 200;
            // 
            // Column_NgayBan
            // 
            this.Column_NgayBan.HeaderText = "Ngày Bán";
            this.Column_NgayBan.MinimumWidth = 10;
            this.Column_NgayBan.Name = "Column_NgayBan";
            this.Column_NgayBan.Width = 200;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1586, 905);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_HoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Name = "HoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox_HoaDon.ResumeLayout(false);
            this.groupBox_HoaDon.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_HoaDon;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_ThemHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NgayBan;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}