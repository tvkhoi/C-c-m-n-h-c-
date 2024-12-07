namespace DemoChuyenDuLieu
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
            this.lb_nhandulieu = new System.Windows.Forms.Label();
            this.tb_nhapdulieu = new System.Windows.Forms.TextBox();
            this.btn_ChuyendulieulenTrangChu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nhandulieu
            // 
            this.lb_nhandulieu.AutoSize = true;
            this.lb_nhandulieu.Location = new System.Drawing.Point(305, 90);
            this.lb_nhandulieu.Name = "lb_nhandulieu";
            this.lb_nhandulieu.Size = new System.Drawing.Size(308, 25);
            this.lb_nhandulieu.TabIndex = 0;
            this.lb_nhandulieu.Text = "Nhận dữ liệu từ form Trang chủ";
            // 
            // tb_nhapdulieu
            // 
            this.tb_nhapdulieu.Location = new System.Drawing.Point(356, 170);
            this.tb_nhapdulieu.Name = "tb_nhapdulieu";
            this.tb_nhapdulieu.Size = new System.Drawing.Size(244, 31);
            this.tb_nhapdulieu.TabIndex = 1;
            // 
            // btn_ChuyendulieulenTrangChu
            // 
            this.btn_ChuyendulieulenTrangChu.Location = new System.Drawing.Point(356, 257);
            this.btn_ChuyendulieulenTrangChu.Name = "btn_ChuyendulieulenTrangChu";
            this.btn_ChuyendulieulenTrangChu.Size = new System.Drawing.Size(257, 104);
            this.btn_ChuyendulieulenTrangChu.TabIndex = 2;
            this.btn_ChuyendulieulenTrangChu.Text = "Chuyển dữ liệu từ text box lên form Trang chủ";
            this.btn_ChuyendulieulenTrangChu.UseVisualStyleBackColor = true;
            this.btn_ChuyendulieulenTrangChu.Click += new System.EventHandler(this.btn_ChuyendulieulenTrangChu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 585);
            this.Controls.Add(this.btn_ChuyendulieulenTrangChu);
            this.Controls.Add(this.tb_nhapdulieu);
            this.Controls.Add(this.lb_nhandulieu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nhandulieu;
        private System.Windows.Forms.TextBox tb_nhapdulieu;
        private System.Windows.Forms.Button btn_ChuyendulieulenTrangChu;
    }
}

