using btlLTHSK.Resources;
using System;
using System.ComponentModel;
using System.Diagnostics.Eventing;
using System.Windows.Forms;

namespace btlLTHSK
{
    public partial class NhaCungCap : Form
    {
        ErrorProvider error = new ErrorProvider();
        private string fixedPrefix = "NCC";
        NCC nCC = new NCC();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void textBox_maNCC_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string maNCC = textBox_maNCC.Text.Trim();

            if (string.IsNullOrEmpty(maNCC) || maNCC == "NCC")
            {
                error.SetError(textBox_maNCC, "Mã nhà cung cấp không được để trống hoặc là 'NCC'!");
            }
            else
            {
                error.SetError(textBox_maNCC, null);
            }
        }

        private void textBox_tenNCC_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox_tenNCC.Text.Trim() == "")
            {
                error.SetError(textBox_tenNCC, "Tên nhà cung cấp không được để trống!");
            }
            else
            {
                error.SetError(textBox_tenNCC, null);
            }
        }

        private void textBox_sdtNCC_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox_sdtNCC.Text.Trim() == "")
            {
                error.SetError(textBox_sdtNCC, "Số điện thoại nhà cung cấp không được để trống!");
            }
            else
            {
                error.SetError(textBox_sdtNCC, null);
            }
        }

        private void textBox_diachiNCC_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox_diachiNCC.Text.Trim() == "")
            {
                error.SetError(textBox_diachiNCC, "Địa chỉ nhà cung cấp không được để trống!");
            }
            else
            {
                error.SetError(textBox_diachiNCC, null);
            }
        }
        public void dinhdang_MaNCC(Object sender)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length < fixedPrefix.Length)
            {
                textBox.Text = fixedPrefix;
                textBox.Select(textBox.Text.Length, 0); // Di chuyển con trỏ đến cuối TextBox
            }
            else if (!textBox.Text.StartsWith(fixedPrefix))
            {
                textBox.Text = fixedPrefix + textBox.Text.Substring(fixedPrefix.Length);
                textBox.Select(textBox.Text.Length, 0); // Di chuyển con trỏ đến cuối TextBox
            }
        }

        private void textBox_maNCC_TextChanged(object sender, EventArgs e)
        {
            dinhdang_MaNCC(sender);
        }

        private void textBox_maNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_sdtNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Kiểm tra độ dài của chuỗi số điện thoại sau khi thêm ký tự mới
            if (char.IsDigit(e.KeyChar) && textBox_sdtNCC.Text.Replace(" ", "").Length >= 10)
            {
                e.Handled = true; // Nếu đã có 10 số, ngăn không cho thêm số nữa
            }
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            textBox_maNCC.Text = fixedPrefix;
            dataGridView_NCC.Rows.Clear();
            nCC.hien_NCC(dataGridView_NCC);
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            // xóa dữ liệu từ datagridview 
            dataGridView_NCC.Rows.Clear();
            CancelEventArgs cancel = new CancelEventArgs();
            textBox_maNCC_Validating(sender, cancel);
            textBox_diachiNCC_Validating(sender, cancel);
            textBox_tenNCC_Validating(sender, cancel);
            textBox_sdtNCC_Validating(sender, cancel);
            if (!string.IsNullOrEmpty(textBox_maNCC.Text.Trim()) && textBox_maNCC.Text.Trim() != "NCC" && !string.IsNullOrEmpty(textBox_tenNCC.Text.Trim())
                 && !string.IsNullOrEmpty(textBox_sdtNCC.Text.Trim()) && !string.IsNullOrEmpty(textBox_diachiNCC.Text.Trim()))
            {
                if (nCC.kiemtra_maNCC(textBox_maNCC.Text, error, textBox_maNCC) == false)
                {
                    if(nCC.kiemtra_email(textBox_email.Text,error,textBox_email)==false) { 
                    nCC.ThemNCC(textBox_maNCC.Text, textBox_tenNCC.Text, textBox_diachiNCC.Text, textBox_sdtNCC.Text,textBox_email.Text);
                    MessageBox.Show("Thêm thành công.");
                    textBox_maNCC.Text = string.Empty;
                    textBox_tenNCC.Text = string.Empty;
                    textBox_sdtNCC.Text = string.Empty;
                    textBox_diachiNCC.Text = string.Empty;
                    textBox_email.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }

            }
            dataGridView_NCC.Rows.Clear();
            nCC.hien_NCC(dataGridView_NCC);
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            
                string texbox_tk = comboBox_timkiem.Items[comboBox_timkiem.SelectedIndex].ToString();

                if (texbox_tk == "Tên Nhà Cung Cấp")
                {
                    nCC.tim_kiem_NCC_duavaoTen(textBox_TimKiem.Text, dataGridView_NCC);
                }
                else if (texbox_tk == "Số Điện Thoại")
                {
                    nCC.tim_kiem_NCC_duavaoSDT(textBox_TimKiem.Text, dataGridView_NCC);
                }
                else if(texbox_tk == "Địa Chỉ")
                {
                    nCC.tim_kiem_NCC_duavaoDiaChi(textBox_TimKiem.Text, dataGridView_NCC);
                }
        
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            textBox_maNCC.Text = string.Empty;
            textBox_tenNCC.Text = string.Empty;
            textBox_sdtNCC.Text = string.Empty;
            textBox_diachiNCC.Text = string.Empty;
            textBox_email.Text = string.Empty;
        }

        private void dataGridView_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_NCC.ClearSelection();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell dataGridViewCell = dataGridView_NCC[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    error.SetError(textBox_maNCC, null);
                    DataGridViewRow row = dataGridView_NCC.Rows[e.RowIndex];
                    textBox_maNCC.Text = row.Cells[0].Value.ToString();
                    textBox_tenNCC.Text = row.Cells[1].Value.ToString();
                    textBox_diachiNCC.Text = row.Cells[3].Value.ToString();
                    textBox_sdtNCC.Text = row.Cells[2].Value.ToString();
                    textBox_email.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }

            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_maNCC.Text.Trim()) && textBox_maNCC.Text.Trim() != "NCC" && !string.IsNullOrEmpty(textBox_tenNCC.Text.Trim())
                 && !string.IsNullOrEmpty(textBox_sdtNCC.Text.Trim()) && !string.IsNullOrEmpty(textBox_diachiNCC.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if(nCC.kiemtra_email(textBox_email.Text,error,textBox_maNCC)==false) { 
                        if(nCC.suaNCC(textBox_maNCC.Text.Trim(),textBox_tenNCC.Text.Trim(),textBox_diachiNCC.Text.Trim(),textBox_sdtNCC.Text.Trim(),textBox_email.Text.Trim())==true)
                        {
                            MessageBox.Show("Sửa thành công");
                            textBox_maNCC.Text = string.Empty;
                            textBox_tenNCC.Text = string.Empty;
                            textBox_sdtNCC.Text = string.Empty;
                            textBox_diachiNCC.Text = string.Empty;
                            textBox_email.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công");
                        }
                    }
                }
            }
            dataGridView_NCC.Rows.Clear();
            nCC.hien_NCC(dataGridView_NCC);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
          //  if (!string.IsNullOrEmpty(textBox_maNCC.Text.Trim()) && textBox_maNCC.Text.Trim() != "NCC" && !string.IsNullOrEmpty(textBox_tenNCC.Text.Trim())
          //      && !string.IsNullOrEmpty(textBox_sdtNCC.Text.Trim()) && !string.IsNullOrEmpty(textBox_diachiNCC.Text.Trim()))
           // {
             //   DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             //   if (result == DialogResult.Yes)
             //   {
             //       if (nCC.suaNCC(textBox_maNCC.Text.Trim(), textBox_tenNCC.Text.Trim(), textBox_diachiNCC.Text.Trim(), textBox_sdtNCC.Text.Trim()) == true)
             //       {
              //          MessageBox.Show("Xóa thành công");
            //        }
           //         else
           //         {
           //             MessageBox.Show("Xóa không thành công");
           //         }
          //      }
         //   }
            dataGridView_NCC.Rows.Clear();
            nCC.hien_NCC(dataGridView_NCC);
        }
    }
}
