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
    public partial class Form1 : Form
    {
        private IClassChuyenDuLieu _classChuyenDuLieu;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(IClassChuyenDuLieu classChuyenDuLieu)
        {
            this._classChuyenDuLieu = classChuyenDuLieu;
            InitializeComponent();
        }
        public void NhanDuLieu(string text)
        {
            lb_nhandulieu.Text = text;
        }

        private void btn_ChuyendulieulenTrangChu_Click(object sender, EventArgs e)
        {
            try
            {
                _classChuyenDuLieu.ChuyenDuLieu(tb_nhapdulieu.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
            
        }
    }
}
