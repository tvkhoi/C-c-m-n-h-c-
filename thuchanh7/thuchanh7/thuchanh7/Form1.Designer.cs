namespace thuchanh7
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
            this.gpb_thongtinbenhnhan_VTL = new System.Windows.Forms.GroupBox();
            this.cbb_mabenhnhan_VTL = new System.Windows.Forms.ComboBox();
            this.cbb_chondichvu_VTL = new System.Windows.Forms.ComboBox();
            this.tb_dsdv_VTL = new System.Windows.Forms.TextBox();
            this.tb_nam_VTL = new System.Windows.Forms.TextBox();
            this.tb_thang_VTL = new System.Windows.Forms.TextBox();
            this.tb_ngay_VTL = new System.Windows.Forms.TextBox();
            this.tb_tenbenhnhan_VTL = new System.Windows.Forms.TextBox();
            this.lb_dsdv_VTL = new System.Windows.Forms.Label();
            this.lb_chondichvu_VTL = new System.Windows.Forms.Label();
            this.lb_nam_VTL = new System.Windows.Forms.Label();
            this.lb_thang_VTL = new System.Windows.Forms.Label();
            this.lb_ngay_VTL = new System.Windows.Forms.Label();
            this.lb_tenbenhnhan_VTL = new System.Windows.Forms.Label();
            this.lb_mabenhnhan_VTL = new System.Windows.Forms.Label();
            this.btn_chon_VTL = new System.Windows.Forms.Button();
            this.btn_tieptuc_VTL = new System.Windows.Forms.Button();
            this.btn_thoat_VTL = new System.Windows.Forms.Button();
            this.ptb_icon_VTL = new System.Windows.Forms.PictureBox();
            this.gpb_ketqua_VTL = new System.Windows.Forms.GroupBox();
            this.tb_ketqua_VTL = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpb_thongtinbenhnhan_VTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_icon_VTL)).BeginInit();
            this.gpb_ketqua_VTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_thongtinbenhnhan_VTL
            // 
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.cbb_mabenhnhan_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.cbb_chondichvu_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.tb_dsdv_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.tb_nam_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.tb_thang_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.tb_ngay_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.tb_tenbenhnhan_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.lb_dsdv_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.lb_chondichvu_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.lb_nam_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.lb_thang_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.lb_ngay_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.lb_tenbenhnhan_VTL);
            this.gpb_thongtinbenhnhan_VTL.Controls.Add(this.lb_mabenhnhan_VTL);
            this.gpb_thongtinbenhnhan_VTL.Location = new System.Drawing.Point(13, 13);
            this.gpb_thongtinbenhnhan_VTL.Name = "gpb_thongtinbenhnhan_VTL";
            this.gpb_thongtinbenhnhan_VTL.Size = new System.Drawing.Size(2032, 670);
            this.gpb_thongtinbenhnhan_VTL.TabIndex = 0;
            this.gpb_thongtinbenhnhan_VTL.TabStop = false;
            this.gpb_thongtinbenhnhan_VTL.Text = "Thông tin bệnh nhân";
            this.gpb_thongtinbenhnhan_VTL.Enter += new System.EventHandler(this.gpb_thongtinbenhnhan_VTL_Enter);
            // 
            // cbb_mabenhnhan_VTL
            // 
            this.cbb_mabenhnhan_VTL.FormattingEnabled = true;
            this.cbb_mabenhnhan_VTL.Location = new System.Drawing.Point(273, 69);
            this.cbb_mabenhnhan_VTL.Name = "cbb_mabenhnhan_VTL";
            this.cbb_mabenhnhan_VTL.Size = new System.Drawing.Size(693, 39);
            this.cbb_mabenhnhan_VTL.TabIndex = 13;
            this.cbb_mabenhnhan_VTL.SelectedIndexChanged += new System.EventHandler(this.cmb_mabenhnhan_SelectedIndexChanged);
            // 
            // cbb_chondichvu_VTL
            // 
            this.cbb_chondichvu_VTL.FormattingEnabled = true;
            this.cbb_chondichvu_VTL.Location = new System.Drawing.Point(215, 345);
            this.cbb_chondichvu_VTL.Name = "cbb_chondichvu_VTL";
            this.cbb_chondichvu_VTL.Size = new System.Drawing.Size(396, 39);
            this.cbb_chondichvu_VTL.TabIndex = 12;
            this.cbb_chondichvu_VTL.SelectedIndexChanged += new System.EventHandler(this.cmb_chondichvu_SelectedIndexChanged);
            // 
            // tb_dsdv_VTL
            // 
            this.tb_dsdv_VTL.Location = new System.Drawing.Point(1256, 348);
            this.tb_dsdv_VTL.Multiline = true;
            this.tb_dsdv_VTL.Name = "tb_dsdv_VTL";
            this.tb_dsdv_VTL.ReadOnly = true;
            this.tb_dsdv_VTL.Size = new System.Drawing.Size(754, 307);
            this.tb_dsdv_VTL.TabIndex = 11;
            // 
            // tb_nam_VTL
            // 
            this.tb_nam_VTL.Location = new System.Drawing.Point(803, 238);
            this.tb_nam_VTL.Name = "tb_nam_VTL";
            this.tb_nam_VTL.Size = new System.Drawing.Size(163, 38);
            this.tb_nam_VTL.TabIndex = 10;
            // 
            // tb_thang_VTL
            // 
            this.tb_thang_VTL.Location = new System.Drawing.Point(448, 238);
            this.tb_thang_VTL.Name = "tb_thang_VTL";
            this.tb_thang_VTL.Size = new System.Drawing.Size(163, 38);
            this.tb_thang_VTL.TabIndex = 9;
            // 
            // tb_ngay_VTL
            // 
            this.tb_ngay_VTL.Location = new System.Drawing.Point(126, 238);
            this.tb_ngay_VTL.Name = "tb_ngay_VTL";
            this.tb_ngay_VTL.Size = new System.Drawing.Size(163, 38);
            this.tb_ngay_VTL.TabIndex = 8;
            // 
            // tb_tenbenhnhan_VTL
            // 
            this.tb_tenbenhnhan_VTL.Location = new System.Drawing.Point(273, 142);
            this.tb_tenbenhnhan_VTL.Name = "tb_tenbenhnhan_VTL";
            this.tb_tenbenhnhan_VTL.Size = new System.Drawing.Size(693, 38);
            this.tb_tenbenhnhan_VTL.TabIndex = 7;
            // 
            // lb_dsdv_VTL
            // 
            this.lb_dsdv_VTL.AutoSize = true;
            this.lb_dsdv_VTL.Location = new System.Drawing.Point(982, 348);
            this.lb_dsdv_VTL.Name = "lb_dsdv_VTL";
            this.lb_dsdv_VTL.Size = new System.Drawing.Size(246, 32);
            this.lb_dsdv_VTL.TabIndex = 6;
            this.lb_dsdv_VTL.Text = "Danh sách dịch vụ";
            // 
            // lb_chondichvu_VTL
            // 
            this.lb_chondichvu_VTL.AutoSize = true;
            this.lb_chondichvu_VTL.Location = new System.Drawing.Point(30, 348);
            this.lb_chondichvu_VTL.Name = "lb_chondichvu_VTL";
            this.lb_chondichvu_VTL.Size = new System.Drawing.Size(179, 32);
            this.lb_chondichvu_VTL.TabIndex = 5;
            this.lb_chondichvu_VTL.Text = "Chọn dịch vụ";
            // 
            // lb_nam_VTL
            // 
            this.lb_nam_VTL.AutoSize = true;
            this.lb_nam_VTL.Location = new System.Drawing.Point(700, 238);
            this.lb_nam_VTL.Name = "lb_nam_VTL";
            this.lb_nam_VTL.Size = new System.Drawing.Size(73, 32);
            this.lb_nam_VTL.TabIndex = 4;
            this.lb_nam_VTL.Text = "Năm";
            // 
            // lb_thang_VTL
            // 
            this.lb_thang_VTL.AutoSize = true;
            this.lb_thang_VTL.Location = new System.Drawing.Point(329, 238);
            this.lb_thang_VTL.Name = "lb_thang_VTL";
            this.lb_thang_VTL.Size = new System.Drawing.Size(95, 32);
            this.lb_thang_VTL.TabIndex = 3;
            this.lb_thang_VTL.Text = "Tháng";
            // 
            // lb_ngay_VTL
            // 
            this.lb_ngay_VTL.AutoSize = true;
            this.lb_ngay_VTL.Location = new System.Drawing.Point(30, 238);
            this.lb_ngay_VTL.Name = "lb_ngay_VTL";
            this.lb_ngay_VTL.Size = new System.Drawing.Size(80, 32);
            this.lb_ngay_VTL.TabIndex = 2;
            this.lb_ngay_VTL.Text = "Ngày";
            // 
            // lb_tenbenhnhan_VTL
            // 
            this.lb_tenbenhnhan_VTL.AutoSize = true;
            this.lb_tenbenhnhan_VTL.Location = new System.Drawing.Point(30, 145);
            this.lb_tenbenhnhan_VTL.Name = "lb_tenbenhnhan_VTL";
            this.lb_tenbenhnhan_VTL.Size = new System.Drawing.Size(205, 32);
            this.lb_tenbenhnhan_VTL.TabIndex = 1;
            this.lb_tenbenhnhan_VTL.Text = "Tên bệnh nhân";
            // 
            // lb_mabenhnhan_VTL
            // 
            this.lb_mabenhnhan_VTL.AutoSize = true;
            this.lb_mabenhnhan_VTL.Location = new System.Drawing.Point(30, 69);
            this.lb_mabenhnhan_VTL.Name = "lb_mabenhnhan_VTL";
            this.lb_mabenhnhan_VTL.Size = new System.Drawing.Size(195, 32);
            this.lb_mabenhnhan_VTL.TabIndex = 0;
            this.lb_mabenhnhan_VTL.Text = "Mã bệnh nhân";
            // 
            // btn_chon_VTL
            // 
            this.btn_chon_VTL.Location = new System.Drawing.Point(139, 733);
            this.btn_chon_VTL.Name = "btn_chon_VTL";
            this.btn_chon_VTL.Size = new System.Drawing.Size(211, 61);
            this.btn_chon_VTL.TabIndex = 1;
            this.btn_chon_VTL.Text = "Chọn";
            this.btn_chon_VTL.UseVisualStyleBackColor = true;
            this.btn_chon_VTL.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btn_tieptuc_VTL
            // 
            this.btn_tieptuc_VTL.Location = new System.Drawing.Point(600, 733);
            this.btn_tieptuc_VTL.Name = "btn_tieptuc_VTL";
            this.btn_tieptuc_VTL.Size = new System.Drawing.Size(211, 61);
            this.btn_tieptuc_VTL.TabIndex = 2;
            this.btn_tieptuc_VTL.Text = "Tiếp tục";
            this.btn_tieptuc_VTL.UseVisualStyleBackColor = true;
            // 
            // btn_thoat_VTL
            // 
            this.btn_thoat_VTL.Location = new System.Drawing.Point(1039, 733);
            this.btn_thoat_VTL.Name = "btn_thoat_VTL";
            this.btn_thoat_VTL.Size = new System.Drawing.Size(211, 61);
            this.btn_thoat_VTL.TabIndex = 3;
            this.btn_thoat_VTL.Text = "Thoát";
            this.btn_thoat_VTL.UseVisualStyleBackColor = true;
            // 
            // ptb_icon_VTL
            // 
            this.ptb_icon_VTL.Image = global::thuchanh7.Properties.Resources.Ảnh_chụp_màn_hình_2024_03_24_131506;
            this.ptb_icon_VTL.Location = new System.Drawing.Point(1616, 733);
            this.ptb_icon_VTL.Name = "ptb_icon_VTL";
            this.ptb_icon_VTL.Size = new System.Drawing.Size(90, 74);
            this.ptb_icon_VTL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_icon_VTL.TabIndex = 4;
            this.ptb_icon_VTL.TabStop = false;
            this.ptb_icon_VTL.Click += new System.EventHandler(this.ptb_icon_VTL_Click);
            // 
            // gpb_ketqua_VTL
            // 
            this.gpb_ketqua_VTL.Controls.Add(this.tb_ketqua_VTL);
            this.gpb_ketqua_VTL.ForeColor = System.Drawing.Color.Red;
            this.gpb_ketqua_VTL.Location = new System.Drawing.Point(13, 805);
            this.gpb_ketqua_VTL.Name = "gpb_ketqua_VTL";
            this.gpb_ketqua_VTL.Size = new System.Drawing.Size(2010, 572);
            this.gpb_ketqua_VTL.TabIndex = 5;
            this.gpb_ketqua_VTL.TabStop = false;
            this.gpb_ketqua_VTL.Text = "Kết quả";
            // 
            // tb_ketqua_VTL
            // 
            this.tb_ketqua_VTL.Location = new System.Drawing.Point(21, 47);
            this.tb_ketqua_VTL.Multiline = true;
            this.tb_ketqua_VTL.Name = "tb_ketqua_VTL";
            this.tb_ketqua_VTL.ReadOnly = true;
            this.tb_ketqua_VTL.Size = new System.Drawing.Size(1983, 502);
            this.tb_ketqua_VTL.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2057, 1389);
            this.Controls.Add(this.gpb_ketqua_VTL);
            this.Controls.Add(this.ptb_icon_VTL);
            this.Controls.Add(this.btn_thoat_VTL);
            this.Controls.Add(this.btn_tieptuc_VTL);
            this.Controls.Add(this.btn_chon_VTL);
            this.Controls.Add(this.gpb_thongtinbenhnhan_VTL);
            this.Name = "Form1";
            this.Text = "Thẩm mỹ viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpb_thongtinbenhnhan_VTL.ResumeLayout(false);
            this.gpb_thongtinbenhnhan_VTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_icon_VTL)).EndInit();
            this.gpb_ketqua_VTL.ResumeLayout(false);
            this.gpb_ketqua_VTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_thongtinbenhnhan_VTL;
        private System.Windows.Forms.TextBox tb_nam_VTL;
        private System.Windows.Forms.TextBox tb_thang_VTL;
        private System.Windows.Forms.TextBox tb_ngay_VTL;
        private System.Windows.Forms.TextBox tb_tenbenhnhan_VTL;
        private System.Windows.Forms.Label lb_dsdv_VTL;
        private System.Windows.Forms.Label lb_chondichvu_VTL;
        private System.Windows.Forms.Label lb_nam_VTL;
        private System.Windows.Forms.Label lb_thang_VTL;
        private System.Windows.Forms.Label lb_ngay_VTL;
        private System.Windows.Forms.Label lb_tenbenhnhan_VTL;
        private System.Windows.Forms.Label lb_mabenhnhan_VTL;
        private System.Windows.Forms.ComboBox cbb_mabenhnhan_VTL;
        private System.Windows.Forms.ComboBox cbb_chondichvu_VTL;
        private System.Windows.Forms.TextBox tb_dsdv_VTL;
        private System.Windows.Forms.Button btn_chon_VTL;
        private System.Windows.Forms.Button btn_tieptuc_VTL;
        private System.Windows.Forms.Button btn_thoat_VTL;
        private System.Windows.Forms.PictureBox ptb_icon_VTL;
        private System.Windows.Forms.GroupBox gpb_ketqua_VTL;
        private System.Windows.Forms.TextBox tb_ketqua_VTL;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

