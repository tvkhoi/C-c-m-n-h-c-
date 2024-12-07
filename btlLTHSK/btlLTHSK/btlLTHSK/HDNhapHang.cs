using btlLTHSK.Cry;
using btlLTHSK.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlLTHSK
{
    public partial class HDNhapHang : Form
    {
       ErrorProvider error = new ErrorProvider();
       HoadonNhapcs01 hdnhap = new HoadonNhapcs01();
        public HDNhapHang()
        {
            InitializeComponent();
        }
        private void textBox_MaHDNhap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()))
            {
                error.SetError(textBox_MaHDNhap, "Mã hóa đơn không được để trống!");
            }
            else
            {
                error.SetError(textBox_MaHDNhap, null);
            }
        }

        private void comboBox_MaNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_MaNV.Text.Trim()))
            {
                error.SetError(comboBox_MaNV, "Mã nhân viên không được để trống!");
            }
            else
            {
                error.SetError(comboBox_MaNV, null);
            }
        }

        private void comboBox_NhaCC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_NhaCC.Text.Trim()))
            {
                error.SetError(comboBox_NhaCC, "Mã nhà cung cấp không được để trống!");
            }
            else
            {
                error.SetError(comboBox_NhaCC, null);
            }
        }

        private void dateTimePicker_NgayNhap_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayhientai = DateTime.Now;
            DateTime ngay_nhap = dateTimePicker_NgayNhap.Value;

            if (ngay_nhap.Date > ngayhientai.Date)
            {
                error.SetError(dateTimePicker_NgayNhap, "Ngày nhập không được lớn hơn ngày hiện tại!");
            }
            else
            {
                error.SetError(dateTimePicker_NgayNhap, null);
            }

        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            CancelEventArgs cancelEvent = new CancelEventArgs();
            textBox_MaHDNhap_Validating(sender, cancelEvent);
            comboBox_MaNV_Validating(sender, cancelEvent);
            comboBox_NhaCC_Validating(sender, cancelEvent);
            dateTimePicker_NgayNhap_Validating(sender, cancelEvent);
            DateTime ngayhientai = DateTime.Now;
            DateTime ngay_nhap = dateTimePicker_NgayNhap.Value;

            DateTime dateTime = Convert.ToDateTime(dateTimePicker_NgayNhap.Text);
            string ngaynhap = dateTime.ToString("yyyy/MM/dd");

            if (!string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim())&& ngay_nhap < ngayhientai
                && !string.IsNullOrEmpty(comboBox_MaNV.Text.Trim())&& !string.IsNullOrEmpty(comboBox_NhaCC.Text.Trim())) { 
                if(hdnhap.kiemtratontai(int.Parse(textBox_MaHDNhap.Text.Trim()))==false) { 
                    if(hdnhap.them_HoaDon_PhieuNhap(int.Parse(textBox_MaHDNhap.Text.Trim()),comboBox_MaNV.Text.Trim(),comboBox_NhaCC.Text.Trim(),ngaynhap)==true)
                    {
                        MessageBox.Show("Thêm thành công");
                        error.SetError(textBox_MaHDNhap, null);
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                    error.SetError(textBox_MaHDNhap, "Mã hóa đơn này đã tồn tại");
                }
            }
            dataGridView_HoaDonPN.Rows.Clear();
            hdnhap.hien_HoaDonPN(dataGridView_HoaDonPN);
        }

        private void HDNhapHang_Load(object sender, EventArgs e)
        {
            hdnhap.hien_HoaDonPN(dataGridView_HoaDonPN);
            hdnhap.uploadComboBox(comboBox_MaNV,comboBox_NhaCC);
        }

        private void textBox_MaHDNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải số hoặc vượt quá 10 số
            }
        }

        private void comboBox_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void comboBox_NhaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView_HoaDonPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_HoaDonPN.ClearSelection();
            }

            if (e.RowIndex >= 0 && (e.ColumnIndex >= 0 && e.ColumnIndex <=4))
            {
                DataGridViewCell dataGridViewCell = dataGridView_HoaDonPN[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    error.SetError(textBox_MaHDNhap, null);
                    DataGridViewRow row = dataGridView_HoaDonPN.Rows[e.RowIndex];
                    textBox_MaHDNhap.Text = row.Cells[0].Value.ToString();
                    comboBox_MaNV.Text = row.Cells[1].Value.ToString();
                    comboBox_NhaCC.Text = row.Cells[2].Value.ToString();
                    dateTimePicker_NgayNhap.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }

            }
            // Kiểm tra nếu cell được click thuộc vào cột số 4
            if (e.ColumnIndex == 4)
            {
                // Kiểm tra nếu giá trị ô không phải là null
                if (dataGridView_HoaDonPN.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ChiTietNhap chiTietNhap = new ChiTietNhap(int.Parse(textBox_MaHDNhap.Text.Trim()),0);
                    chiTietNhap.Show();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }
            }
        }

        private void button_Xua_Click(object sender, EventArgs e)
        {
            DateTime ngayhientai = DateTime.Now;
            DateTime ngay_nhap = dateTimePicker_NgayNhap.Value;

            DateTime dateTime = Convert.ToDateTime(dateTimePicker_NgayNhap.Text);
            string ngaynhap = dateTime.ToString("yyyy/MM/dd");

            if (!string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()) && ngay_nhap < ngayhientai
                && !string.IsNullOrEmpty(comboBox_MaNV.Text.Trim()) && !string.IsNullOrEmpty(comboBox_NhaCC.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (hdnhap.update_HoaDon_PhieuNhap(int.Parse(textBox_MaHDNhap.Text.Trim()), comboBox_MaNV.Text.Trim(), comboBox_NhaCC.Text.Trim(), ngaynhap) == true)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            dataGridView_HoaDonPN.Rows.Clear();
            hdnhap.hien_HoaDonPN(dataGridView_HoaDonPN);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            DateTime ngayhientai = DateTime.Now;
            DateTime ngay_nhap = dateTimePicker_NgayNhap.Value;


            if (!string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()) && ngay_nhap < ngayhientai
                && !string.IsNullOrEmpty(comboBox_MaNV.Text.Trim()) && !string.IsNullOrEmpty(comboBox_NhaCC.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (hdnhap.xoa_HD_PhieuNhap(int.Parse(textBox_MaHDNhap.Text.Trim())) == true)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            dataGridView_HoaDonPN.Rows.Clear();
            hdnhap.hien_HoaDonPN(dataGridView_HoaDonPN);
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string texbox_tk = comboBox_Chon_Timkiem.Items[comboBox_Chon_Timkiem.SelectedIndex].ToString();

            if (texbox_tk == "Mã nhân viên")
            {
                hdnhap.search_HD_Nhap_duavaoMaNV(textBox_TimKiem.Text, dataGridView_HoaDonPN);
            }
            else if (texbox_tk == "Mã nhà cung cấp")
            {
                hdnhap.search_HD_Nhap_duavaoMaNCC(textBox_TimKiem.Text, dataGridView_HoaDonPN);
            }
        }

        private void button_InHD_HDNhap_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "tim_kiem_Ma_NCC";
                    command.Parameters.AddWithValue("@sMaNCC", comboBox_NhaCC.Text.Trim());
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        Hoadon_nhap_theo_maNCC cry = new Hoadon_nhap_theo_maNCC();
                        cry.SetDataSource(dt);
                        BaoCao baocao = new BaoCao();
                        baocao.crystalReportViewer_baocao.ReportSource = cry;
                        baocao.Show();
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_timkiem_sl_banghi_TextChanged(object sender, EventArgs e)
        {
          

            
        }

        private void button_tim_sl_Click(object sender, EventArgs e)
        {
            string texbox_tk = textBox_timkiem_sl_banghi.Text.ToString();
            int soluong =   hdnhap.search_HD_Nhap_duavaoMaNCC_sl(textBox_timkiem_sl_banghi.Text.ToString(), dataGridView_HoaDonPN);
            MessageBox.Show("Số lượng bản ghi: " + soluong, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texbox_tk = cbo.Items[cbo.SelectedIndex].ToString();

            if (texbox_tk == "Mã NCC")
            {
                hdnhap.search_HD_Nhap_duavaoMaNV(textBox_TimKiem.Text, dataGridView_HoaDonPN);
            }
            else if (texbox_tk == "Mã nhà cung cấp")
            {
                hdnhap.search_HD_Nhap_duavaoMaNCC(textBox_TimKiem.Text, dataGridView_HoaDonPN);
            }
            string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "tim_kiem_Ma_NCC";
                    command.Parameters.AddWithValue("@sMaNCC", comboBox_NhaCC.Text.Trim());
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        Hoadon_nhap_theo_maNCC cry = new Hoadon_nhap_theo_maNCC();
                        cry.SetDataSource(dt);
                        BaoCao baocao = new BaoCao();
                        baocao.crystalReportViewer_baocao.ReportSource = cry;
                        baocao.Show();
                    }
                }
            }
        }

        private void comboBox_Chon_Timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
