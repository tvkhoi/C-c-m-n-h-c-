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
    public partial class SanPham : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        sanpham sanpham = new sanpham();
        double luu;
        string MaLT, tenLT;
        double SL, GB;
        ErrorProvider error = new ErrorProvider();
        public SanPham()
        {
            InitializeComponent();
        }
        public void ek()
        {
            SL = double.Parse(textBox_SoLuong.Text);
            GB = double.Parse(textBox_GiaBan.Text.Replace(".", ""));
        }
        private bool IsNumber(string strValue)
        {
            foreach (Char ch in strValue)
            {
                if (!Char.IsDigit(ch))
                    return false;
            }
            return true;
        }
        private void textBox_Soluong_textChanged(object sender, EventArgs e)
        {

        }
        private void ClearSP()
        {
            textBox_MaSanPham.Text = string.Empty;
            textBox_TenSanPham.Text = string.Empty;
            comboBox_MaLoai.Text = string.Empty;
            comboBox_Ma_NCC.Text = string.Empty;
            textBox_SoLuong.Text = string.Empty;
            textBox_GiaBan.Text = string.Empty;
        }
        private void button_Them_Click(object sender, EventArgs e)
        {

            CancelEventArgs themsp = new CancelEventArgs();
            dataGridView_sanpham.Rows.Clear();
            comboBox_ten_loai_Validating(sender, themsp);
            comboBox_ten_NCC_Validating(sender, themsp);
            textBox_MaSanPham_Validating(sender, themsp);
            textBox_TenSanPham_Validating(sender, themsp);
            textBox_SoLuong_Validating(sender, themsp);
            textBox_GiaBan_Validating(sender, themsp);
            if (!string.IsNullOrEmpty(textBox_MaSanPham.Text.Trim()) && !string.IsNullOrEmpty(textBox_TenSanPham.Text.Trim())
                && !string.IsNullOrEmpty(comboBox_MaLoai.Text.Trim()) && !string.IsNullOrEmpty(comboBox_Ma_NCC.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim()))
            {
                ek();
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool check=sanpham.ThemSP(textBox_MaSanPham.Text.ToString(), textBox_TenSanPham.Text.ToString(), comboBox_MaLoai.Text.ToString(), comboBox_Ma_NCC.Text.ToString(), SL, GB);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công");  
                        ClearSP();
                    }
                    else MessageBox.Show("Không thành công");
                   
                   

                }
                else
                    MessageBox.Show("Đâ dừng thêm sản phẩn");

            } 
          
            sanpham.hien_SP(dataGridView_sanpham);
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            sanpham.hien_SP(dataGridView_sanpham);
            uploadComboBox();
        }
        private void button_Luu_Click(object sender, EventArgs e)
        {

            CancelEventArgs luu = new CancelEventArgs();
            dataGridView_sanpham.Rows.Clear();
            comboBox_ten_loai_Validating(sender, luu);
            comboBox_ten_NCC_Validating(sender, luu);
            textBox_MaSanPham_Validating(sender, luu);
            textBox_TenSanPham_Validating(sender, luu);
            textBox_SoLuong_Validating(sender, luu);
            textBox_GiaBan_Validating(sender, luu);
            if (!string.IsNullOrEmpty(textBox_MaSanPham.Text.Trim()) && !string.IsNullOrEmpty(textBox_TenSanPham.Text.Trim())
                && !string.IsNullOrEmpty(comboBox_MaLoai.Text.Trim()) && !string.IsNullOrEmpty(comboBox_Ma_NCC.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim()))
            {
                ek();
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sanpham.update_sanpham(textBox_MaSanPham.Text.ToString(), textBox_TenSanPham.Text.ToString(), comboBox_MaLoai.Text.ToString(), comboBox_Ma_NCC.Text.ToString(), SL, GB);
                    ClearSP();
                    MessageBox.Show("Sửa thành công");

                }
                else
                    MessageBox.Show("Sửa không thành công");

            }

            sanpham.hien_SP(dataGridView_sanpham);
        }
        private void button_xoa_Click(object sender, EventArgs e)
        {
            //try
            //{
            CancelEventArgs xoa = new CancelEventArgs();
            textBox_MaSanPham_Validating(sender, xoa);
            if (!string.IsNullOrEmpty(textBox_MaSanPham.Text.Trim()) && !string.IsNullOrEmpty(textBox_TenSanPham.Text.Trim())
                && !string.IsNullOrEmpty(comboBox_MaLoai.Text.Trim()) && !string.IsNullOrEmpty(comboBox_Ma_NCC.Text.Trim())
                && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim()))
            {
                ek();
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sanpham.xoa_SP(textBox_MaSanPham.Text.ToString(), textBox_TenSanPham.Text.ToString(), comboBox_MaLoai.Text.ToString(), comboBox_Ma_NCC.Text.ToString(), SL, GB);
                    ClearSP();
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            dataGridView_sanpham.Rows.Clear();
            sanpham.hien_SP(dataGridView_sanpham);
            // }
            //catch (Exception ex)
            // {
            //  MessageBox.Show("Không thành công");
            //}
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            // đưa các ô nhập liệu về rỗng
            textBox_MaSanPham.Text = string.Empty;
            textBox_TenSanPham.Text = string.Empty;
            comboBox_Ma_NCC.Text = string.Empty;
            comboBox_MaLoai.Text = string.Empty;
            textBox_SoLuong.Text = string.Empty;
            textBox_GiaBan.Text = string.Empty;

            error.SetError(textBox_MaSanPham, null);
            error.SetError(textBox_TenSanPham, null);
            error.SetError(comboBox_Ma_NCC, null);
            error.SetError(comboBox_MaLoai, null);
            error.SetError(textBox_SoLuong, null);
            error.SetError(textBox_GiaBan, null);
        }

        private void dataGridView_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_GiaBan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_GiaBan.Text.Trim()))
            {
                error.SetError(textBox_GiaBan, "Không để trống !");
            }
            else
            {
                error.SetError(textBox_MaSanPham, null);
            }
        }

        private void textBox_GiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải số hoặc vượt quá 10 số
            }*/
        }

        private void comboBox_ten_loai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_MaLoai.Text.Trim()))
            {
                error.SetError(comboBox_MaLoai, "!");
                // button_Them.Enabled = false;
            }
            else
            {
                error.SetError(comboBox_MaLoai, null);
            }
        }

        private void comboBox_ten_NCC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_Ma_NCC.Text.Trim()))
            {
                error.SetError(comboBox_Ma_NCC, "!");
            }
            else
            {
                error.SetError(comboBox_Ma_NCC, null);
            }
        }

        private void textBox_MaSanPham_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaSanPham.Text.Trim()))
            {
                error.SetError(textBox_MaSanPham, "!");
            }
            else
            {
                error.SetError(textBox_MaSanPham, null);
            }
        }
        public void uploadComboBox()
        {
            comboBox_MaLoai.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblLoaiLaptop ";
                        cmd.CommandType = System.Data.CommandType.Text;
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
                            // Ngắt kết nối
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                comboBox_MaLoai.Items.Add(dataRow[0]);

                            }
                        }
                        cmd.CommandText = "select * from tblDoiTac";
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (SqlDataAdapter adapters = new SqlDataAdapter(cmd))
                        {
                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapters.Fill(dataTable);
                            // Ngắt kết nối
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                string data = dataRow[0].ToString();
                                data = data.Substring(0, 3);
                                if (data=="NCC")
                                comboBox_Ma_NCC.Items.Add(dataRow[0]);
                            }
                            conn.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
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
                    comboBox_MaLoai.Text = row.Cells[3].Value.ToString();
                    comboBox_Ma_NCC.Text = row.Cells[2].Value.ToString();
                    textBox_SoLuong.Text = row.Cells[4].Value.ToString();
                    textBox_GiaBan.Text = row.Cells[5].Value.ToString();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }

            }
        }

        private void textBox_TenSanPham_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_TenSanPham.Text.Trim()))
            {
                error.SetError(textBox_TenSanPham, "!");
            }
            else
            {
                error.SetError(textBox_TenSanPham, null);
            }
        }

    
        private void textBox_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải số hoặc vượt quá 10 số
            }
        }

        public string tenLoai { get; private set; }
        public string tenNCC { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {

            //InDS_SanPham formDS_SP = new InDS_SanPham();
            //formDS_SP.ShowDialog();
        }

        private void comboBox_ten_loai_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_MaLoai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblLoaiLapTop";
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (SqlDataAdapter adapters = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();                       
                            adapters.Fill(dataTable);
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                if (comboBox_MaLoai.Text == dataRow[0].ToString())
                                {
                                    textBox_HangSX.Text = dataRow[1].ToString();
                                }
                            }
                            conn.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }

        private void comboBox_Ma_NCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblDoiTac";
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (SqlDataAdapter adapters = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapters.Fill(dataTable);
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                if (comboBox_Ma_NCC.Text == dataRow[0].ToString())
                                {
                                    textBox_TenNCC.Text = dataRow[1].ToString();
                                }
                            }
                            conn.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }

        private void textBox_GiaBan_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int caretPosition = textBox.SelectionStart;
            string inputText = textBox.Text;

            string cleanText = Regex.Replace(inputText, @"[^\d]", "");
            string formattedText = string.Empty;
            int separatorCount = 0;

            // Tạo chuỗi với dấu phân cách hàng nghìn
            for (int i = 0; i < cleanText.Length; i++)
            {
                if (i > 0 && i % 3 == 0)
                {
                    formattedText = cleanText[cleanText.Length - i - 1] + "." + formattedText;
                    separatorCount++;
                }
                else
                {
                    formattedText = cleanText[cleanText.Length - i - 1] + formattedText;
                }
            }

            // Xóa kí tự đầu tiên nếu là dấu phân cách hàng nghìn
            if (formattedText.StartsWith("."))
            {
                formattedText = formattedText.Substring(1);
                caretPosition--;
                separatorCount--;
            }

            textBox.TextChanged -= textBox_GiaBan_TextChanged;
            textBox.Text = formattedText;
            textBox.TextChanged += textBox_GiaBan_TextChanged;

            // Đặt vị trí con trỏ
            if (caretPosition <= formattedText.Length + separatorCount)
            {
                textBox.SelectionStart = caretPosition + separatorCount;
            }
            else
            {
                textBox.SelectionStart = formattedText.Length + separatorCount;
            }
        }

        private void textBox_SoLuong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()))
            {
                error.SetError(textBox_SoLuong, "Lương không được để trống!");
            }
            else
            {

                error.SetError(textBox_SoLuong, null);
                SL = double.Parse(textBox_SoLuong.Text.Replace(".", ""));
            }
        }

        public void uploadDTGV()
        {

        }
    }
}
