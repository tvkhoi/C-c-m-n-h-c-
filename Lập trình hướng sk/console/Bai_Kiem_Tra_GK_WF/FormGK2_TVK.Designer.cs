namespace Bai_Kiem_Tra_GK_WF
{
    partial class FormGK2_TVK
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
            this.groupBox_TVK = new System.Windows.Forms.GroupBox();
            this.radioButton_tatca_TVK = new System.Windows.Forms.RadioButton();
            this.radioButton_ctdt_TVK = new System.Windows.Forms.RadioButton();
            this.comboBox_ctdt_TVK = new System.Windows.Forms.ComboBox();
            this.dataGridView_sv = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_TVK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_TVK
            // 
            this.groupBox_TVK.Controls.Add(this.dataGridView_sv);
            this.groupBox_TVK.Controls.Add(this.comboBox_ctdt_TVK);
            this.groupBox_TVK.Controls.Add(this.radioButton_ctdt_TVK);
            this.groupBox_TVK.Controls.Add(this.radioButton_tatca_TVK);
            this.groupBox_TVK.Location = new System.Drawing.Point(27, 41);
            this.groupBox_TVK.Name = "groupBox_TVK";
            this.groupBox_TVK.Size = new System.Drawing.Size(726, 397);
            this.groupBox_TVK.TabIndex = 0;
            this.groupBox_TVK.TabStop = false;
            this.groupBox_TVK.Text = "Thông tin sinh viên";
            // 
            // radioButton_tatca_TVK
            // 
            this.radioButton_tatca_TVK.AutoSize = true;
            this.radioButton_tatca_TVK.Location = new System.Drawing.Point(41, 43);
            this.radioButton_tatca_TVK.Name = "radioButton_tatca_TVK";
            this.radioButton_tatca_TVK.Size = new System.Drawing.Size(66, 20);
            this.radioButton_tatca_TVK.TabIndex = 0;
            this.radioButton_tatca_TVK.Text = "Tất cả";
            this.radioButton_tatca_TVK.UseVisualStyleBackColor = true;
            this.radioButton_tatca_TVK.CheckedChanged += new System.EventHandler(this.radioButton_tatca_TVK_CheckedChanged);
            // 
            // radioButton_ctdt_TVK
            // 
            this.radioButton_ctdt_TVK.AutoSize = true;
            this.radioButton_ctdt_TVK.Location = new System.Drawing.Point(346, 43);
            this.radioButton_ctdt_TVK.Name = "radioButton_ctdt_TVK";
            this.radioButton_ctdt_TVK.Size = new System.Drawing.Size(99, 20);
            this.radioButton_ctdt_TVK.TabIndex = 0;
            this.radioButton_ctdt_TVK.Text = "Theo CTĐT";
            this.radioButton_ctdt_TVK.UseVisualStyleBackColor = true;
            this.radioButton_ctdt_TVK.CheckedChanged += new System.EventHandler(this.radioButton_ctdt_TVK_CheckedChanged);
            // 
            // comboBox_ctdt_TVK
            // 
            this.comboBox_ctdt_TVK.FormattingEnabled = true;
            this.comboBox_ctdt_TVK.Location = new System.Drawing.Point(468, 43);
            this.comboBox_ctdt_TVK.Name = "comboBox_ctdt_TVK";
            this.comboBox_ctdt_TVK.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ctdt_TVK.TabIndex = 1;
            this.comboBox_ctdt_TVK.SelectedIndexChanged += new System.EventHandler(this.comboBox_ctdt_TVK_SelectedIndexChanged);
            // 
            // dataGridView_sv
            // 
            this.dataGridView_sv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.hovaten,
            this.ngaysinh,
            this.tenmonhoc,
            this.diemmonhoc});
            this.dataGridView_sv.Location = new System.Drawing.Point(6, 95);
            this.dataGridView_sv.Name = "dataGridView_sv";
            this.dataGridView_sv.ReadOnly = true;
            this.dataGridView_sv.RowHeadersWidth = 51;
            this.dataGridView_sv.RowTemplate.Height = 24;
            this.dataGridView_sv.Size = new System.Drawing.Size(714, 284);
            this.dataGridView_sv.TabIndex = 2;
            // 
            // masv
            // 
            this.masv.HeaderText = "Mã sinh viên";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            this.masv.Width = 125;
            // 
            // hovaten
            // 
            this.hovaten.HeaderText = "Họ và tên";
            this.hovaten.MinimumWidth = 6;
            this.hovaten.Name = "hovaten";
            this.hovaten.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.Width = 125;
            // 
            // diemmonhoc
            // 
            this.diemmonhoc.HeaderText = "Điểm môn học";
            this.diemmonhoc.MinimumWidth = 6;
            this.diemmonhoc.Name = "diemmonhoc";
            this.diemmonhoc.Width = 125;
            // 
            // FormGK2_TVK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_TVK);
            this.Name = "FormGK2_TVK";
            this.Text = "FormGK2";
            this.Load += new System.EventHandler(this.FormGK2_TVK_Load);
            this.groupBox_TVK.ResumeLayout(false);
            this.groupBox_TVK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_TVK;
        private System.Windows.Forms.DataGridView dataGridView_sv;
        private System.Windows.Forms.ComboBox comboBox_ctdt_TVK;
        private System.Windows.Forms.RadioButton radioButton_ctdt_TVK;
        private System.Windows.Forms.RadioButton radioButton_tatca_TVK;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemmonhoc;
    }
}

