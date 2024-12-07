using btlLTHSK.Resources;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace btlLTHSK
{
    public partial class HoaDon : Form
    {
        hoadonban hdban = new hoadonban();
        ErrorProvider error = new ErrorProvider();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            hdban.hien_HoaDonban(dataGridView_hoadonban);
            hdban.uploadComboBox(comboBox_manv, comboBox_makh);
        }

     
        private void textBox_mahoadon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_mahoadon.Text.Trim()))
            {
                error.SetError(textBox_mahoadon, "Mã hóa đơn bán không được để trống!");
            }
            else
            {
                error.SetError(textBox_mahoadon, null);
            }
        }

        private void comboBox_manv_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_manv.Text.Trim()))
            {
                error.SetError(comboBox_manv, "Mã nhân viên không được để trống!");
            }
            else
            {
                error.SetError(comboBox_manv, null);
            }
        }

        private void comboBox_makh_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_makh.Text.Trim()))
            {
                error.SetError(comboBox_makh, "Mã khách hàng không được để trống!");
            }
            else
            {
                error.SetError(comboBox_makh, null);
            }
        }

        private void button_ThemHD_Click(object sender, EventArgs e)
        {
            CancelEventArgs cancelEvent = new CancelEventArgs();
            textBox_mahoadon_Validating(sender, cancelEvent);
            comboBox_manv_Validating(sender, cancelEvent);
            comboBox_makh_Validating(sender, cancelEvent);
           

            DateTime dateTime = Convert.ToDateTime(dateTimePicker_ngayban.Text);
            string ngayban = dateTime.ToString("yyyy/MM/dd");

            if (!string.IsNullOrEmpty(textBox_mahoadon.Text.Trim()) 
                && !string.IsNullOrEmpty(comboBox_manv.Text.Trim()) && !string.IsNullOrEmpty(comboBox_makh.Text.Trim()))
            {
                if (hdban.kiemtratontai(int.Parse(textBox_mahoadon.Text.Trim())) == false)
                {
                    if (hdban.them_HoaDon_ban(int.Parse(textBox_mahoadon.Text.Trim()), comboBox_manv.Text.Trim(), comboBox_makh.Text.Trim(), ngayban) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        error.SetError(textBox_mahoadon, null);
                        // làm mới
                        textBox_mahoadon.Text = string.Empty;
                        comboBox_makh.Text = string.Empty;
                        comboBox_manv.Text = string.Empty;
                        dateTimePicker_ngayban.Value = DateTime.Now;
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                    error.SetError(textBox_mahoadon, "Mã hóa đơn này đã tồn tại");
                }
            }
            dataGridView_hoadonban.Rows.Clear();
            hdban.hien_HoaDonban(dataGridView_hoadonban);
        }

        private void dataGridView_hoadonban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_hoadonban.ClearSelection();
            }

            if (e.RowIndex >= 0 && (e.ColumnIndex >= 0 && e.ColumnIndex <= 4))
            {
                DataGridViewCell dataGridViewCell = dataGridView_hoadonban[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    error.SetError(textBox_mahoadon, null);
                    DataGridViewRow row = dataGridView_hoadonban.Rows[e.RowIndex];
                    textBox_mahoadon.Text = row.Cells[0].Value.ToString();
                    comboBox_manv.Text = row.Cells[1].Value.ToString();
                    comboBox_makh.Text = row.Cells[2].Value.ToString();
                    dateTimePicker_ngayban.Text = row.Cells[3].Value.ToString();
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
                if (dataGridView_hoadonban.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ChiTietHD chiTiet = new ChiTietHD(int.Parse(textBox_mahoadon.Text.Trim()));
                    chiTiet.Show();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
          

            DateTime dateTime = Convert.ToDateTime(dateTimePicker_ngayban.Text);
            string ngayban = dateTime.ToString("yyyy/MM/dd");

            if (!string.IsNullOrEmpty(textBox_mahoadon.Text.Trim()) 
                && !string.IsNullOrEmpty(comboBox_manv.Text.Trim()) && !string.IsNullOrEmpty(comboBox_makh.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (hdban.update_HoaDon_ban(int.Parse(textBox_mahoadon.Text.Trim()), comboBox_manv.Text.Trim(), comboBox_makh.Text.Trim(), ngayban) == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        // làm mới
                        textBox_mahoadon.Text = string.Empty;
                        comboBox_makh.Text = string.Empty;
                        comboBox_manv.Text = string.Empty;
                        dateTimePicker_ngayban.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            dataGridView_hoadonban.Rows.Clear();
            hdban.hien_HoaDonban(dataGridView_hoadonban);       
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(dateTimePicker_ngayban.Text);
            string ngayban = dateTime.ToString("yyyy/MM/dd");

            if (!string.IsNullOrEmpty(textBox_mahoadon.Text.Trim())
                && !string.IsNullOrEmpty(comboBox_manv.Text.Trim()) && !string.IsNullOrEmpty(comboBox_makh.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (hdban.xoa_HD_ban(int.Parse(textBox_mahoadon.Text.Trim())) == true)
                    {
                        MessageBox.Show("Xóa thành công");
                        // làm mới
                        textBox_mahoadon.Text = string.Empty;
                        comboBox_makh.Text = string.Empty;
                        comboBox_manv.Text = string.Empty;
                        dateTimePicker_ngayban.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            dataGridView_hoadonban.Rows.Clear();
            hdban.hien_HoaDonban(dataGridView_hoadonban);
        }

        private void button_lammoi_Click(object sender, EventArgs e)
        {
            textBox_mahoadon.Text = string.Empty;
            comboBox_makh.Text = string.Empty;
            comboBox_manv.Text = string.Empty;
            dateTimePicker_ngayban.Value = DateTime.Now;
        }
    }
}
