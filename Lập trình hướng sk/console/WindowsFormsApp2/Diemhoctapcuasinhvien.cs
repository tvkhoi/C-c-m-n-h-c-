using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Diemhoctapcuasinhvien : Form
    {
        
        ErrorProvider error = new ErrorProvider();
        public Diemhoctapcuasinhvien()
        {
            InitializeComponent();
            button_tiep_tuc.Enabled = false;
            button_tinh_diem.Enabled = false;
            
            comboBox_lophanh_chinh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_mon_hoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_hovaten_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_hovaten.Text))
            {
                //e.Cancel = true;
                error.SetError(textBox_hovaten, "Họ và tên không được để trống");
            }
            else
            {
                e.Cancel= false;
                error.SetError(textBox_hovaten, null);
            }
            dieu_kien_tieptuc();
        }

        private void radioButton_ctdt_2017_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_ctdt_2017.Checked==true)
            {
                // Sử lý dữ liệu cho môn học và lớp hành chính
                comboBox_mon_hoc.Text = "";
                comboBox_mon_hoc.Items.Clear();
                comboBox_mon_hoc.Items.Add("An ninh mạng");
                comboBox_mon_hoc.Items.Add("Kiến trúc mày tính");
                comboBox_mon_hoc.Items.Add("Quản trị mạng");
                comboBox_mon_hoc.Items.Add("Phân tích và thiết kế hệ thống thông tin");

                comboBox_lophanh_chinh.Text = "";
                comboBox_lophanh_chinh.Items.Clear();
                comboBox_lophanh_chinh.Items.Add("2210A01");
                comboBox_lophanh_chinh.Items.Add("2210A02");
                comboBox_lophanh_chinh.Items.Add("2210A03");
                comboBox_lophanh_chinh.Items.Add("2210A04");
                comboBox_lophanh_chinh.Items.Add("2210A05");
                comboBox_lophanh_chinh.Items.Add("2210A06");

            }
            dieu_kien_tieptuc();
            dieu_kien_tinhdiem();
        }

        private void radioButton_ctdt_2022_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ctdt_2022.Checked == true)
            {
                // Sử lý dữ liệu cho môn học và lớp hành chính
                comboBox_mon_hoc.Text = "";
                comboBox_mon_hoc.Items.Clear();
                comboBox_mon_hoc.Items.Add("Khai phá dữ liệu và máy học");
                comboBox_mon_hoc.Items.Add("Đánh giá hiệu năng mạng máy tính");
                comboBox_mon_hoc.Items.Add("Phát triển ứng dụng vạn vật kết nối");
                comboBox_mon_hoc.Items.Add("Xứ lý dữ liệu lớn");

                comboBox_lophanh_chinh.Text = "";
                comboBox_lophanh_chinh.Items.Clear();
                comboBox_lophanh_chinh.Items.Add("2210A01");
                comboBox_lophanh_chinh.Items.Add("2210A02");
                comboBox_lophanh_chinh.Items.Add("2210A03");
                comboBox_lophanh_chinh.Items.Add("2210A04");
                comboBox_lophanh_chinh.Items.Add("2210A05");
                comboBox_lophanh_chinh.Items.Add("2210A06");

            }
            dieu_kien_tieptuc();
            dieu_kien_tinhdiem();
        }

        private void textBox_diemchuyencan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_diemchuyencan_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(textBox_diemchuyencan.Text.Trim()) < 0 || int.Parse(textBox_diemchuyencan.Text.Trim()) > 10)
            {
                error.SetError(textBox_diemchuyencan, "Điểm không thỏa mãn từ 1 - 10");
            }


        }

        private void textBox_diem_giua_ky_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&& (e.KeyChar!='.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        public void dieu_kien_tieptuc()
        {
            if(textBox_hovaten.Text.Trim()!="" && 
                (radioButton_ctdt_2017.Checked==true||radioButton_ctdt_2022.Checked==true)
                && !string.IsNullOrEmpty(comboBox_mon_hoc.Text) 
                && !string.IsNullOrEmpty(comboBox_lophanh_chinh.Text)) {

                button_tiep_tuc.Enabled = true;
            } 
            else
            {
                button_tiep_tuc.Enabled =false;
            }
        }

        private void comboBox_mon_hoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dieu_kien_tieptuc();
            dieu_kien_tinhdiem();
        }

        private void comboBox_lophanh_chinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            dieu_kien_tieptuc();
            dieu_kien_tinhdiem();
        }

        private void textBox_diemchuyencan_TextChanged_1(object sender, EventArgs e)
        {
              int diemcheck;
              if (int.TryParse(textBox_diemchuyencan.Text, out diemcheck))
             {
                 if (diemcheck < 0 || diemcheck > 10)
                 {
                    textBox_diemchuyencan.Text = string.Empty;
                }
              else
              {
                   textBox_diemchuyencan.Text = diemcheck.ToString();
               }

             }
          
           
            dieu_kien_tinhdiem();
        }

        private void textBox_diem_giua_ky_TextChanged(object sender, EventArgs e)
        {
            int diemcheck;
            if (int.TryParse(textBox_diem_giua_ky.Text, out diemcheck))
            {
                if (diemcheck < 0 || diemcheck > 10)
                {
                    textBox_diem_giua_ky.Text = string.Empty;
                }
                else
                {
                    textBox_diem_giua_ky.Text = diemcheck.ToString();
                }
            }
            dieu_kien_tinhdiem();
        }

        private void textBox_diem_cuoi_ky_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_diem_cuoi_ky_TextChanged(object sender, EventArgs e)
        {
            int diemcheck;
            if (int.TryParse(textBox_diem_cuoi_ky.Text, out diemcheck))
            {
                if (diemcheck < 0 || diemcheck > 10)
                {
                    textBox_diem_cuoi_ky.Text = string.Empty;
                }
                else
                {
                    textBox_diem_cuoi_ky.Text = diemcheck.ToString();
                }
            }
            dieu_kien_tinhdiem();
        }

        private void button_tiep_tuc_Click(object sender, EventArgs e)
        {
          textBox_diem_cuoi_ky.Text = "";
          textBox_diem_giua_ky.Text = "";
          textBox_diemchuyencan.Text = "";
          comboBox_lophanh_chinh.Text = "";
          comboBox_mon_hoc.Text = "";
          button_tiep_tuc.Enabled = true;
          button_tinh_diem.Enabled = false;

        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_tinh_diem_Click(object sender, EventArgs e)
        {
            listBox_ketqua.Items.Clear();
           // comboBox_mon_hoc.Items.RemoveAt(com)
            double dcc = double.Parse(textBox_diemchuyencan.Text);
            double dgk = double.Parse(textBox_diem_giua_ky.Text);
            double dck = double.Parse(textBox_diem_cuoi_ky.Text);
            double diem = (0.1 * dcc) + (0.2 * dgk) + (dck * 0.7);
            listBox_ketqua.Items.Add("Tên sinh viên: "+textBox_hovaten.Text);
            listBox_ketqua.Items.Add("Lớp hành chính: "+comboBox_lophanh_chinh.Text);
            listBox_ketqua.Items.Add("Môn học: "+comboBox_mon_hoc.Text);
            listBox_ketqua.Items.Add("Điểm: "+ diem);
        }
        public void dieu_kien_tinhdiem()
        {
            if (textBox_hovaten.Text.Trim() != "" &&
                (radioButton_ctdt_2017.Checked == true || radioButton_ctdt_2022.Checked == true)
                && !string.IsNullOrEmpty(comboBox_mon_hoc.Text)
                && !string.IsNullOrEmpty(comboBox_lophanh_chinh.Text)&&
                !string.IsNullOrEmpty(textBox_diemchuyencan.Text)&&
                !string.IsNullOrEmpty(textBox_diem_giua_ky.Text)&&
                !string.IsNullOrEmpty(textBox_diem_cuoi_ky.Text))
            {

                button_tinh_diem.Enabled = true;
            }
            else
            {
                button_tinh_diem.Enabled = false;
            }
        }

        private void textBox_hovaten_TextChanged(object sender, EventArgs e)
        {
            dieu_kien_tinhdiem();
            dieu_kien_tieptuc();
        }

        private void radioButton_ctdt_2017_Validating(object sender, CancelEventArgs e)
        {
           
        }
    }
}
