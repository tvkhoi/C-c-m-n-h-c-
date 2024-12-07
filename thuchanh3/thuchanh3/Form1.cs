using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_chon.Enabled = false;
            btn_tieptuc.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string a = "";
        string c = "";
        int q1 = 0;
        int q2 = 0;
        int q3 = 0;
        int q4 = 0;
        int q5 = 0;
        private void cmb_chondichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_chondichvu.SelectedIndex < 0)
            {
                err.SetError(cmb_chondichvu, "Dịch vụ không được để trống!");
                q5 = 0;
            }
            else
            {
                err.SetError(cmb_chondichvu, null);
                a += $"{cmb_chondichvu.SelectedItem.ToString()}\r\n";
                txt_danhsachdichvu.Text = a;
                c += $"{cmb_chondichvu.SelectedItem.ToString()}.";
                q5 = 1;
            }
            dieukien();
            dieukien1();
        }
        string b = "";
        private void btn_chon_Click(object sender, EventArgs e)
        {
            if (b.Contains(txt_tenbenhnhan.Text.Trim().ToString()))
            {
                b = "";
                b += $"Tên bệnh nhân: {txt_tenbenhnhan.Text}\r\n";
                b += $"Ngày khám: {txt_ngay.Text}/{txt_thang.Text}/{txt_nam.Text}\r\n";
                b += $"Dịch vụ khám: {c}";
                txt_ketqua.Text = b;
            }
            else
            {
                b += $"Tên bệnh nhân: {txt_tenbenhnhan.Text}\r\n";
                b += $"Ngày khám: {txt_ngay.Text}/{txt_thang.Text}/{txt_nam.Text}\r\n";
                b += $"Dịch vụ khám: {c}";
                txt_ketqua.Text = b;
            }
        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            c = "";
            b += "\r\n\r\n";
            a = "";
            txt_tenbenhnhan.Clear();
            txt_ngay.Clear();
            txt_thang.Clear();
            txt_nam.Clear();           
            txt_danhsachdichvu.Clear();
            txt_ketqua.Clear();
            int g = cmb_chondichvu.Items.Count;
            for (int i = 0; i < g; i++)
            {              
                if (cmb_chondichvu.SelectedIndex == i)
                {                         
                    string c = cmb_chondichvu.SelectedItem.ToString();
                    cmb_chondichvu.Items.RemoveAt(i);
                    cmb_chondichvu.Items.Insert(i, c);
                }
            }
            q1 = 0; q2 = 0; q3 = 0;q4= 0;q5 = 0;
            btn_tieptuc.Enabled = false;
            btn_chon.Enabled = false;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ngay_TextChanged(object sender, EventArgs e)
        {
            if (txt_ngay.Text.ToString() != "")
            {
                try
                {
                    int l=0;
                    l = Convert.ToInt32(txt_ngay.Text.ToString());
                }
                catch(Exception) {
                    MessageBox.Show("Phải nhập bằng số");
                    return;
                }
                
                if (Convert.ToInt32(txt_ngay.Text.ToString()) > 31)
                {
                    err.SetError(txt_ngay, "Ngày phải nhỏ hơn hoặc bằng 31");
                }           
                else
                {
                    q4 = 1;
                    err.SetError(txt_ngay, null);
                }
                dieukien();
                dieukien1();
            }
            else
            {
                err.SetError(txt_ngay, "Ngày không được để trống!");
                q4 = 0;
            }
        }

        private void txt_thang_TextChanged(object sender, EventArgs e)
        {
            if (txt_thang.Text.ToString() != "")
            {
                try
                {
                    int l = 0;
                    l = Convert.ToInt32(txt_thang.Text.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Phải nhập bằng số");
                    return;
                }
                if (Convert.ToInt32(txt_thang.Text.ToString()) > 12)
                {
                    err.SetError(txt_thang, "Tháng phải nhỏ hơn hoặc bằng 12");
                }                
                else
                {
                    q3 = 1;
                    err.SetError(txt_thang, null);
                }
                dieukien();
                dieukien1();
            }
            else
            {
                err.SetError(txt_thang, "Tháng không được để trống!");
                q3 = 0;
            }
        }

        private void txt_nam_TextChanged(object sender, EventArgs e)
        {
            if (txt_nam.Text.ToString() != "")
            {
                try
                {
                    int l = 0;
                    l = Convert.ToInt32(txt_nam.Text.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Phải nhập bằng số");
                    return;
                }                
                 if (Convert.ToInt32(txt_nam.Text.ToString()) > DateTime.Now.Year)
                {
                    err.SetError(txt_nam, "Năm phải nhỏ hơn hoặc bằng năm hiện tại");
                }                
                else
                {
                    q2 = 1;
                    err.SetError(txt_nam, null);
                }
                dieukien();
                dieukien1();
            }
            else
            {
                err.SetError(txt_nam, "Năm không được để trống!");
                q2 = 0;
            }
        }
        private void txt_tenbenhnhan_TextChanged(object sender, EventArgs e)
        {                     
                if (txt_tenbenhnhan.Text.Trim().ToString() == "")
                {
                    err.SetError(txt_tenbenhnhan, "Tên bệnh nhân không được để trống!");
                    q1 = 0;          
                }
                else
                {
                    q1 = 1;
                    err.SetError(txt_tenbenhnhan, null);
                }
                dieukien();
                dieukien1();
        }
        private void dieukien()
        {
            if(q5 == 1 && q4==1&& q3 == 1 && q2 == 1 && q1 == 1) 
            { 
                btn_chon.Enabled = true;
            }
            else
            {
                btn_chon.Enabled = false;
            }
        }
        private void dieukien1()
        {
            if (q5 == 1 && q4 == 1 && q3 == 1 && q2 == 1 && q1 == 1)
            {
                btn_tieptuc.Enabled = true;
            }
            else
            {
                btn_tieptuc.Enabled = false;
            }
        }
    }
}
