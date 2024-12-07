namespace BTL_Csharp_vs1._0
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNhaCC = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQLNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHDNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQlBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menutaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtCaNhanVien = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDanhMuc,
            this.MenuQLNhapHang,
            this.MenuQlBanHang,
            this.menutaikhoan,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1833, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuDanhMuc
            // 
            this.MenuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNhanVien,
            this.MenuKhachHang,
            this.MenuNhaCC,
            this.MenuSanPham});
            this.MenuDanhMuc.Name = "MenuDanhMuc";
            this.MenuDanhMuc.Size = new System.Drawing.Size(177, 26);
            this.MenuDanhMuc.Text = "Quản Lý Danh Mục";
            // 
            // MenuNhanVien
            // 
            this.MenuNhanVien.Name = "MenuNhanVien";
            this.MenuNhanVien.Size = new System.Drawing.Size(294, 26);
            this.MenuNhanVien.Text = "Danh Mục Nhân Viên";
            this.MenuNhanVien.Click += new System.EventHandler(this.danhMụcNhânViênToolStripMenuItem_Click);
            // 
            // MenuKhachHang
            // 
            this.MenuKhachHang.Name = "MenuKhachHang";
            this.MenuKhachHang.Size = new System.Drawing.Size(294, 26);
            this.MenuKhachHang.Text = "Danh Mục Khách Hàng";
            this.MenuKhachHang.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // MenuNhaCC
            // 
            this.MenuNhaCC.Name = "MenuNhaCC";
            this.MenuNhaCC.Size = new System.Drawing.Size(294, 26);
            this.MenuNhaCC.Text = "Danh Mục Nhà Cung Cấp";
            this.MenuNhaCC.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // MenuSanPham
            // 
            this.MenuSanPham.Name = "MenuSanPham";
            this.MenuSanPham.Size = new System.Drawing.Size(294, 26);
            this.MenuSanPham.Text = "Danh Mục Sản Phẩm";
            this.MenuSanPham.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // MenuQLNhapHang
            // 
            this.MenuQLNhapHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHDNhap});
            this.MenuQLNhapHang.Name = "MenuQLNhapHang";
            this.MenuQLNhapHang.Size = new System.Drawing.Size(184, 26);
            this.MenuQLNhapHang.Text = "Quản Lý Nhập Hàng";
            // 
            // MenuHDNhap
            // 
            this.MenuHDNhap.BackColor = System.Drawing.SystemColors.Control;
            this.MenuHDNhap.Name = "MenuHDNhap";
            this.MenuHDNhap.Size = new System.Drawing.Size(259, 26);
            this.MenuHDNhap.Text = "Hóa Đơn Nhập Hàng";
            this.MenuHDNhap.Click += new System.EventHandler(this.hóaĐơnNhậpHàngToolStripMenuItem_Click);
            // 
            // MenuQlBanHang
            // 
            this.MenuQlBanHang.Name = "MenuQlBanHang";
            this.MenuQlBanHang.Size = new System.Drawing.Size(173, 26);
            this.MenuQlBanHang.Text = "Quản Lý Bán Hàng";
            this.MenuQlBanHang.Click += new System.EventHandler(this.danhMụcBánHàngToolStripMenuItem_Click);
            // 
            // menutaikhoan
            // 
            this.menutaikhoan.Name = "menutaikhoan";
            this.menutaikhoan.Size = new System.Drawing.Size(179, 26);
            this.menutaikhoan.Text = "Quản Lý Tài Khoản";
            this.menutaikhoan.Click += new System.EventHandler(this.menutaikhoan_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtCaNhanVien
            // 
            this.txtCaNhanVien.AutoSize = true;
            this.txtCaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCaNhanVien.Location = new System.Drawing.Point(21, 50);
            this.txtCaNhanVien.Name = "txtCaNhanVien";
            this.txtCaNhanVien.Size = new System.Drawing.Size(0, 22);
            this.txtCaNhanVien.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(933, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1081, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtCaNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuQLNhapHang;
        private System.Windows.Forms.ToolStripMenuItem MenuQlBanHang;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem MenuHDNhap;
        private System.Windows.Forms.Label txtCaNhanVien;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem MenuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MenuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem MenuNhaCC;
        private System.Windows.Forms.ToolStripMenuItem MenuSanPham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem menutaikhoan;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}