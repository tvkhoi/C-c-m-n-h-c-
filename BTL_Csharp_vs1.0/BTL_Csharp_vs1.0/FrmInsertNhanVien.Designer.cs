﻿namespace BTL_Csharp_vs1._0
{
    partial class FrmInsertNhanVien
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
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.MaskedTextBox();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.txtCodeNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneNv = new System.Windows.Forms.MaskedTextBox();
            this.txtAddressNv = new System.Windows.Forms.TextBox();
            this.GT_Nam = new System.Windows.Forms.RadioButton();
            this.GT_Nu = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Birthday = new System.Windows.Forms.MaskedTextBox();
            this.txt_day_of_work = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(435, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nhân Viên";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 512);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(527, 115);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 373);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(197, 442);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(223, 22);
            this.txtCCCD.TabIndex = 24;
            // 
            // txtNameNV
            // 
            this.txtNameNV.Location = new System.Drawing.Point(197, 160);
            this.txtNameNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(223, 22);
            this.txtNameNV.TabIndex = 22;
            // 
            // txtCodeNV
            // 
            this.txtCodeNV.Location = new System.Drawing.Point(197, 115);
            this.txtCodeNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodeNV.Name = "txtCodeNV";
            this.txtCodeNV.Size = new System.Drawing.Size(223, 22);
            this.txtCodeNV.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số Căn Cước";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Số Điện Thoại";
            // 
            // txtPhoneNv
            // 
            this.txtPhoneNv.Location = new System.Drawing.Point(197, 352);
            this.txtPhoneNv.Mask = "000.0000.000";
            this.txtPhoneNv.Name = "txtPhoneNv";
            this.txtPhoneNv.Size = new System.Drawing.Size(223, 22);
            this.txtPhoneNv.TabIndex = 31;
            // 
            // txtAddressNv
            // 
            this.txtAddressNv.Location = new System.Drawing.Point(197, 396);
            this.txtAddressNv.Name = "txtAddressNv";
            this.txtAddressNv.Size = new System.Drawing.Size(223, 22);
            this.txtAddressNv.TabIndex = 30;
            // 
            // GT_Nam
            // 
            this.GT_Nam.AutoSize = true;
            this.GT_Nam.Location = new System.Drawing.Point(200, 212);
            this.GT_Nam.Name = "GT_Nam";
            this.GT_Nam.Size = new System.Drawing.Size(57, 20);
            this.GT_Nam.TabIndex = 34;
            this.GT_Nam.TabStop = true;
            this.GT_Nam.Text = "Nam";
            this.GT_Nam.UseVisualStyleBackColor = true;
            // 
            // GT_Nu
            // 
            this.GT_Nu.AutoSize = true;
            this.GT_Nu.Location = new System.Drawing.Point(288, 212);
            this.GT_Nu.Name = "GT_Nu";
            this.GT_Nu.Size = new System.Drawing.Size(45, 20);
            this.GT_Nu.TabIndex = 35;
            this.GT_Nu.TabStop = true;
            this.GT_Nu.Text = "Nữ";
            this.GT_Nu.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Giới Tính";
            // 
            // txt_Birthday
            // 
            this.txt_Birthday.Location = new System.Drawing.Point(200, 251);
            this.txt_Birthday.Mask = "00/00/0000";
            this.txt_Birthday.Name = "txt_Birthday";
            this.txt_Birthday.Size = new System.Drawing.Size(220, 22);
            this.txt_Birthday.TabIndex = 37;
            this.txt_Birthday.ValidatingType = typeof(System.DateTime);
            // 
            // txt_day_of_work
            // 
            this.txt_day_of_work.Location = new System.Drawing.Point(200, 301);
            this.txt_day_of_work.Mask = "00/00/0000";
            this.txt_day_of_work.Name = "txt_day_of_work";
            this.txt_day_of_work.Size = new System.Drawing.Size(220, 22);
            this.txt_day_of_work.TabIndex = 38;
            this.txt_day_of_work.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ngày Vào Làm";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 481);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 22);
            this.txtEmail.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Email";
            // 
            // FrmInsertNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 676);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_day_of_work);
            this.Controls.Add(this.txt_Birthday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GT_Nu);
            this.Controls.Add(this.GT_Nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneNv);
            this.Controls.Add(this.txtAddressNv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtNameNV);
            this.Controls.Add(this.txtCodeNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "FrmInsertNhanVien";
            this.Text = "FrmInsertNhanVien";
            this.Load += new System.EventHandler(this.FrmInsertNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNameNV;
        private System.Windows.Forms.TextBox txtCodeNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtPhoneNv;
        private System.Windows.Forms.TextBox txtAddressNv;
        private System.Windows.Forms.RadioButton GT_Nam;
        private System.Windows.Forms.RadioButton GT_Nu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_Birthday;
        private System.Windows.Forms.MaskedTextBox txt_day_of_work;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Label label10;
    }
}