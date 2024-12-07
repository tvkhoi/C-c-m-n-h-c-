using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            var hovate = textBox_hovaten.Text;
            var gioitinh = textBox_gioitinh.Text;

            if(hovate==""&&gioitinh =="")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                listView_dsSV.Items.Add(hovate);
                listView_dsSV.Items.Add((string)gioitinh);
                textBox_hovaten.Text = "";
                textBox_gioitinh.Text = "";
            }
            
        }
    }
}
