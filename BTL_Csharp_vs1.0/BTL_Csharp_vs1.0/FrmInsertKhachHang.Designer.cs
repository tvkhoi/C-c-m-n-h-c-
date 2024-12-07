namespace BTL_Csharp_vs1._0
{
    partial class FrmInsertKhachHang
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
            this.label8 = new System.Windows.Forms.Label();
            this.GT_Nu = new System.Windows.Forms.RadioButton();
            this.GT_Nam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneKH = new System.Windows.Forms.MaskedTextBox();
            this.txtAddressKH = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.txtCodeKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(277, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = "Giới Tính";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // GT_Nu
            // 
            this.GT_Nu.AutoSize = true;
            this.GT_Nu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GT_Nu.Location = new System.Drawing.Point(565, 254);
            this.GT_Nu.Name = "GT_Nu";
            this.GT_Nu.Size = new System.Drawing.Size(51, 23);
            this.GT_Nu.TabIndex = 57;
            this.GT_Nu.TabStop = true;
            this.GT_Nu.Text = "Nữ";
            this.GT_Nu.UseVisualStyleBackColor = true;
            this.GT_Nu.CheckedChanged += new System.EventHandler(this.GT_Nu_CheckedChanged);
            // 
            // GT_Nam
            // 
            this.GT_Nam.AutoSize = true;
            this.GT_Nam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GT_Nam.Location = new System.Drawing.Point(477, 254);
            this.GT_Nam.Name = "GT_Nam";
            this.GT_Nam.Size = new System.Drawing.Size(62, 23);
            this.GT_Nam.TabIndex = 56;
            this.GT_Nam.TabStop = true;
            this.GT_Nam.Text = "Nam";
            this.GT_Nam.UseVisualStyleBackColor = true;
            this.GT_Nam.CheckedChanged += new System.EventHandler(this.GT_Nam_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(781, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(781, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Số Điện Thoại";
            // 
            // txtPhoneKH
            // 
            this.txtPhoneKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhoneKH.Location = new System.Drawing.Point(916, 142);
            this.txtPhoneKH.Mask = "000.0000.000";
            this.txtPhoneKH.Name = "txtPhoneKH";
            this.txtPhoneKH.Size = new System.Drawing.Size(223, 27);
            this.txtPhoneKH.TabIndex = 53;
            // 
            // txtAddressKH
            // 
            this.txtAddressKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAddressKH.Location = new System.Drawing.Point(916, 200);
            this.txtAddressKH.Name = "txtAddressKH";
            this.txtAddressKH.Size = new System.Drawing.Size(223, 27);
            this.txtAddressKH.TabIndex = 52;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 344);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 46);
            this.button3.TabIndex = 51;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(812, 344);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 46);
            this.button2.TabIndex = 50;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 408);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 373);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 48;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNameKH
            // 
            this.txtNameKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameKH.Location = new System.Drawing.Point(468, 198);
            this.txtNameKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(223, 27);
            this.txtNameKH.TabIndex = 46;
            this.txtNameKH.TextChanged += new System.EventHandler(this.txtNameKH_TextChanged);
            // 
            // txtCodeKH
            // 
            this.txtCodeKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCodeKH.Location = new System.Drawing.Point(468, 145);
            this.txtCodeKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodeKH.Name = "txtCodeKH";
            this.txtCodeKH.Size = new System.Drawing.Size(223, 27);
            this.txtCodeKH.TabIndex = 45;
            this.txtCodeKH.TextChanged += new System.EventHandler(this.txtCodeKH_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(277, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tên Khách Hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(277, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(622, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 38);
            this.label6.TabIndex = 40;
            this.label6.Text = "Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-28, -41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1463, 126);
            this.panel2.TabIndex = 59;
            // 
            // FrmInsertKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 792);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GT_Nu);
            this.Controls.Add(this.GT_Nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneKH);
            this.Controls.Add(this.txtAddressKH);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNameKH);
            this.Controls.Add(this.txtCodeKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmInsertKhachHang";
            this.Text = "FrmInsertKhachHang";
            this.Load += new System.EventHandler(this.FrmInsertKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton GT_Nu;
        private System.Windows.Forms.RadioButton GT_Nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtPhoneKH;
        private System.Windows.Forms.TextBox txtAddressKH;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNameKH;
        private System.Windows.Forms.TextBox txtCodeKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}