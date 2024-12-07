using btlLTHSK.Resources;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace btlLTHSK
{
    public partial class SanPham : Form
    {
        ErrorProvider error =new ErrorProvider();
        sanpham sp = new sanpham();
        public SanPham()
        {
            InitializeComponent();
        }

        private void textBox_MaSanPham_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaSanPham.Text.Trim()))
            {
                error.SetError(textBox_MaSanPham, "Mã sản phẩm không được để trống!");
            }
            else
            {
                error.SetError(textBox_MaSanPham, null);
            }
        }

        private void textBox_TenSanPham_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_TenSanPham.Text.Trim()))
            {
                error.SetError(textBox_TenSanPham, "Tên sản phẩm không được để trống!");
            }
            else
            {
                error.SetError(textBox_TenSanPham, null);
            }
        }

  

        private void textBox_SoLuong_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()))
            {
                error.SetError(textBox_SoLuong, "Số lượng sản phẩm không được để trống!");
            }
            else
            {
                error.SetError(textBox_SoLuong, null);
            }
        }

        private void textBox_GiaBan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_GiaBan.Text.Trim()))
            {
                error.SetError(textBox_GiaBan, "Giá bán sản phẩm không được để trống!");
            }
            else
            {
                error.SetError(textBox_GiaBan, null);
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            this.Select(); // Đặt con trỏ chuột mặc định cho form
            sp.hien_SP(dataGridView_sanpham);
            comboBox_ma_sx.Items.Clear();
            comboBox_ma_NCC.Items.Clear();
            sp.uploadComboBox(comboBox_ma_sx, comboBox_ma_NCC);
        }


        private void button_Them_Click(object sender, EventArgs e)
        {
            CancelEventArgs cancelEvent = new CancelEventArgs();
            textBox_GiaBan_Validating(sender, cancelEvent);
            textBox_MaSanPham_Validating(sender, cancelEvent);  
            textBox_SoLuong_Validating(sender, cancelEvent);
            textBox_TenSanPham_Validating(sender, cancelEvent);
            comboBox_ma_sx_Validating(sender, cancelEvent);
            comboBox_ma_NCC_Validating(sender, cancelEvent);

            if(!string.IsNullOrEmpty(textBox_MaSanPham.Text.Trim()) && !string.IsNullOrEmpty(textBox_TenSanPham.Text.Trim())
                && !string.IsNullOrEmpty(comboBox_ma_sx.Text.Trim()) && !string.IsNullOrEmpty(comboBox_ma_NCC.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim())) { 
                if(sp.kiemtra_maSP(textBox_MaSanPham.Text.Trim(),error,textBox_MaSanPham)==false)
                {
                    sp.ThemSP(textBox_MaSanPham.Text.Trim(), textBox_TenSanPham.Text.Trim(), comboBox_ma_sx.Text.Trim(),comboBox_ma_NCC.Text.Trim(),float.Parse(textBox_SoLuong.Text.Trim()), float.Parse(textBox_GiaBan.Text.Trim()));
                    MessageBox.Show("Thêm thành công");
                    comboBox_ma_NCC.Text = string.Empty;
                    textBox_ten_NCC.Text = string.Empty;
                    textBox_ten_sx.Text = string.Empty;
                    comboBox_ma_sx.Text = string.Empty;
                    textBox_MaSanPham.Text = string.Empty;
                    textBox_TenSanPham.Text = string.Empty;
                    textBox_SoLuong.Text = string.Empty;
                    textBox_GiaBan.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            dataGridView_sanpham.Rows.Clear();
            sp.hien_SP(dataGridView_sanpham);
        }

 

        private void comboBox_ma_sx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_ma_sx.Text.Trim()))
            {
                error.SetError(comboBox_ma_sx, "Mã sx không được để trống!");
            }
            else
            {
                error.SetError(comboBox_ma_sx, null);
            }
        }

        private void comboBox_ma_NCC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_ma_NCC.Text.Trim()))
            {
                error.SetError(comboBox_ma_NCC, "Mã nhà cung cấp không được để trống!");
            }
            else
            {
                error.SetError(comboBox_ma_NCC, null);
            }
        }

        private void comboBox_ma_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            sp.layten_ncc(comboBox_ma_NCC.Text.Trim(), textBox_ten_NCC);
        }

        private void comboBox_ma_sx_SelectedIndexChanged(object sender, EventArgs e)
        {
            sp.layten_loai(comboBox_ma_sx.Text.Trim(),textBox_ten_sx);
        }

        private void dataGridView_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_sanpham.ClearSelection();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell dataGridViewCell = dataGridView_sanpham[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    error.SetError(textBox_MaSanPham, null);
                    DataGridViewRow row = dataGridView_sanpham.Rows[e.RowIndex];
                    textBox_MaSanPham.Text = row.Cells[0].Value.ToString();
                    textBox_TenSanPham.Text = row.Cells[1].Value.ToString();
                    comboBox_ma_sx.Text = row.Cells[2].Value.ToString();
                    textBox_ten_sx.Text = row.Cells[3].Value.ToString();
                    comboBox_ma_NCC.Text = row.Cells[4].Value.ToString();
                    textBox_ten_NCC.Text = row.Cells[5].Value.ToString();
                    textBox_SoLuong.Text = row.Cells[6].Value.ToString();
                    textBox_GiaBan.Text = row.Cells[7].Value.ToString();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }
            }
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_MaSanPham.Text.Trim()) && !string.IsNullOrEmpty(textBox_TenSanPham.Text.Trim())
                && !string.IsNullOrEmpty(comboBox_ma_sx.Text.Trim()) && !string.IsNullOrEmpty(comboBox_ma_NCC.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    
                    if(sp.update_sanpham(textBox_MaSanPham.Text.Trim(), textBox_TenSanPham.Text.Trim(), comboBox_ma_sx.Text.Trim(), comboBox_ma_NCC.Text.Trim(), float.Parse(textBox_SoLuong.Text.Trim()), float.Parse(textBox_GiaBan.Text.Trim()))==true)
                    {
                        MessageBox.Show("Sửa thành công");
                        // đưa các ô nhập liệu về rỗng
                        comboBox_ma_NCC.Text = string.Empty;
                        textBox_ten_NCC.Text = string.Empty;
                        textBox_ten_sx.Text = string.Empty;
                        comboBox_ma_sx.Text = string.Empty;
                        textBox_MaSanPham.Text = string.Empty;
                        textBox_TenSanPham.Text = string.Empty;
                        textBox_SoLuong.Text = string.Empty;
                        textBox_GiaBan.Text = string.Empty;
                    }
                    
                     else
                     {
                        MessageBox.Show("Sửa không thành công");
                    }
                      
                }
               
                
            }
            dataGridView_sanpham.Rows.Clear();
            sp.hien_SP(dataGridView_sanpham);
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            comboBox_ma_NCC.Text = string.Empty;
            textBox_ten_NCC.Text = string.Empty;
            textBox_ten_sx.Text = string.Empty;
            comboBox_ma_sx.Text = string.Empty;
            textBox_MaSanPham.Text = string.Empty;
            textBox_TenSanPham.Text = string.Empty;
            textBox_SoLuong.Text = string.Empty;
            textBox_GiaBan.Text = string.Empty;
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_MaSanPham.Text.Trim()) && !string.IsNullOrEmpty(textBox_TenSanPham.Text.Trim())
                && !string.IsNullOrEmpty(comboBox_ma_sx.Text.Trim()) && !string.IsNullOrEmpty(comboBox_ma_NCC.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim()))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa không(dữ liệu ở bảng chi tiết nhập và bán có thể bị mất)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    if (sp.xoa_SP(textBox_MaSanPham.Text.Trim())==true)
                    {
                        MessageBox.Show("Xóa thành công");
                        // đưa các ô nhập liệu về rỗng
                        comboBox_ma_NCC.Text = string.Empty;
                        textBox_ten_NCC.Text = string.Empty;
                        textBox_ten_sx.Text = string.Empty;
                        comboBox_ma_sx.Text = string.Empty;
                        textBox_MaSanPham.Text = string.Empty;
                        textBox_TenSanPham.Text = string.Empty;
                        textBox_SoLuong.Text = string.Empty;
                        textBox_GiaBan.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
              
                
            }
            dataGridView_sanpham.Rows.Clear();
            sp.hien_SP(dataGridView_sanpham);
        }
    }
}
