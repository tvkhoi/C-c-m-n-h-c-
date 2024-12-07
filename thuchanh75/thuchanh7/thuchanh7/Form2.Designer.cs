namespace thuchanh7
{
    partial class Form2_VTL
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
            this.grb_lstkcbn_VTL = new System.Windows.Forms.GroupBox();
            this.dgv_VTL = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.grb_lstkcbn_VTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VTL)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_lstkcbn_VTL
            // 
            this.grb_lstkcbn_VTL.Controls.Add(this.dgv_VTL);
            this.grb_lstkcbn_VTL.Location = new System.Drawing.Point(13, 25);
            this.grb_lstkcbn_VTL.Name = "grb_lstkcbn_VTL";
            this.grb_lstkcbn_VTL.Size = new System.Drawing.Size(2037, 964);
            this.grb_lstkcbn_VTL.TabIndex = 0;
            this.grb_lstkcbn_VTL.TabStop = false;
            this.grb_lstkcbn_VTL.Text = "Lịch sử thăm khám của bệnh nhân";
            // 
            // dgv_VTL
            // 
            this.dgv_VTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_VTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_VTL.Location = new System.Drawing.Point(7, 38);
            this.dgv_VTL.Name = "dgv_VTL";
            this.dgv_VTL.RowHeadersWidth = 102;
            this.dgv_VTL.RowTemplate.Height = 40;
            this.dgv_VTL.Size = new System.Drawing.Size(2024, 908);
            this.dgv_VTL.TabIndex = 0;
            this.dgv_VTL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ngay_VTL";
            this.Column1.HeaderText = "Ngày tháng";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaBN_VTL";
            this.Column2.HeaderText = "Mã bệnh nhân";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DichVu_VTL";
            this.Column3.HeaderText = "Danh sách dịch vụ";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1739, 1026);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sổ khám bệnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2_VTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2086, 1113);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grb_lstkcbn_VTL);
            this.Name = "Form2_VTL";
            this.Text = "Chi tiết hợp đồng";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grb_lstkcbn_VTL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_lstkcbn_VTL;
        private System.Windows.Forms.DataGridView dgv_VTL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
    }
}