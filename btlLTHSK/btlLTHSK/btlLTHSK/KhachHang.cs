using btlLTHSK.Resources;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using btlLTHSK.Cry;

namespace btlLTHSK
{
    public partial class QLKhachHang : Form
    {
        KhachHang khachHang = new KhachHang();
        ErrorProvider error = new ErrorProvider();
        private string fixedPrefix = "KH";
        public QLKhachHang()
        {
            InitializeComponent();

        }


        private void textBox_Ma_KhachHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Ma_KhachHang.Text.Trim()))
            {
                error.SetError(textBox_Ma_KhachHang, "Mã khách hàng không được để trống!");
            }
            else
            {
                error.SetError(textBox_Ma_KhachHang, null);
            }
        }

        private void textBox_Ten_KhachHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Ten_KhachHang.Text.Trim()))
            {
                error.SetError(textBox_Ten_KhachHang, "Tên khách hàng không được để trống!");
            }
            else
            {
                error.SetError(textBox_Ten_KhachHang, null);
            }
        }

        private void textBox_DiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_DiaChi.Text.Trim()))
            {
                error.SetError(textBox_DiaChi, "Tên khách hàng không được để trống!");
            }
            else
            {
                error.SetError(textBox_DiaChi, null);
            }
        }

        private void textBox_sdt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_sdt.Text.Trim()))
            {
                error.SetError(textBox_sdt, "Số điện thoại không được để trống!");
            }
            else
            {
                error.SetError(textBox_sdt, null);
            }
        }

        private void textBox_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Kiểm tra độ dài của chuỗi số điện thoại sau khi thêm ký tự mới
            if (char.IsDigit(e.KeyChar) && textBox_sdt.Text.Replace(" ", "").Length >= 10)
            {
                e.Handled = true; // Nếu đã có 10 số, ngăn không cho thêm số nữa
            }
        }

        private void textBox_sdt_TextChanged(object sender, EventArgs e)
        {

        }
        public void dinhdang_MaKH(Object sender)
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
        public string xoa_ki_tu_dinh_dang(string chuoi)
        {
            chuoi = chuoi.Replace("KH", "");
            return chuoi;
        }
        private void textBox_Ma_KhachHang_TextChanged(object sender, EventArgs e)
        {
            dinhdang_MaKH(sender);
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            // xóa dữ liệu từ datagridview 
            dataGridView_Khach_Hang.Rows.Clear();
            CancelEventArgs cancel = new CancelEventArgs();
            textBox_Ma_KhachHang_Validating(sender, cancel);
            textBox_DiaChi_Validating(sender, cancel);
            textBox_Ten_KhachHang_Validating(sender, cancel);
            textBox_sdt_Validating(sender, cancel);
            if (!string.IsNullOrEmpty(textBox_Ma_KhachHang.Text.Trim()) && !string.IsNullOrEmpty(textBox_Ten_KhachHang.Text.Trim())
                 && !string.IsNullOrEmpty(textBox_sdt.Text.Trim()) && !string.IsNullOrEmpty(textBox_DiaChi.Text.Trim()))
            {
                if (khachHang.kiemtra_maKH(textBox_Ma_KhachHang.Text, error, textBox_Ma_KhachHang) == false)
                {
                    khachHang.ThemSinhVien(textBox_Ma_KhachHang.Text, textBox_Ten_KhachHang.Text, textBox_DiaChi.Text, textBox_sdt.Text);
                    MessageBox.Show("Thêm thành công.");
                    textBox_Ma_KhachHang.Text = string.Empty;
                    textBox_Ten_KhachHang.Text = string.Empty;
                    textBox_sdt.Text = string.Empty;
                    textBox_DiaChi.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }

            }
            khachHang.hien_KhachHang(dataGridView_Khach_Hang);
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            textBox_Ma_KhachHang.Text = fixedPrefix;
            khachHang.hien_KhachHang(dataGridView_Khach_Hang);
        }

        private void dataGridView_Khach_Hang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_Khach_Hang.ClearSelection();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell dataGridViewCell = dataGridView_Khach_Hang[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    //  error.SetError(textBox_maNV, null);
                    DataGridViewRow row = dataGridView_Khach_Hang.Rows[e.RowIndex];
                    textBox_Ma_KhachHang.Text = row.Cells[0].Value.ToString();
                    textBox_Ten_KhachHang.Text = row.Cells[1].Value.ToString();
                    textBox_sdt.Text = row.Cells[2].Value.ToString();
                    textBox_DiaChi.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }

            }
        }

        private void textBox_Ma_KhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            // kiểm tra nếu rỗng thì không xóa được
            if (!string.IsNullOrEmpty(textBox_Ma_KhachHang.Text.Trim()) && !string.IsNullOrEmpty(textBox_Ten_KhachHang.Text.Trim())
               && !string.IsNullOrEmpty(textBox_sdt.Text.Trim()) && !string.IsNullOrEmpty(textBox_DiaChi.Text.Trim()))
            {

                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    // Sử lí khi update

                    khachHang.update_KhachHang(textBox_Ma_KhachHang.Text.Trim(), textBox_Ten_KhachHang.Text.Trim()
                       , textBox_DiaChi.Text.Trim(), textBox_sdt.Text.Trim());
                    // đưa các ô nhập liệu về rỗng
                    textBox_Ma_KhachHang.Text = string.Empty;
                    textBox_Ten_KhachHang.Text = string.Empty;
                    textBox_sdt.Text = string.Empty;
                    textBox_DiaChi.Text = string.Empty;

                    dataGridView_Khach_Hang.Rows.Clear();
                    khachHang.hien_KhachHang(dataGridView_Khach_Hang);


                }
            }
        }

        private void button_Xóa_Click(object sender, EventArgs e)
        {
            // kiểm tra nếu rỗng thì không xóa được
            if (!string.IsNullOrEmpty(textBox_Ma_KhachHang.Text.Trim()) && !string.IsNullOrEmpty(textBox_Ten_KhachHang.Text.Trim())
               && !string.IsNullOrEmpty(textBox_sdt.Text.Trim()) && !string.IsNullOrEmpty(textBox_DiaChi.Text.Trim()))
            {

                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    khachHang.xoa_KhachHang(textBox_Ma_KhachHang.Text.Trim(), textBox_Ten_KhachHang.Text.Trim()
                        , textBox_DiaChi.Text.Trim(), textBox_sdt.Text.Trim());
                    // đưa các ô nhập liệu về rỗng
                    textBox_Ma_KhachHang.Text = string.Empty;
                    textBox_Ten_KhachHang.Text = string.Empty;
                    textBox_sdt.Text = string.Empty;
                    textBox_DiaChi.Text = string.Empty;
                    dataGridView_Khach_Hang.Rows.Clear();
                    khachHang.hien_KhachHang(dataGridView_Khach_Hang);
                }
                else
                {
                    // đóng
                }
            }
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
           
                string texbox_tk = comboBox_TimKiem.Items[comboBox_TimKiem.SelectedIndex].ToString();

                if (texbox_tk == "Tên Khách Hàng")
                {
                    khachHang.tim_kiem_KhachHang_duavaoTen(textBox_TimKiem.Text, dataGridView_Khach_Hang);
                }
                else if (texbox_tk == "Điện Thoại")
                {
                    khachHang.tim_kiem_KhachHang_duavaoSDT(textBox_TimKiem.Text, dataGridView_Khach_Hang);
                }
            
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            // đưa các ô nhập liệu về rỗng
            textBox_Ma_KhachHang.Text = string.Empty;
            textBox_Ten_KhachHang.Text = string.Empty;
            textBox_sdt.Text = string.Empty;
            textBox_DiaChi.Text = string.Empty;

            error.SetError(textBox_Ma_KhachHang, null);
            error.SetError(textBox_Ten_KhachHang, null);
            error.SetError(textBox_sdt, null);
            error.SetError(textBox_DiaChi, null);
        }

        private void button_baocao_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_InChiTietHoaDonMuaHang_KHbanDau";
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        thongke_tungchitiet_kh cry = new thongke_tungchitiet_kh();
                        cry.SetDataSource(dt);
                        BaoCao baocao = new BaoCao();
                        baocao.crystalReportViewer_baocao.ReportSource = cry;
                        baocao.Show();
                    }
                }
            }
        }
    }
}
