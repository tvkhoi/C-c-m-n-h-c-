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
    public partial class ChiTietHD : Form
    {
        ErrorProvider error = new ErrorProvider();
        QLChiTietHoaDon chitietHD = new QLChiTietHoaDon();
     //   InHoaDon inhoadon = new InHoaDon();
        int SoLuong = 0;
        double ThanhTien = 0;
        double MaHD = 0;
        double b = 0;
        int GiamGia = 0;
        double GiaBan = 0;
        public double onechoice = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        public ChiTietHD()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void check_validating(object sender, CancelEventArgs luu)
        {
            comboBox_MaHD_Validating(sender, luu);        
            textBox_GiaBan_Validating(sender, luu);
            textBox_GiamGia_Validating(sender, luu);
            textBox_ThanhTien_Validating(sender, luu);
            cb_MaSP_Validating(sender, luu);
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            CancelEventArgs luu = new CancelEventArgs();
            check_validating(sender, luu);
            if (!string.IsNullOrEmpty(comboBox_MaHD.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim())
                && !string.IsNullOrEmpty(textBox_ThanhTien.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiamGia.Text.Trim())
                && !string.IsNullOrEmpty(cb_MaSP.Text.Trim()))
                {
                bool them = chitietHD.them_ChiTietHD_Ban(MaHD, cb_MaSP.Text.ToString(), GiaBan, SoLuong, GiamGia);
                if (them)
                {
                    MessageBox.Show("Thêm thành công");
                    // đưa các ô nhập liệu về rỗng
                    comboBox_MaHD.Text = string.Empty;
                    cb_MaSP.Text = string.Empty;
                    textBox_SoLuong.Text = string.Empty;
                    textBox_ThanhTien.Text = string.Empty;
                    textBox_GiamGia.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }

            }          
            dgv_CTHD.Rows.Clear();
            chon_hien_PhieuNhap(onechoice);

        }

        private void textBox_Ma(object sender, CancelEventArgs e)
        {

        }

        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            select_MaHD();
            upload_MaSP_Ban();
            chon_hien_PhieuNhap(onechoice);
        }

        private void comboBox_MaHD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_MaHD.Text.Trim()))
            {
                error.SetError(comboBox_MaHD, "!");
            }
            else
            {
                error.SetError(comboBox_MaHD, null);
                MaHD = double.Parse(comboBox_MaHD.Text);
            }
        }

        private void cb_MaSP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_MaSP.Text.Trim()))
            {
                error.SetError(cb_MaSP, "!");
            }
            else
            {
                error.SetError(cb_MaSP, null);           
            }
        }

        private void textBox_SoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void textBox_GiaBan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_GiaBan.Text.Trim()))
            {
                error.SetError(textBox_GiaBan, "!");
            }
            else
            {
                error.SetError(textBox_GiaBan, null);
                GiaBan = double.Parse(textBox_GiaBan.Text.Replace(".", ""));
            }
            
        }

        private void textBox_GiamGia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_GiamGia.Text.Trim()))
            {
                error.SetError(textBox_GiamGia, "!");
            }
            else
            {
                error.SetError(textBox_GiamGia, null);
                GiamGia = int.Parse(textBox_GiamGia.Text);
            }
        }

        private void textBox_ThanhTien_Validating(object sender, CancelEventArgs e)
        {
             if (string.IsNullOrEmpty(textBox_ThanhTien.Text.Trim()))
            {
                error.SetError(textBox_ThanhTien, "!");
            }
            else
            {
                error.SetError(textBox_GiamGia, null);
                ThanhTien = double.Parse(textBox_ThanhTien.Text.Replace(".", ""));
            }
        }

        private void cb_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from tblLapTop";
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
                            if (cb_MaSP.Text == dataRow[0].ToString())
                            {
                                textBox_GiaBan.Text = dataRow[5].ToString();
                            }

                        }
                    }
                }

            }
           // TinhThanhTien();
        }
        public void upload_MaSP_Ban()
        {
            try
            {
                cb_MaSP.Items.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblLapTop";
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
                                cb_MaSP.Items.Add(dataRow[0]);

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }
        private void TinhThanhTien()
        {
            object sender=new object();
            CancelEventArgs luu = new CancelEventArgs();

            check_validating(sender, luu);
            if (!string.IsNullOrEmpty(textBox_GiaBan.Text) && !string.IsNullOrEmpty(textBox_SoLuong.Text) && !string.IsNullOrEmpty(textBox_GiamGia.Text)
               && !string.IsNullOrEmpty(cb_MaSP.Text.Trim()))
            {
                // Lấy giá trị từ các textbox
                double GiaBan = double.Parse(textBox_GiaBan.Text.Replace(".", ""));
                double soLuong = Convert.ToDouble(textBox_SoLuong.Text);
                int giamGia = int.Parse(textBox_GiamGia.Text);
                // Tính toán thành tiền
                double thanhTien = (GiaBan * soLuong) - (GiaBan * soLuong * giamGia / 100);
                // Hiển thị kết quả vào textbox "thành tiền"
                textBox_ThanhTien.Text = thanhTien.ToString();
            }
            else
            {
                // Nếu một trong hai textbox rỗng, đặt textbox "thành tiền" thành rỗng
                textBox_ThanhTien.Text = "";
                textBox_ThanhTien.ReadOnly = true;
            }
        }

        private void textBox_SoLuong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()))
            {
                error.SetError(textBox_SoLuong, "!");
            }
            else
            {
                error.SetError(textBox_SoLuong, null);
                SoLuong = int.Parse(textBox_SoLuong.Text);
            }
        }

        private void textBox_GiaBan_TextChanged(object sender, EventArgs e)
        {
            //TinhThanhTien();
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

        private void textBox_GiamGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void button_Xua_Click(object sender, EventArgs e)
        {
            CancelEventArgs luu = new CancelEventArgs();
            dgv_CTHD.Rows.Clear();
            check_validating(sender, luu);
            if (!string.IsNullOrEmpty(comboBox_MaHD.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim())
                && !string.IsNullOrEmpty(textBox_ThanhTien.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiamGia.Text.Trim())
                && !string.IsNullOrEmpty(cb_MaSP.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool suaHD= chitietHD.update_ChiTietHD_Ban(MaHD, cb_MaSP.Text.Trim(), GiaBan, SoLuong, GiamGia);
                    if (suaHD)
                    {
                        MessageBox.Show("Sửa thành công");

                    }
                    else MessageBox.Show("sửa không thành công");
                    // đưa các ô nhập liệu về rỗng
                    reset_all_text();
                    dgv_CTHD.Rows.Clear();
                    chon_hien_PhieuNhap(onechoice);
                }  
                
            }
        }
        public void reset_all_text()
        {
                    comboBox_MaHD.Text = string.Empty;
                    cb_MaSP.Text = string.Empty;
                    textBox_GiaBan.Text = string.Empty;
                    textBox_ThanhTien.Text = string.Empty;
                    textBox_SoLuong.Text = string.Empty;
                    textBox_GiamGia.Text = string.Empty;
        }

        private void dgv_CTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dgv_CTHD.ClearSelection();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex <= 5)
            {
                DataGridViewCell dataGridViewCell = dgv_CTHD[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    //  error.SetError(textBox_maNV, null);
                    DataGridViewRow row = dgv_CTHD.Rows[e.RowIndex];
                    comboBox_MaHD.Text = row.Cells[0].Value.ToString();
                    cb_MaSP.Text = row.Cells[1].Value.ToString();
                    textBox_GiaBan.Text = row.Cells[2].Value.ToString();
                    textBox_SoLuong.Text = row.Cells[3].Value.ToString();
                    textBox_GiamGia.Text = row.Cells[4].Value.ToString();
                    textBox_ThanhTien.Text = row.Cells[5].Value.ToString();
                }
                else
                {
                    chitietHD.hien_ChiTietHD_Ban(dgv_CTHD);
                }

            }
            dgv_CTHD.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            CancelEventArgs luu = new CancelEventArgs();
            dgv_CTHD.Rows.Clear();
            check_validating(sender, luu);
            if (!string.IsNullOrEmpty(comboBox_MaHD.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiaBan.Text.Trim())
                && !string.IsNullOrEmpty(textBox_ThanhTien.Text.Trim()) && !string.IsNullOrEmpty(textBox_GiamGia.Text.Trim())
                && !string.IsNullOrEmpty(cb_MaSP.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    chitietHD.xoa_ChiTietHD_Ban(MaHD, cb_MaSP.Text.Trim());                 
                    // đưa các ô nhập liệu về rỗng
                    reset_all_text();
                    dgv_CTHD.Rows.Clear();
                    chon_hien_PhieuNhap(onechoice);
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("đã hủy yêu cầu");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset_all_text();
        }
        public void chi_tietHD_Mua_hien_theoMaHD(double MaHD)
        {
            object sender =new object();
            dgv_CTHD.Rows.Clear();

            comboBox_MaHD.Text = MaHD.ToString();
            CancelEventArgs luu = new CancelEventArgs();
            check_validating(sender, luu);
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "hien_ChitietMua_theoMa";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@iCTHDMH", MaHD);
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
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dgv_CTHD);
                                row.Cells[0].Value = dataRow[0].ToString();
                                row.Cells[1].Value = dataRow[1].ToString();
                                row.Cells[2].Value = dataRow[3].ToString();
                                row.Cells[3].Value = dataRow[4].ToString();
                                row.Cells[4].Value = dataRow[5].ToString();
                                row.Cells[5].Value = dataRow[6].ToString();
                                dgv_CTHD.Rows.Add(row);
                            }
                        }
                    }
                }
                

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }
        public void chon_hien_PhieuNhap(double chon)
        {
            if (chon == 0)
            {
                reset_all_text();
                dgv_CTHD.Rows.Clear();
                chitietHD.hien_ChiTietHD_Ban(dgv_CTHD);
            }
            else {
               
                cb_MaSP.Text = string.Empty;
                textBox_GiaBan.Text = string.Empty;
                textBox_ThanhTien.Text = string.Empty;
                textBox_SoLuong.Text = string.Empty;
                textBox_GiamGia.Text = string.Empty;
                chi_tietHD_Mua_hien_theoMaHD(MaHD);
                    } 
        }

        private void textBox_ThanhTien_TextChanged(object sender, EventArgs e)
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

            textBox.TextChanged -= textBox_ThanhTien_TextChanged;
            textBox.Text = formattedText;
            textBox.TextChanged += textBox_ThanhTien_TextChanged;
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
        public void select_MaHD()
        {
            comboBox_MaHD.Items.Clear();
            try
            {
                if (onechoice == 0)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "select * from tblHoaDonMuaHang";
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
                                    comboBox_MaHD.Items.Add(dataRow[0]);

                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }
        
        private void comboBox_MaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (onechoice == 0)
            {
                chitietHD.cho_Nhap_So(e);
            }
            else chitietHD.khongcho_nhap_tu_banphim(e);
        }
    }
    
}
