namespace BTL_Csharp_vs1._0
{
    partial class FrmShowSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.ComboBox();
            this.txt_color = new System.Windows.Forms.ComboBox();
            this.ckb_Name = new System.Windows.Forms.CheckBox();
            this.ckb_Code = new System.Windows.Forms.CheckBox();
            this.ckb_Size = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk_Corlor = new System.Windows.Forms.CheckBox();
            this.txtCodeSP = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFoundProductCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(516, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Sản Phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-22, -35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 112);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSize
            // 
            this.txtSize.FormattingEnabled = true;
            this.txtSize.Location = new System.Drawing.Point(150, 245);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(190, 24);
            this.txtSize.TabIndex = 4;
            // 
            // txt_color
            // 
            this.txt_color.FormattingEnabled = true;
            this.txt_color.Location = new System.Drawing.Point(150, 307);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(188, 24);
            this.txt_color.TabIndex = 6;
            // 
            // ckb_Name
            // 
            this.ckb_Name.AutoSize = true;
            this.ckb_Name.Location = new System.Drawing.Point(12, 188);
            this.ckb_Name.Name = "ckb_Name";
            this.ckb_Name.Size = new System.Drawing.Size(118, 20);
            this.ckb_Name.TabIndex = 8;
            this.ckb_Name.Text = "Tên Sản Phẩm";
            this.ckb_Name.UseVisualStyleBackColor = true;
            // 
            // ckb_Code
            // 
            this.ckb_Code.AutoSize = true;
            this.ckb_Code.Location = new System.Drawing.Point(12, 134);
            this.ckb_Code.Name = "ckb_Code";
            this.ckb_Code.Size = new System.Drawing.Size(113, 20);
            this.ckb_Code.TabIndex = 9;
            this.ckb_Code.Text = "Mã Sản Phẩm";
            this.ckb_Code.UseVisualStyleBackColor = true;
            // 
            // ckb_Size
            // 
            this.ckb_Size.AutoSize = true;
            this.ckb_Size.Location = new System.Drawing.Point(17, 245);
            this.ckb_Size.Name = "ckb_Size";
            this.ckb_Size.Size = new System.Drawing.Size(55, 20);
            this.ckb_Size.TabIndex = 10;
            this.ckb_Size.Text = "Size";
            this.ckb_Size.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 281);
            this.dataGridView1.TabIndex = 11;
            // 
            // chk_Corlor
            // 
            this.chk_Corlor.AutoSize = true;
            this.chk_Corlor.Location = new System.Drawing.Point(12, 307);
            this.chk_Corlor.Name = "chk_Corlor";
            this.chk_Corlor.Size = new System.Drawing.Size(55, 20);
            this.chk_Corlor.TabIndex = 12;
            this.chk_Corlor.Text = "Màu";
            this.chk_Corlor.UseVisualStyleBackColor = true;
            // 
            // txtCodeSP
            // 
            this.txtCodeSP.Location = new System.Drawing.Point(150, 134);
            this.txtCodeSP.Name = "txtCodeSP";
            this.txtCodeSP.Size = new System.Drawing.Size(188, 22);
            this.txtCodeSP.TabIndex = 13;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(150, 186);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(188, 22);
            this.txtTen.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 15;
            // 
            // lblFoundProductCount
            // 
            this.lblFoundProductCount.AutoSize = true;
            this.lblFoundProductCount.Location = new System.Drawing.Point(74, 386);
            this.lblFoundProductCount.Name = "lblFoundProductCount";
            this.lblFoundProductCount.Size = new System.Drawing.Size(13, 16);
            this.lblFoundProductCount.TabIndex = 16;
            this.lblFoundProductCount.Text = "  ";
            // 
            // FrmShowSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 655);
            this.Controls.Add(this.lblFoundProductCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtCodeSP);
            this.Controls.Add(this.chk_Corlor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ckb_Size);
            this.Controls.Add(this.ckb_Code);
            this.Controls.Add(this.ckb_Name);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmShowSanPham";
            this.Text = "FrmShowSanPham";
            this.Load += new System.EventHandler(this.FrmShowSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtSize;
        private System.Windows.Forms.ComboBox txt_color;
        private System.Windows.Forms.CheckBox ckb_Name;
        private System.Windows.Forms.CheckBox ckb_Code;
        private System.Windows.Forms.CheckBox ckb_Size;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chk_Corlor;
        private System.Windows.Forms.TextBox txtCodeSP;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFoundProductCount;
    }
}