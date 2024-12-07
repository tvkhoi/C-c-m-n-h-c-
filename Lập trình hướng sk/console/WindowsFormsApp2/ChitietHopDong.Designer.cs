namespace WindowsFormsApp2
{
    partial class ChitietHopDong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_formchitiet_TVK = new System.Windows.Forms.DataGridView();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1_ketqua_form2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_formchitiet_TVK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1_ketqua_form2);
            this.groupBox1.Controls.Add(this.dataGridView_formchitiet_TVK);
            this.groupBox1.Location = new System.Drawing.Point(44, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử thăm khám của bệnh nhân";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView_formchitiet_TVK
            // 
            this.dataGridView_formchitiet_TVK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_formchitiet_TVK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngay,
            this.mabn,
            this.dichvu});
            this.dataGridView_formchitiet_TVK.Location = new System.Drawing.Point(24, 83);
            this.dataGridView_formchitiet_TVK.Name = "dataGridView_formchitiet_TVK";
            this.dataGridView_formchitiet_TVK.ReadOnly = true;
            this.dataGridView_formchitiet_TVK.RowHeadersWidth = 51;
            this.dataGridView_formchitiet_TVK.RowTemplate.Height = 24;
            this.dataGridView_formchitiet_TVK.Size = new System.Drawing.Size(651, 267);
            this.dataGridView_formchitiet_TVK.TabIndex = 0;
            this.dataGridView_formchitiet_TVK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_formchitiet_TVK_CellClick);
            // 
            // ngay
            // 
            this.ngay.HeaderText = "Ngày";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            this.ngay.Width = 125;
            // 
            // mabn
            // 
            this.mabn.HeaderText = "Mã bệnh nhân";
            this.mabn.MinimumWidth = 6;
            this.mabn.Name = "mabn";
            this.mabn.ReadOnly = true;
            this.mabn.Width = 125;
            // 
            // dichvu
            // 
            this.dichvu.HeaderText = "Dịch vụ";
            this.dichvu.MinimumWidth = 6;
            this.dichvu.Name = "dichvu";
            this.dichvu.ReadOnly = true;
            this.dichvu.Width = 125;
            // 
            // label1_ketqua_form2
            // 
            this.label1_ketqua_form2.AutoSize = true;
            this.label1_ketqua_form2.Location = new System.Drawing.Point(264, 32);
            this.label1_ketqua_form2.Name = "label1_ketqua_form2";
            this.label1_ketqua_form2.Size = new System.Drawing.Size(0, 16);
            this.label1_ketqua_form2.TabIndex = 1;
            // 
            // ChitietHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChitietHopDong";
            this.Text = "Chi_tiết_hợp_đồng";
            this.Load += new System.EventHandler(this.ChitietHopDong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_formchitiet_TVK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_formchitiet_TVK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dichvu;
        private System.Windows.Forms.Label label1_ketqua_form2;
    }
}