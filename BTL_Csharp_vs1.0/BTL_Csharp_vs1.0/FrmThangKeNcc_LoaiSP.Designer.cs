namespace BTL_Csharp_vs1._0
{
    partial class FrmThangKeNcc_LoaiSP
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
            this.txtNcc = new System.Windows.Forms.ComboBox();
            this.txtLoaiSp = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNcc
            // 
            this.txtNcc.FormattingEnabled = true;
            this.txtNcc.Location = new System.Drawing.Point(172, 55);
            this.txtNcc.Name = "txtNcc";
            this.txtNcc.Size = new System.Drawing.Size(205, 24);
            this.txtNcc.TabIndex = 0;
            this.txtNcc.TextChanged += new System.EventHandler(this.txtNcc_TextChanged);
            // 
            // txtLoaiSp
            // 
            this.txtLoaiSp.FormattingEnabled = true;
            this.txtLoaiSp.Location = new System.Drawing.Point(536, 58);
            this.txtLoaiSp.Name = "txtLoaiSp";
            this.txtLoaiSp.Size = new System.Drawing.Size(146, 24);
            this.txtLoaiSp.TabIndex = 1;
            this.txtLoaiSp.TextChanged += new System.EventHandler(this.txtLoaiSp_TextChanged);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(59, 58);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(94, 16);
            this.text.TabIndex = 2;
            this.text.Text = "Nhà Cung Cấp";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(455, 61);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(53, 16);
            this.txt.TabIndex = 3;
            this.txt.Text = "Loại Sp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 235);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.text);
            this.Controls.Add(this.txtLoaiSp);
            this.Controls.Add(this.txtNcc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtNcc;
        private System.Windows.Forms.ComboBox txtLoaiSp;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}