namespace DemoChuyenDuLieu
{
    partial class TrangChu
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
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_nhaplieu = new System.Windows.Forms.TextBox();
            this.lb_nhandulieu = new System.Windows.Forms.Label();
            this.btn_gui = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openForm1});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(135, 44);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // openForm1
            // 
            this.openForm1.Name = "openForm1";
            this.openForm1.Size = new System.Drawing.Size(359, 44);
            this.openForm1.Text = "Mở form 1";
            this.openForm1.Click += new System.EventHandler(this.openForm1_Click);
            // 
            // tb_nhaplieu
            // 
            this.tb_nhaplieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nhaplieu.Location = new System.Drawing.Point(279, 134);
            this.tb_nhaplieu.Name = "tb_nhaplieu";
            this.tb_nhaplieu.Size = new System.Drawing.Size(322, 35);
            this.tb_nhaplieu.TabIndex = 1;
            // 
            // lb_nhandulieu
            // 
            this.lb_nhandulieu.AutoSize = true;
            this.lb_nhandulieu.Location = new System.Drawing.Point(279, 69);
            this.lb_nhandulieu.Name = "lb_nhandulieu";
            this.lb_nhandulieu.Size = new System.Drawing.Size(223, 25);
            this.lb_nhandulieu.TabIndex = 2;
            this.lb_nhandulieu.Text = "Nhận dữ liệu từ form 1";
            // 
            // btn_gui
            // 
            this.btn_gui.Location = new System.Drawing.Point(299, 223);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(262, 68);
            this.btn_gui.TabIndex = 3;
            this.btn_gui.Text = "Gửi dữ liệu sang form1";
            this.btn_gui.UseVisualStyleBackColor = true;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 625);
            this.Controls.Add(this.btn_gui);
            this.Controls.Add(this.lb_nhandulieu);
            this.Controls.Add(this.tb_nhaplieu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openForm1;
        private System.Windows.Forms.TextBox tb_nhaplieu;
        private System.Windows.Forms.Label lb_nhandulieu;
        private System.Windows.Forms.Button btn_gui;
    }
}