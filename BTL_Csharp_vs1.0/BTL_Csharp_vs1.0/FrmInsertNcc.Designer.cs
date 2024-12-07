namespace BTL_Csharp_vs1._0
{
    partial class FrmInsertNcc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodeNcc = new System.Windows.Forms.TextBox();
            this.txtNameNCC = new System.Windows.Forms.TextBox();
            this.txtAddressNcc = new System.Windows.Forms.TextBox();
            this.txtPhoneNcc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrvNcc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvNcc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodeNcc
            // 
            this.txtCodeNcc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeNcc.Location = new System.Drawing.Point(457, 186);
            this.txtCodeNcc.Name = "txtCodeNcc";
            this.txtCodeNcc.Size = new System.Drawing.Size(236, 27);
            this.txtCodeNcc.TabIndex = 0;
            // 
            // txtNameNCC
            // 
            this.txtNameNCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameNCC.Location = new System.Drawing.Point(457, 235);
            this.txtNameNCC.Name = "txtNameNCC";
            this.txtNameNCC.Size = new System.Drawing.Size(236, 27);
            this.txtNameNCC.TabIndex = 1;
            // 
            // txtAddressNcc
            // 
            this.txtAddressNcc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressNcc.Location = new System.Drawing.Point(924, 240);
            this.txtAddressNcc.Name = "txtAddressNcc";
            this.txtAddressNcc.Size = new System.Drawing.Size(236, 27);
            this.txtAddressNcc.TabIndex = 2;
            // 
            // txtPhoneNcc
            // 
            this.txtPhoneNcc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNcc.Location = new System.Drawing.Point(924, 186);
            this.txtPhoneNcc.Mask = "000.0000.000";
            this.txtPhoneNcc.Name = "txtPhoneNcc";
            this.txtPhoneNcc.Size = new System.Drawing.Size(236, 27);
            this.txtPhoneNcc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(774, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(774, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(654, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // bntInsert
            // 
            this.bntInsert.Location = new System.Drawing.Point(463, 343);
            this.bntInsert.Name = "bntInsert";
            this.bntInsert.Size = new System.Drawing.Size(105, 38);
            this.bntInsert.TabIndex = 9;
            this.bntInsert.Text = "Thêm";
            this.bntInsert.UseVisualStyleBackColor = true;
            this.bntInsert.Click += new System.EventHandler(this.bntInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(683, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 38);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(938, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 38);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-116, -171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1787, 274);
            this.panel1.TabIndex = 14;
            // 
            // GrvNcc
            // 
            this.GrvNcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrvNcc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.GrvNcc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrvNcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrvNcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvNcc.Location = new System.Drawing.Point(103, 413);
            this.GrvNcc.Name = "GrvNcc";
            this.GrvNcc.RowHeadersWidth = 51;
            this.GrvNcc.RowTemplate.Height = 24;
            this.GrvNcc.Size = new System.Drawing.Size(1281, 331);
            this.GrvNcc.TabIndex = 15;
            this.GrvNcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.GrvNcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmInsertNcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 756);
            this.Controls.Add(this.GrvNcc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.bntInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhoneNcc);
            this.Controls.Add(this.txtAddressNcc);
            this.Controls.Add(this.txtNameNCC);
            this.Controls.Add(this.txtCodeNcc);
            this.Name = "FrmInsertNcc";
            this.Text = "Thêm Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.FrmInsertNcc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvNcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodeNcc;
        private System.Windows.Forms.TextBox txtNameNCC;
        private System.Windows.Forms.TextBox txtAddressNcc;
        private System.Windows.Forms.MaskedTextBox txtPhoneNcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GrvNcc;
    }
}