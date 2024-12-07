using btlLTHSK.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlLTHSK
{
    public partial class ChiTietNhap : Form
    {
        ErrorProvider error = new ErrorProvider();
        ChiTietNhapcs01 chiTiet = new ChiTietNhapcs01();
        int isoHD;
        int tinhieu;
        public ChiTietNhap(int isoHD,int tinhieu)
        {
            this.isoHD = isoHD;
            this.tinhieu = tinhieu;
            InitializeComponent();
        }

        private void ChiTietNhap_Load(object sender, EventArgs e)
        {
              textBox_MaHDNhap.Text = this.isoHD+"";
              if(tinhieu==0)
              {
                 textBox_MaHDNhap.ReadOnly = true;
              }
              else
              {
                 textBox_MaHDNhap.ReadOnly = false;
              }
            chiTiet.uploadComboBox(comboBox_maSP);
            dataGridView_HDNhap.Rows.Clear();
            chiTiet.hien_ChiTietPN(dataGridView_HDNhap,int.Parse(textBox_MaHDNhap.Text.Trim()));
        }

        private void textBox_MaHDNhap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()))
            {
                error.SetError(textBox_MaHDNhap, "Mã hóa đơn nhập không được để trống!");
            }
            else
            {
                error.SetError(textBox_MaHDNhap, null);
            }
        }

        private void comboBox_maSP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_maSP.Text.Trim()))
            {
                error.SetError(comboBox_maSP, "Mã sản phẩm không được để trống!");
            }
            else
            {
                error.SetError(comboBox_maSP, null);
            }
        }

        private void textBox_SoLuong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()))
            {
                error.SetError(textBox_SoLuong, "Số lượng không được để trống!");
            }
            else
            {
                error.SetError(textBox_SoLuong, null);
            }
        }

        private void textBox_Gia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Gia.Text.Trim()))
            {
                error.SetError(textBox_Gia, "Giá không được để trống!");
            }
            else
            {
                error.SetError(textBox_Gia, null);
            }
        }

        private void comboBox_maSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            chiTiet.layTensp(comboBox_maSP.Text.Trim(),textBox_tenSP);
        }

        private void comboBox_maSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            comboBox_maSP.Text = string.Empty;
            textBox_tenSP.Text = string.Empty;
            textBox_SoLuong.Text = string.Empty;
            textBox_Gia.Text = string.Empty;
            if(tinhieu != 0)
            {
               textBox_MaHDNhap.Text = string.Empty;
            }
        }

        private void textBox_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void textBox_Gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            CancelEventArgs cancelEvent = new CancelEventArgs();
            textBox_MaHDNhap_Validating(sender, cancelEvent);
            comboBox_maSP_Validating(sender, cancelEvent);
            textBox_Gia_Validating(sender, cancelEvent);
            textBox_SoLuong_Validating(sender, cancelEvent);

            if(!string.IsNullOrEmpty(textBox_MaHDNhap.Text) && !string.IsNullOrEmpty(comboBox_maSP.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_Gia.Text.Trim()))
            {

                if(chiTiet.kiemtratontai(int.Parse(textBox_MaHDNhap.Text.Trim()),comboBox_maSP.Text.Trim())==false)
                {

                    if(chiTiet.them_ChiTiet_PhieuNhap(int.Parse(textBox_MaHDNhap.Text.Trim()),comboBox_maSP.Text.Trim(), decimal.Parse(textBox_SoLuong.Text.Trim()), decimal.Parse(textBox_Gia.Text.Trim()))==true) {

                        MessageBox.Show("Thêm thành công");
                        comboBox_maSP.Text = string.Empty;
                        textBox_tenSP.Text = string.Empty;
                        textBox_SoLuong.Text = string.Empty;
                        textBox_Gia.Text = string.Empty;
                        if (tinhieu != 0)
                        {
                            textBox_MaHDNhap.Text = string.Empty;
                        }
                    }
               
                }
                else
                {
                    MessageBox.Show("Không thành công(Dữ liệu này đã tồn tại)");
                }
            }
            dataGridView_HDNhap.Rows.Clear();
            chiTiet.hien_ChiTietPN(dataGridView_HDNhap,isoHD);
        }

        private void button_Xua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_MaHDNhap.Text) && !string.IsNullOrEmpty(comboBox_maSP.Text.Trim())
             && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_Gia.Text.Trim()))
            {

                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (chiTiet.update_ChiTiet_PhieuNhap(int.Parse(textBox_MaHDNhap.Text.Trim()), comboBox_maSP.Text.Trim(), float.Parse(textBox_SoLuong.Text.Trim()), float.Parse(textBox_Gia.Text.Trim())) == true)
                    {

                        MessageBox.Show("Sửa thành công");
                        comboBox_maSP.Text = string.Empty;
                        textBox_tenSP.Text = string.Empty;
                        textBox_SoLuong.Text = string.Empty;
                        textBox_Gia.Text = string.Empty;
                        if (tinhieu != 0)
                        {
                            textBox_MaHDNhap.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
                
            }
            dataGridView_HDNhap.Rows.Clear();
            chiTiet.hien_ChiTietPN(dataGridView_HDNhap, isoHD);
        }

        private void dataGridView_HDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_HDNhap.ClearSelection();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell dataGridViewCell = dataGridView_HDNhap[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    error.SetError(textBox_MaHDNhap, null);
                    DataGridViewRow row = dataGridView_HDNhap.Rows[e.RowIndex];
                    textBox_MaHDNhap.Text = row.Cells[0].Value.ToString();
                    comboBox_maSP.Text = row.Cells[1].Value.ToString();
                    textBox_tenSP.Text = row.Cells[2].Value.ToString();
                    textBox_SoLuong.Text = row.Cells[3].Value.ToString();
                    textBox_Gia.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_MaHDNhap.Text) && !string.IsNullOrEmpty(comboBox_maSP.Text.Trim())
           && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_Gia.Text.Trim()))
            {

                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (chiTiet.xoa_ChiTiet_PhieuNHap(int.Parse(textBox_MaHDNhap.Text.Trim()), comboBox_maSP.Text.Trim()) == true)
                    {

                        MessageBox.Show("Xóa thành công");
                        comboBox_maSP.Text = string.Empty;
                        textBox_tenSP.Text = string.Empty;
                        textBox_SoLuong.Text = string.Empty;
                        textBox_Gia.Text = string.Empty;
                        if (tinhieu != 0)
                        {
                            textBox_MaHDNhap.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }

            }
            dataGridView_HDNhap.Rows.Clear();
            chiTiet.hien_ChiTietPN(dataGridView_HDNhap, isoHD);
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string texbox_tk = comboBox_TimKiem.Items[comboBox_TimKiem.SelectedIndex].ToString();

            if (texbox_tk == "Mã sản phẩm")
            {
                chiTiet.timkiem_chitiet_HD_Nhap_duavaoMasp(int.Parse(textBox_MaHDNhap.Text.Trim()),textBox_TimKiem.Text, dataGridView_HDNhap);
            }
            else if (texbox_tk == "Mã nhà cung cấp")
            {
               // hdnhap.search_HD_Nhap_duavaoMaNCC(textBox_TimKiem.Text, dataGridView_HoaDonPN);
            }
        }
    }
}
