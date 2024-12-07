namespace thuchanh3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenbenhnhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ngay = new System.Windows.Forms.TextBox();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_chondichvu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_danhsachdichvu = new System.Windows.Forms.TextBox();
            this.btn_chon = new System.Windows.Forms.Button();
            this.btn_tieptuc = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bệnh nhân";
            // 
            // txt_tenbenhnhan
            // 
            this.txt_tenbenhnhan.Location = new System.Drawing.Point(362, 84);
            this.txt_tenbenhnhan.Name = "txt_tenbenhnhan";
            this.txt_tenbenhnhan.Size = new System.Drawing.Size(567, 38);
            this.txt_tenbenhnhan.TabIndex = 2;
            this.txt_tenbenhnhan.TextChanged += new System.EventHandler(this.txt_tenbenhnhan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Năm";
            // 
            // txt_ngay
            // 
            this.txt_ngay.Location = new System.Drawing.Point(162, 181);
            this.txt_ngay.Name = "txt_ngay";
            this.txt_ngay.Size = new System.Drawing.Size(120, 38);
            this.txt_ngay.TabIndex = 6;
            this.txt_ngay.Click += new System.EventHandler(this.txt_ngay_TextChanged);
            this.txt_ngay.TextChanged += new System.EventHandler(this.txt_ngay_TextChanged);
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(488, 184);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(120, 38);
            this.txt_thang.TabIndex = 7;
            this.txt_thang.Click += new System.EventHandler(this.txt_thang_TextChanged);
            this.txt_thang.TextChanged += new System.EventHandler(this.txt_thang_TextChanged);
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(829, 184);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(120, 38);
            this.txt_nam.TabIndex = 8;
            this.txt_nam.Click += new System.EventHandler(this.txt_nam_TextChanged);
            this.txt_nam.TextChanged += new System.EventHandler(this.txt_nam_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Chọn dịch vụ";
            // 
            // cmb_chondichvu
            // 
            this.cmb_chondichvu.FormattingEnabled = true;
            this.cmb_chondichvu.Items.AddRange(new object[] {
            "Lăn kim",
            "Triệt lông",
            "Nâng mũi",
            "Cắt môi trái tim",
            "Cắt mí mắt",
            "Xăm lông mày",
            "Xăm môi"});
            this.cmb_chondichvu.Location = new System.Drawing.Point(273, 274);
            this.cmb_chondichvu.Name = "cmb_chondichvu";
            this.cmb_chondichvu.Size = new System.Drawing.Size(295, 39);
            this.cmb_chondichvu.TabIndex = 10;
            this.cmb_chondichvu.SelectedIndexChanged += new System.EventHandler(this.cmb_chondichvu_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Danh sách dịch vụ";
            // 
            // txt_danhsachdichvu
            // 
            this.txt_danhsachdichvu.Location = new System.Drawing.Point(1022, 274);
            this.txt_danhsachdichvu.Multiline = true;
            this.txt_danhsachdichvu.Name = "txt_danhsachdichvu";
            this.txt_danhsachdichvu.ReadOnly = true;
            this.txt_danhsachdichvu.Size = new System.Drawing.Size(852, 450);
            this.txt_danhsachdichvu.TabIndex = 12;
            // 
            // btn_chon
            // 
            this.btn_chon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_chon.Location = new System.Drawing.Point(155, 836);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(204, 78);
            this.btn_chon.TabIndex = 13;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.UseVisualStyleBackColor = false;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btn_tieptuc
            // 
            this.btn_tieptuc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_tieptuc.Location = new System.Drawing.Point(523, 836);
            this.btn_tieptuc.Name = "btn_tieptuc";
            this.btn_tieptuc.Size = new System.Drawing.Size(204, 78);
            this.btn_tieptuc.TabIndex = 14;
            this.btn_tieptuc.Text = "Tiếp tục";
            this.btn_tieptuc.UseVisualStyleBackColor = false;
            this.btn_tieptuc.Click += new System.EventHandler(this.btn_tieptuc_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_thoat.Location = new System.Drawing.Point(934, 836);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(204, 78);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ketqua);
            this.groupBox1.Location = new System.Drawing.Point(52, 950);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1963, 501);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Location = new System.Drawing.Point(17, 37);
            this.txt_ketqua.Multiline = true;
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.ReadOnly = true;
            this.txt_ketqua.Size = new System.Drawing.Size(1940, 447);
            this.txt_ketqua.TabIndex = 0;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2061, 1474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_tieptuc);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.txt_danhsachdichvu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_chondichvu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.txt_thang);
            this.Controls.Add(this.txt_ngay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenbenhnhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Thẩm mỹ viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenbenhnhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ngay;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_chondichvu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_danhsachdichvu;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.Button btn_tieptuc;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.ErrorProvider err;
    }
}

