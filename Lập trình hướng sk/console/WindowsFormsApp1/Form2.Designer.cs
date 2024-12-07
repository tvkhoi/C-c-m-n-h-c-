namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label_hovaten = new System.Windows.Forms.Label();
            this.textBox_hovaten = new System.Windows.Forms.TextBox();
            this.label_gioitinh = new System.Windows.Forms.Label();
            this.textBox_gioitinh = new System.Windows.Forms.TextBox();
            this.listView_dsSV = new System.Windows.Forms.ListView();
            this.button_them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_hovaten
            // 
            this.label_hovaten.AutoSize = true;
            this.label_hovaten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_hovaten.Location = new System.Drawing.Point(98, 53);
            this.label_hovaten.Name = "label_hovaten";
            this.label_hovaten.Size = new System.Drawing.Size(72, 18);
            this.label_hovaten.TabIndex = 0;
            this.label_hovaten.Text = "Họ và tên :";
            // 
            // textBox_hovaten
            // 
            this.textBox_hovaten.Location = new System.Drawing.Point(203, 49);
            this.textBox_hovaten.Name = "textBox_hovaten";
            this.textBox_hovaten.Size = new System.Drawing.Size(198, 22);
            this.textBox_hovaten.TabIndex = 1;
            // 
            // label_gioitinh
            // 
            this.label_gioitinh.AutoSize = true;
            this.label_gioitinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_gioitinh.Location = new System.Drawing.Point(98, 96);
            this.label_gioitinh.Name = "label_gioitinh";
            this.label_gioitinh.Size = new System.Drawing.Size(62, 18);
            this.label_gioitinh.TabIndex = 2;
            this.label_gioitinh.Text = "Giới tính :";
            // 
            // textBox_gioitinh
            // 
            this.textBox_gioitinh.Location = new System.Drawing.Point(202, 89);
            this.textBox_gioitinh.Name = "textBox_gioitinh";
            this.textBox_gioitinh.Size = new System.Drawing.Size(199, 22);
            this.textBox_gioitinh.TabIndex = 3;
            // 
            // listView_dsSV
            // 
            this.listView_dsSV.HideSelection = false;
            this.listView_dsSV.Location = new System.Drawing.Point(332, 214);
            this.listView_dsSV.Name = "listView_dsSV";
            this.listView_dsSV.Size = new System.Drawing.Size(419, 211);
            this.listView_dsSV.TabIndex = 4;
            this.listView_dsSV.UseCompatibleStateImageBehavior = false;
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(98, 214);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 23);
            this.button_them.TabIndex = 5;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.listView_dsSV);
            this.Controls.Add(this.textBox_gioitinh);
            this.Controls.Add(this.label_gioitinh);
            this.Controls.Add(this.textBox_hovaten);
            this.Controls.Add(this.label_hovaten);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hovaten;
        private System.Windows.Forms.TextBox textBox_hovaten;
        private System.Windows.Forms.Label label_gioitinh;
        private System.Windows.Forms.TextBox textBox_gioitinh;
        private System.Windows.Forms.ListView listView_dsSV;
        private System.Windows.Forms.Button button_them;
    }
}