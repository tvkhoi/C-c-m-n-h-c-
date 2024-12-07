using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoChuyenDuLieu
{
    public partial class TrangChu : Form, IClassChuyenDuLieu
    {
        private string _text;
        public TrangChu()
        {
            InitializeComponent();
        }

        public void ChuyenDuLieu(string text)
        {
            if(text == null)
            {
                lb_nhandulieu.Text = "";
            }
            else
            {
                _text += text;
                lb_nhandulieu.Text = "" + _text;
            }
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.NhanDuLieu(tb_nhaplieu.Text);
            form1.Show();

        }

        private void openForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
