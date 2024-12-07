using btlLTHSK.Resources;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace btlLTHSK
{
    public partial class ChiTietHD : Form
    {
        ErrorProvider error = new ErrorProvider();
        Chitiet_hdon_ban chitiet = new Chitiet_hdon_ban();
        int mahd;
        public ChiTietHD(int mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            textBox_MaHD.Text = this.mahd + "";
            textBox_MaHD.ReadOnly = true;
            chitiet.uploadComboBox(comboBox_masp);
            dataGridView_chitiethdban.Rows.Clear();
            chitiet.hien_ChiTiethd(dataGridView_chitiethdban, int.Parse(textBox_MaHD.Text.Trim()));
        }

        private void textBox_MaHD_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaHD.Text.Trim()))
            {
                error.SetError(textBox_MaHD, "Mã hóa đơn bán không được để trống!");
            }
            else
            {
                error.SetError(textBox_MaHD, null);
            }
        }

        private void comboBox_masp_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_masp.Text.Trim()))
            {
                error.SetError(comboBox_masp, "Mã sản phẩm không được để trống!");
            }
            else
            {
                error.SetError(comboBox_masp, null);
            }
        }

        private void textBox_SoLuong_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void textBox_GiaBan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_GiaBan.Text.Trim()))
            {
                error.SetError(textBox_GiaBan, "Giá không được để trống!");
            }
            else
            {
                error.SetError(textBox_GiaBan, null);
            }
        }

        private void textBox_GiamGia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_GiamGia.Text.Trim()))
            {
                error.SetError(textBox_GiamGia, "Giảm giá không được để trống!");
            }
            else
            {
                error.SetError(textBox_GiamGia, null);
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            CancelEventArgs cancelEvent = new CancelEventArgs();
            textBox_MaHD_Validating(sender, cancelEvent);
            comboBox_masp_Validating(sender, cancelEvent);
            textBox_SoLuong_Validating(sender, cancelEvent);
            textBox_GiaBan_Validating(sender, cancelEvent);
            textBox_GiamGia_Validating(sender, cancelEvent);
            MessageBox.Show(textBox_GiaBan+"");
            if (!string.IsNullOrEmpty(textBox_MaHD.Text) && !string.IsNullOrEmpty(comboBox_masp.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim())
                && !string.IsNullOrEmpty(textBox_GiamGia.Text.Trim()))
            {

                if (chitiet.kiemtratontai(int.Parse(textBox_MaHD.Text.Trim()), comboBox_masp.Text.Trim()) == false)
                {

                    if (chitiet.them_ChiTiet_hoadon(int.Parse(textBox_MaHD.Text.Trim()), comboBox_masp.Text.Trim(), decimal.Parse(textBox_SoLuong.Text.Trim()), decimal.Parse(textBox_GiaBan.Text.Trim()), decimal.Parse(textBox_GiamGia.Text.Trim())) == true)
                    {

                        MessageBox.Show("Thêm thành công");
                        comboBox_masp.Text = string.Empty;
                        textBox_SoLuong.Text = string.Empty;
                        textBox_GiamGia.Text = string.Empty;
                        textBox_GiaBan.Text = string.Empty;
                    }

                }
                else
                {
                    MessageBox.Show("Không thành công(Dữ liệu này đã tồn tại)");
                }
            }
            dataGridView_chitiethdban.Rows.Clear();
            chitiet.hien_ChiTiethd(dataGridView_chitiethdban, int.Parse(textBox_MaHD.Text.Trim()));
        }

        private void button_Xua_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox_MaHD.Text) && !string.IsNullOrEmpty(comboBox_masp.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim())
                && !string.IsNullOrEmpty(textBox_GiamGia.Text.Trim()))
            {

                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (chitiet.update_ChiTiet_hoadon(int.Parse(textBox_MaHD.Text.Trim()), comboBox_masp.Text.Trim(), float.Parse(textBox_GiaBan.Text.Trim()), float.Parse(textBox_SoLuong.Text.Trim()), float.Parse(textBox_GiamGia.Text.Trim())) == true)
                    {

                        MessageBox.Show("Sửa thành công");
                        comboBox_masp.Text = string.Empty;
                        textBox_SoLuong.Text = string.Empty;
                        textBox_GiamGia.Text = string.Empty;
                        textBox_GiaBan.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
                dataGridView_chitiethdban.Rows.Clear();
                chitiet.hien_ChiTiethd(dataGridView_chitiethdban, int.Parse(textBox_MaHD.Text.Trim()));
            }
        }

        private void dataGridView_chitiethdban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_chitiethdban.ClearSelection();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell dataGridViewCell = dataGridView_chitiethdban[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    error.SetError(textBox_MaHD, null);
                    DataGridViewRow row = dataGridView_chitiethdban.Rows[e.RowIndex];
                    comboBox_masp.Text = row.Cells[1].Value.ToString();
                    textBox_GiaBan.Text = row.Cells[2].Value.ToString();
                    textBox_SoLuong.Text = row.Cells[3].Value.ToString();
                    textBox_GiamGia.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_MaHD.Text) && !string.IsNullOrEmpty(comboBox_masp.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim())
                && !string.IsNullOrEmpty(textBox_GiamGia.Text.Trim()))
            {

                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (chitiet.xoa_ChiTiet_PhieuNHap(int.Parse(textBox_MaHD.Text.Trim()), comboBox_masp.Text.Trim()) == true)
                    {

                        MessageBox.Show("Xóa thành công");
                        comboBox_masp.Text = string.Empty;
                        textBox_SoLuong.Text = string.Empty;
                        textBox_GiamGia.Text = string.Empty;
                        textBox_GiaBan.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
                dataGridView_chitiethdban.Rows.Clear();
                chitiet.hien_ChiTiethd(dataGridView_chitiethdban, int.Parse(textBox_MaHD.Text.Trim()));
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            comboBox_masp.Text = string.Empty;
            textBox_SoLuong.Text = string.Empty;
            textBox_GiamGia.Text = string.Empty;
            textBox_GiaBan.Text = string.Empty;
        }
    }
}
