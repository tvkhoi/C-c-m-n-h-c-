namespace BTL_Csharp_vs1._0
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
            this.lbCode = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodeNcc = new System.Windows.Forms.TextBox();
            this.txtNameNcc = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPhoneNcc = new System.Windows.Forms.MaskedTextBox();
            this.btnInsertNcc = new System.Windows.Forms.Button();
            this.btnSelectNcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(204, 102);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(116, 16);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Mã Nhà Cung Cấp";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(204, 141);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(121, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên Nhà Cung Cấp";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(207, 178);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(92, 16);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Số Điện Thoại";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(207, 212);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(49, 16);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thêm Nhà Cung Cấp";
            // 
            // txtCodeNcc
            // 
            this.txtCodeNcc.Location = new System.Drawing.Point(393, 96);
            this.txtCodeNcc.Name = "txtCodeNcc";
            this.txtCodeNcc.Size = new System.Drawing.Size(178, 22);
            this.txtCodeNcc.TabIndex = 5;
            // 
            // txtNameNcc
            // 
            this.txtNameNcc.Location = new System.Drawing.Point(393, 135);
            this.txtNameNcc.Name = "txtNameNcc";
            this.txtNameNcc.Size = new System.Drawing.Size(178, 22);
            this.txtNameNcc.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(393, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 22);
            this.textBox3.TabIndex = 7;
            // 
            // txtPhoneNcc
            // 
            this.txtPhoneNcc.Location = new System.Drawing.Point(393, 172);
            this.txtPhoneNcc.Mask = "000.0000.000";
            this.txtPhoneNcc.Name = "txtPhoneNcc";
            this.txtPhoneNcc.Size = new System.Drawing.Size(178, 22);
            this.txtPhoneNcc.TabIndex = 8;
            // 
            // btnInsertNcc
            // 
            this.btnInsertNcc.Location = new System.Drawing.Point(238, 313);
            this.btnInsertNcc.Name = "btnInsertNcc";
            this.btnInsertNcc.Size = new System.Drawing.Size(82, 40);
            this.btnInsertNcc.TabIndex = 9;
            this.btnInsertNcc.Text = "Thêm";
            this.btnInsertNcc.UseVisualStyleBackColor = true;
            // 
            // btnSelectNcc
            // 
            this.btnSelectNcc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelectNcc.Location = new System.Drawing.Point(459, 313);
            this.btnSelectNcc.Name = "btnSelectNcc";
            this.btnSelectNcc.Size = new System.Drawing.Size(82, 40);
            this.btnSelectNcc.TabIndex = 10;
            this.btnSelectNcc.Text = "Xem";
            this.btnSelectNcc.UseVisualStyleBackColor = false;
            this.btnSelectNcc.Click += new System.EventHandler(this.btnSelectNcc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectNcc);
            this.Controls.Add(this.btnInsertNcc);
            this.Controls.Add(this.txtPhoneNcc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtNameNcc);
            this.Controls.Add(this.txtCodeNcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbCode);
            this.Name = "Form1";
            this.Text = "Insert Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodeNcc;
        private System.Windows.Forms.TextBox txtNameNcc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox txtPhoneNcc;
        private System.Windows.Forms.Button btnInsertNcc;
        private System.Windows.Forms.Button btnSelectNcc;
    }
}

