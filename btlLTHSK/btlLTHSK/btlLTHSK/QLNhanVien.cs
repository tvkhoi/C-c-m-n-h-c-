using btlLTHSK.Cry;
using btlLTHSK.Resources;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace btlLTHSK
{

    public partial class QLNhanVien : Form
    {
        double phucap = 0;
        double luong = 0;
        NhanVien nhan_vien = new NhanVien();
        ErrorProvider error = new ErrorProvider();
        public QLNhanVien()
        {
            InitializeComponent();
        }




        private void textBox_Ten_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Ten.Text.Trim()))
            {
                error.SetError(textBox_Ten, "Tên nhân viên không được để trống!");
            }
            else
            {
                error.SetError(textBox_Ten, null);
            }
        }

        private void textBox_DiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_DiaChi.Text.Trim()))
            {
                error.SetError(textBox_DiaChi, "Địa chỉ không được để trống!");
            }
            else
            {
                error.SetError(textBox_DiaChi, null);
            }
        }

        private void textBox_SDT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SDT.Text.Trim()))
            {
                error.SetError(textBox_SDT, "Số điện thoại không được để trống!");
            }
            else
            {
                error.SetError(textBox_SDT, null);
            }
        }

        private void textBox_luong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_luong.Text.Trim()))
            {
                error.SetError(textBox_luong, "Lương không được để trống!");
            }
            else
            {

                error.SetError(textBox_luong, null);
                luong = double.Parse(textBox_luong.Text.Replace(".", ""));
            }

        }

        private void textBox_phu_cap_Validating(object sender, CancelEventArgs e)
        {

        }
        private void textBox_MaNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_maNV.Text.Trim()))
            {
                error.SetError(textBox_maNV, "Mã nhân viên không được để trống!");
            }
            else
            {

                error.SetError(textBox_maNV, null);
                bool kiemtra = nhan_vien.kiemtra_maNV(textBox_maNV.Text.ToString(), error, textBox_maNV);
            }
        }
        private void button_ThemNV_Click(object sender, EventArgs e)
        {
            string gioitinh = string.Empty;

            //Làm mới datagridView sau mới lần thêm
            dataGridView_NhanVien.Rows.Clear();
            CancelEventArgs g = new CancelEventArgs();
            textBox_phu_cap_Validating(sender, g);
            textBox_luong_Validating(sender, g);
            textBox_DiaChi_Validating(sender, g);
            textBox_SDT_Validating(sender, g);
            textBox_Ten_Validating(sender, g);
            textBox_MaNV_Validating(sender, g);
            if (radioButton_GT_Nam.Checked == false && radioButton_GT_Nu.Checked == false)
            {
                error.SetError(radioButton_GT_Nu, "Vui lòng chọn giới tính!");
            }
            else
            {
                if (radioButton_GT_Nam.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
                error.SetError(radioButton_GT_Nu, null);
            }
            DateTime selectedDate1 = dateTimePicker_NgaySinh.Value;
            DateTime justDate1 = selectedDate1.Date; // Lấy ngày sinh

            DateTime selectedDate2 = dateTimePicker1_ngay_vao_lam.Value;
            DateTime justDate2 = selectedDate2.Date; // Lấy ngày bắt đầu làm việc

            if ((justDate2 - justDate1).TotalDays / 365.25 >= 18)
            {
                error.SetError(dateTimePicker1_ngay_vao_lam, null);
            }
            else
            {
                error.SetError(dateTimePicker1_ngay_vao_lam, "Ngày sinh phải lơn hơn 18 tuổi!");
            }



            DateTime dateTime = Convert.ToDateTime(dateTimePicker_NgaySinh.Text);
            string sNgaySinh = dateTime.ToString("yyyy/MM/dd");
            DateTime dateTime_ngayvaolam = Convert.ToDateTime(dateTimePicker1_ngay_vao_lam.Text);
            string ngayvaolam = dateTime_ngayvaolam.ToString("yyyy/MM/dd");
            // kiểm tra mã nhân viên đã tồn tại chưa

            bool them = nhan_vien.ThemSinhVien(textBox_maNV.Text.ToString(), textBox_Ten.Text.ToString(), gioitinh, textBox_DiaChi.Text.ToString(), textBox_SDT.Text.ToString(), sNgaySinh, ngayvaolam, luong, phucap);

            if (them)
            {
                MessageBox.Show("Thêm thành công");
                error.SetError(textBox_maNV, null);
                // đưa các ô nhập liệu về rỗng
                textBox_maNV.Text = string.Empty;
                textBox_Ten.Text = string.Empty;
                textBox_SDT.Text = string.Empty;
                textBox_DiaChi.Text = string.Empty;
                textBox_luong.Text = string.Empty;
                textBox_phu_cap.Text = string.Empty;
                radioButton_GT_Nam.Checked = false;
                radioButton_GT_Nu.Checked = false;
                dateTimePicker_NgaySinh.Value = DateTime.Now;
                dateTimePicker1_ngay_vao_lam.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
            nhan_vien.hien_NhanVien(dataGridView_NhanVien);

        }

        private void textBox_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải số hoặc vượt quá 10 số
            }

            // Kiểm tra độ dài của chuỗi số điện thoại sau khi thêm ký tự mới
            if (char.IsDigit(e.KeyChar) && textBox_SDT.Text.Replace(" ", "").Length >= 10)
            {
                e.Handled = true; // Nếu đã có 10 số, ngăn không cho thêm số nữa
            }
        }

        private void textBox_SDT_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải số hoặc vượt quá 10 số
            }
        }

        private void textBox_luong_TextChanged(object sender, EventArgs e)
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

            textBox.TextChanged -= textBox_luong_TextChanged;
            textBox.Text = formattedText;
            textBox.TextChanged += textBox_luong_TextChanged;

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



        private void textBox_phu_cap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải số hoặc vượt quá 10 số
            }
        }
        private void textBox_phu_cap_TextChanged(object sender, EventArgs e)
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
                    formattedText = "." + formattedText;
                    separatorCount++;
                }
                formattedText = cleanText[cleanText.Length - i - 1] + formattedText;
            }

            // Xóa kí tự đầu tiên nếu là dấu phân cách hàng nghìn
            if (formattedText.StartsWith("."))
            {
                formattedText = formattedText.Substring(1);
                caretPosition--;
                separatorCount--;
            }

            textBox.TextChanged -= textBox_phu_cap_TextChanged;
            textBox.Text = formattedText;
            textBox.TextChanged += textBox_phu_cap_TextChanged;

            // Đặt vị trí con trỏ
            textBox.SelectionStart = caretPosition + separatorCount;

            // Xử lý chuyển đổi chuỗi đã định dạng thành double
            double parsedValue;
            if (double.TryParse(Regex.Replace(formattedText, @"\.", ""), out parsedValue))
            {
                phucap = parsedValue;
            }
            else
            {
                // Xử lý trường hợp không thể chuyển đổi thành double, ví dụ thông báo hoặc hành động khác tùy thuộc vào yêu cầu của bạn.
            }
        }


        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            nhan_vien.hien_NhanVien(dataGridView_NhanVien);
        }

        private void dataGridView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_NhanVien.ClearSelection();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell dataGridViewCell = dataGridView_NhanVien[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    error.SetError(textBox_maNV, null);
                    DataGridViewRow row = dataGridView_NhanVien.Rows[e.RowIndex];
                    textBox_maNV.Text = row.Cells[0].Value.ToString();
                    textBox_Ten.Text = row.Cells[1].Value.ToString();
                    string gioitinh = row.Cells[2].Value.ToString();
                    if (gioitinh == "Nam")
                    {
                        radioButton_GT_Nam.Checked = true;
                    }
                    else
                    {
                        radioButton_GT_Nu.Checked = true;
                    }
                    textBox_DiaChi.Text = row.Cells[3].Value.ToString();
                    textBox_SDT.Text = row.Cells[4].Value.ToString();
                    dateTimePicker_NgaySinh.Text = row.Cells[5].Value.ToString();
                    dateTimePicker1_ngay_vao_lam.Text = row.Cells[6].Value.ToString();
                    textBox_luong.Text = row.Cells[7].Value.ToString();
                    textBox_phu_cap.Text = row.Cells[8].Value.ToString();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }

            }



        }

        private void button_SuaNV_Click(object sender, EventArgs e)
        {
            // kiểm tra nếu rỗng thì không xóa được
            if (!string.IsNullOrEmpty(textBox_maNV.Text.Trim()) && !string.IsNullOrEmpty(textBox_Ten.Text.Trim())
               && !string.IsNullOrEmpty(textBox_SDT.Text.Trim()) && !string.IsNullOrEmpty(textBox_DiaChi.Text.Trim())
               && !string.IsNullOrEmpty(textBox_luong.Text.Trim()) && (radioButton_GT_Nam.Checked == true || radioButton_GT_Nu.Checked == true)
               && !string.IsNullOrEmpty(dateTimePicker_NgaySinh.Text.Trim()) && !string.IsNullOrEmpty(dateTimePicker1_ngay_vao_lam.Text.Trim()))
            {


                int loi = 0;
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Kiểm tra đã thỏa mã điều kiện chưa
                    if (radioButton_GT_Nam.Checked == false && radioButton_GT_Nu.Checked == false)
                    {
                        error.SetError(radioButton_GT_Nu, "Vui lòng chọn giới tính!");
                        loi--;
                    }
                    else
                    {
                        error.SetError(radioButton_GT_Nu, null);
                    }
                    DateTime selectedDate1 = dateTimePicker_NgaySinh.Value;
                    DateTime justDate1 = selectedDate1.Date; // Lấy ngày sinh

                    DateTime selectedDate2 = dateTimePicker1_ngay_vao_lam.Value;
                    DateTime justDate2 = selectedDate2.Date; // Lấy ngày bắt đầu làm việc

                    if ((justDate2 - justDate1).TotalDays / 365.25 >= 18)
                    {
                        error.SetError(dateTimePicker1_ngay_vao_lam, null);
                    }
                    else
                    {
                        error.SetError(dateTimePicker1_ngay_vao_lam, "Ngày sinh phải lơn hơn 18 tuổi!");
                        loi--;
                    }

                    if (loi == 0)
                    {
                        // Sử lí khi update
                        string gioitinh = string.Empty;
                        double luong = 0;
                        double phu = 0;
                        luong = double.Parse(Regex.Replace(textBox_luong.Text, @"\.", ""));
                        if (textBox_phu_cap.Text == "0")
                        {
                            phu = 0;
                        }
                        else
                        {
                            phu = double.Parse(textBox_phu_cap.Text.Replace(".", ""));
                        }
                        if (radioButton_GT_Nam.Checked == true)
                        {
                            gioitinh = "Nam";
                        }
                        else
                        {
                            gioitinh = "Nữ";
                        }
                        DateTime dateTime = Convert.ToDateTime(dateTimePicker_NgaySinh.Text);
                        string sNgaySinh = dateTime.ToString("yyyy/MM/dd");
                        DateTime dateTime_ngayvaolam = Convert.ToDateTime(dateTimePicker1_ngay_vao_lam.Text);
                        string ngayvaolam = dateTime_ngayvaolam.ToString("yyyy/MM/dd");
                        nhan_vien.update_NhanVien(textBox_maNV.Text.Trim(), textBox_Ten.Text.Trim()
                            , gioitinh, textBox_DiaChi.Text.Trim(), textBox_SDT.Text.Trim()
                            , sNgaySinh, ngayvaolam
                            , luong, phu);
                        // đưa các ô nhập liệu về rỗng
                        textBox_maNV.Text = string.Empty;
                        textBox_Ten.Text = string.Empty;
                        textBox_SDT.Text = string.Empty;
                        textBox_DiaChi.Text = string.Empty;
                        textBox_luong.Text = string.Empty;
                        textBox_phu_cap.Text = string.Empty;
                        radioButton_GT_Nam.Checked = false;
                        radioButton_GT_Nu.Checked = false;
                        dateTimePicker_NgaySinh.Value = DateTime.Now;
                        dateTimePicker1_ngay_vao_lam.Value = DateTime.Now;
                        dataGridView_NhanVien.Rows.Clear();
                        nhan_vien.hien_NhanVien(dataGridView_NhanVien);

                    }
                    else
                    {

                    }
                }
            }
        }

        private void button_XoaNV_Click(object sender, EventArgs e)
        {
            // kiểm tra nếu rỗng thì không xóa được
            if (!string.IsNullOrEmpty(textBox_maNV.Text.Trim()) && !string.IsNullOrEmpty(textBox_Ten.Text.Trim())
               && !string.IsNullOrEmpty(textBox_SDT.Text.Trim()) && !string.IsNullOrEmpty(textBox_DiaChi.Text.Trim())
               && !string.IsNullOrEmpty(textBox_luong.Text.Trim()) && (radioButton_GT_Nam.Checked == true || radioButton_GT_Nu.Checked == true)
               && !string.IsNullOrEmpty(dateTimePicker_NgaySinh.Text.Trim()) && !string.IsNullOrEmpty(dateTimePicker1_ngay_vao_lam.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string gioitinh = string.Empty;
                    double luong = 0;
                    double phu = 0;
                    luong = double.Parse(Regex.Replace(textBox_luong.Text, @"\.", ""));
                    if (textBox_phu_cap.Text == "0")
                    {
                        phu = 0;
                    }
                    else
                    {
                        phu = double.Parse(textBox_phu_cap.Text.Replace(".", ""));
                    }
                    if (radioButton_GT_Nam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    else
                    {
                        gioitinh = "Nữ";
                    }
                    DateTime dateTime = Convert.ToDateTime(dateTimePicker_NgaySinh.Text);
                    string sNgaySinh = dateTime.ToString("yyyy/MM/dd");
                    DateTime dateTime_ngayvaolam = Convert.ToDateTime(dateTimePicker1_ngay_vao_lam.Text);
                    string ngayvaolam = dateTime_ngayvaolam.ToString("yyyy/MM/dd");
                    nhan_vien.xoa_Nhanvien(textBox_maNV.Text.Trim(), textBox_Ten.Text.Trim()
                        , gioitinh, textBox_DiaChi.Text.Trim(), textBox_SDT.Text.Trim()
                        , sNgaySinh, ngayvaolam
                        , luong, phu);
                    // đưa các ô nhập liệu về rỗng
                    textBox_maNV.Text = string.Empty;
                    textBox_Ten.Text = string.Empty;
                    textBox_SDT.Text = string.Empty;
                    textBox_DiaChi.Text = string.Empty;
                    textBox_luong.Text = string.Empty;
                    textBox_phu_cap.Text = string.Empty;
                    radioButton_GT_Nam.Checked = false;
                    radioButton_GT_Nu.Checked = false;
                    dateTimePicker_NgaySinh.Value = DateTime.Now;
                    dateTimePicker1_ngay_vao_lam.Value = DateTime.Now;
                    dataGridView_NhanVien.Rows.Clear();
                    nhan_vien.hien_NhanVien(dataGridView_NhanVien);
                }
                else
                {
                    // đóng
                }
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            // đưa các ô nhập liệu về rỗng
            textBox_maNV.Text = string.Empty;
            textBox_Ten.Text = string.Empty;
            textBox_SDT.Text = string.Empty;
            textBox_DiaChi.Text = string.Empty;
            textBox_luong.Text = string.Empty;
            textBox_phu_cap.Text = string.Empty;
            radioButton_GT_Nam.Checked = false;
            radioButton_GT_Nu.Checked = false;
            dateTimePicker_NgaySinh.Value = DateTime.Now;
            dateTimePicker1_ngay_vao_lam.Value = DateTime.Now;

            error.SetError(textBox_maNV, null);
            error.SetError(textBox_Ten, null);
            error.SetError(textBox_SDT, null);
            error.SetError(textBox_luong, null);
            error.SetError(textBox_phu_cap, null);
            error.SetError(dateTimePicker1_ngay_vao_lam, null);
            error.SetError(radioButton_GT_Nu, null);
        }

        private void dateTimePicker_NgaySinh_Validating(object sender, CancelEventArgs e)
        {
            DateTime selectedDate1 = dateTimePicker_NgaySinh.Value;
            DateTime justDate1 = selectedDate1.Date; // Lấy ngày sinh

            DateTime selectedDate2 = dateTimePicker1_ngay_vao_lam.Value;
            DateTime justDate2 = selectedDate2.Date; // Lấy ngày bắt đầu làm việc

            if ((justDate2 - justDate1).TotalDays / 365.25 >= 18)
            {
                error.SetError(dateTimePicker1_ngay_vao_lam, null);
            }
            else
            {
                error.SetError(dateTimePicker1_ngay_vao_lam, "Ngày sinh phải lơn hơn 18 tuổi!");
            }
        }



        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string texbox_tk = comboBox_Timkiem.Items[comboBox_Timkiem.SelectedIndex].ToString();
            if (texbox_tk == "Mã Nhân Viên")
            {
                nhan_vien.tim_kiem_NhanVien_duavaoMa(textBox_TimKiem.Text, dataGridView_NhanVien);
            }
            else if (texbox_tk == "Tên Nhân Viên")
            {
                nhan_vien.tim_kiem_NhanVien_duavaoTen(textBox_TimKiem.Text, dataGridView_NhanVien);
            }
            else if (texbox_tk == "Địa Chỉ")
            {
                nhan_vien.tim_kiem_NhanVien_duavaoDiaChi(textBox_TimKiem.Text, dataGridView_NhanVien);
            }

        }

        private void button_baocao_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "in_bao_cao_nv";
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        thongke_NV cry = new thongke_NV();
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
