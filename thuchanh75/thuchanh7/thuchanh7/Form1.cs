using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace thuchanh7
{
    public partial class Form1_VTL : Form, IChuyenDuLieu
    {
        public void XyLyDuLieu(string value1_VTL, string value2_VTL, string value3_VTL, string value4_VTL, string value5_VTL, string value6_VTL)
        {
            if (value1_VTL != null)
            {
                cbb_mabenhnhan_VTL.Text = value1_VTL;
            }
            else
            {
                cbb_mabenhnhan_VTL.Text = string.Empty;
            }
            if (value2_VTL != null)
            {
                tb_ngay_VTL.Text = value2_VTL;
            }
            else
            {
                tb_ngay_VTL.Text = string.Empty;
            }
            if (value3_VTL != null)
            {
                tb_thang_VTL.Text = value3_VTL;
            }
            else
            {
                tb_thang_VTL.Text = string.Empty;
            }
            if (value4_VTL != null)
            {
                tb_nam_VTL.Text = value4_VTL;
            }
            else
            {
                tb_nam_VTL.Text = string.Empty;
            }
            if (value5_VTL != null)
            {
                tb_dsdv_VTL.Text = value5_VTL;
            }
            else
            {
                tb_dsdv_VTL.Text = string.Empty;
            }
            if (value6_VTL != null)
            {
                tb_ketqua_VTL.Text = value6_VTL;
            }
            else
            {
                tb_ketqua_VTL.Text = string.Empty;
            }
        }
        private void ptb_icon_VTL_Click(object sender, EventArgs e)
        {
            Form2_VTL form2_VTL = new Form2_VTL(this, cbb_mabenhnhan_VTL.Text);
            form2_VTL.Show();
        }
        string str_VTL = "Data Source = DESKTOP-BHIGK0R\\SQLEXPRESS; Initial Catalog= KT;Integrated Security=True;";
        public Form1_VTL()
        {
            InitializeComponent();
            LoadDataToComboBox();
            LoadDataToComboBox1();
            cbb_mabenhnhan_VTL.Text = null;
            cbb_chondichvu_VTL.Text = null;
            tb_dsdv_VTL.Text = "";
            b_VTL = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoadDataToComboBox()
        {
            string queryStr_VTL = "hienmabenhnhan1";
            using (SqlConnection conn_VTL = new SqlConnection(str_VTL))
            {
                using (SqlCommand cmd_VTL = new SqlCommand(queryStr_VTL, conn_VTL))
                {
                    cmd_VTL.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd_VTL;
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            cbb_mabenhnhan_VTL.DataSource = dt;
                            cbb_mabenhnhan_VTL.DisplayMember = "MaBN_VTL";
                            cbb_mabenhnhan_VTL.ValueMember = "MaBN_VTL";
                        }
                        else
                        {
                            MessageBox.Show("Không có bệnh nhân nào trong cơ sở dữ liệu.");
                        }
                    }
                }
            }
        }
        private void LoadDataToComboBox1()
        {
            string queryStr_VTL = "hienchondichvu";
            using (SqlConnection conn_VTL = new SqlConnection(str_VTL))
            {
                using (SqlCommand cmd_VTL = new SqlCommand(queryStr_VTL, conn_VTL))
                {
                    cmd_VTL.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd_VTL;
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            cbb_chondichvu_VTL.DataSource = dt;
                            cbb_chondichvu_VTL.DisplayMember = "TenDV_VTL";
                            cbb_chondichvu_VTL.ValueMember = "TenDV_VTL";
                        }
                        else
                        {
                            MessageBox.Show("Không có dịch vụ nào trong cơ sở dữ liệu.");
                        }
                    }
                }
            }
        }

        private void cmb_mabenhnhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_mabenhnhan_VTL.SelectedValue != null)
            {
                string selectedMaBN_VTL = cbb_mabenhnhan_VTL.SelectedValue.ToString(); // Sử dụng SelectedValue thay vì ToString()
                string queryStr_VTL = "SELECT TenBN_VTL FROM tblBenhNhan_VTL WHERE MaBN_VTL = @MaBN_VTL";
                using (SqlConnection conn = new SqlConnection(str_VTL))
                {
                    using (SqlCommand cmd = new SqlCommand(queryStr_VTL, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaBN_VTL", selectedMaBN_VTL);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        conn.Close();
                        if (result != null)
                        {
                            tb_tenbenhnhan_VTL.Text = result.ToString();
                        }
                    }
                }
            }

        }
        string b_VTL = "";
        private void cmb_chondichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbb_chondichvu_VTL.Text))
            {
                string g_VTL = cbb_chondichvu_VTL.Text;
                tb_dsdv_VTL.Text += $"{g_VTL} .";

                if (!string.IsNullOrEmpty(b_VTL))
                {
                    b_VTL += $", {g_VTL}";
                }
                else
                {
                    b_VTL = g_VTL;
                }
            }
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            int ngay_VTL = int.Parse(tb_ngay_VTL.Text);
            int thang_VTL = int.Parse(tb_thang_VTL.Text);
            int nam_VTL = int.Parse(tb_nam_VTL.Text);
            DateTime ngayKham_VTL = new DateTime(nam_VTL, thang_VTL, ngay_VTL);
            if (CheckExistingContract(cbb_mabenhnhan_VTL.Text, ngayKham_VTL))
            {
                MessageBox.Show("Một bệnh nhân trong 1 ngày sẽ chỉ có 1 hợp đồng!");
                return; // Không thực hiện thêm mới
            }
            string a_VTL = "";
            a_VTL += $"Tên bệnh nhân: {tb_tenbenhnhan_VTL.Text}\r\n\n";
            a_VTL += $"Ngày khám: {tb_ngay_VTL.Text}/{tb_thang_VTL.Text}/{tb_nam_VTL.Text}\r\n\n";
            a_VTL += $"Dịch vụ khám: {b_VTL}\r\n\n";
            tb_ketqua_VTL.Text = a_VTL;
            string l_VTL = cbb_mabenhnhan_VTL.Text;
            if (KiemTraKhoaChinh_SinhVien(str_VTL, l_VTL) == true)
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại!");
            }
            else
            {
                using (SqlConnection conn_VTL = new SqlConnection(str_VTL))
                {
                    conn_VTL.Open();
                    using (SqlCommand cmd = conn_VTL.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO tblBenhNhan_VTL (MaBN_VTL,TenBN_VTL) VALUES (@MaBN_VTL, @TenBN_VTL)";
                        cmd.Parameters.AddWithValue("@MaBN_VTL", cbb_mabenhnhan_VTL.Text);
                        cmd.Parameters.AddWithValue("@TenBN_VTL", tb_tenbenhnhan_VTL.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm mới thành công vào bảng tblBenhNhan");
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới không thành công");
                        }
                    }
                }

            }
            // Mở kết nối đến cơ sở dữ liệu và thực thi câu lệnh SQL
            using (SqlConnection conn_VTL = new SqlConnection(str_VTL))
            {
                conn_VTL.Open();
                using (SqlCommand cmd_VTL = conn_VTL.CreateCommand())
                {
                    cmd_VTL.CommandText = "INSERT INTO tblHopDong_VTL (Ngay_VTL, MaBN_VTL, DichVu_VTL) VALUES (@Ngay_VTL, @MaBN_VTL, @DichVu_VTL)";
                    cmd_VTL.Parameters.AddWithValue("@Ngay_VTL", ngayKham_VTL); // Sử dụng ngày hiện tại
                    cmd_VTL.Parameters.AddWithValue("@MaBN_VTL", cbb_mabenhnhan_VTL.Text.ToString());
                    cmd_VTL.Parameters.AddWithValue("@DichVu_VTL", b_VTL);
                    int rowsAffected = cmd_VTL.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm mới thành công vào bảng tblHopDong");
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới không thành công");
                    }
                }
            }
        }
        private static bool KiemTraKhoaChinh_SinhVien(string connection, string masv_VTL)
        {
            string checkID_proc_VTL = "checkID_proc";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connection;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    //cmd.Connection= conn;
                    cmd.CommandText = checkID_proc_VTL;
                    cmd.CommandType = CommandType.StoredProcedure;
                    //khoi tao doi tuong Parameter
                    cmd.Parameters.AddWithValue("@sMaBN_VTL", masv_VTL);
                    conn.Open();
                    bool i = (cmd.ExecuteScalar() != null); //true-> ma sv da ton tai
                    conn.Close();
                    if (i)
                    {

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void gpb_thongtinbenhnhan_VTL_Enter(object sender, EventArgs e)
        {

        }

        private void btn_thoat_VTL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tieptuc_VTL_Click(object sender, EventArgs e)
        {
            cbb_mabenhnhan_VTL.Text = null;
            cbb_chondichvu_VTL.Text = null;
            tb_dsdv_VTL.Text = null;
            tb_ketqua_VTL.Text = null;
            tb_ngay_VTL.Text = null;
            tb_thang_VTL.Text = null;
            tb_nam_VTL.Text = null;
            tb_tenbenhnhan_VTL.Text = null;
            b_VTL = null;
            err_VTL.SetError(tb_ngay_VTL, null);
            err_VTL.SetError(tb_thang_VTL, null);
            err_VTL.SetError(tb_nam_VTL, null);
        }

        private void tb_ngay_VTL_TextChanged(object sender, EventArgs e)
        {
            if (tb_ngay_VTL.Text != null)
            {
                if (int.TryParse(tb_ngay_VTL.Text, out int a) && a >= 1 && a <= 31)
                {
                    err_VTL.SetError(tb_ngay_VTL, null);
                }
                else
                {
                    err_VTL.SetError(tb_ngay_VTL, "Phải nhập bằng số trong khoảng 1 -> 31");
                }
            }
        }

        private void tb_thang_VTL_TextChanged(object sender, EventArgs e)
        {
            if (tb_thang_VTL.Text != null)
            {
                if (int.TryParse(tb_thang_VTL.Text, out int a) && a >= 1 && a <= 12)
                {
                    err_VTL.SetError(tb_thang_VTL, null);
                }
                else
                {
                    err_VTL.SetError(tb_thang_VTL, "Phải nhập bằng số trong khoảng 1 -> 12");
                }
            }
        }

        private void tb_nam_VTL_TextChanged(object sender, EventArgs e)
        {
            if (tb_nam_VTL.Text != null)
            {
                if (int.TryParse(tb_nam_VTL.Text, out int a) && a >= 1900 && a <= DateTime.Now.Year)
                {
                    err_VTL.SetError(tb_nam_VTL, null);
                }
                else
                {
                    err_VTL.SetError(tb_nam_VTL, "Phải nhập bằng số nhỏ hơn hoặc bằng năm hiện tại");
                }
            }
        }
        private bool CheckExistingContract(string maBN_VTL, DateTime ngayKham_VTL)
        {
            string query = "SELECT COUNT(*) FROM tblHopDong_VTL WHERE MaBN_VTL = @MaBN_VTL AND Ngay_VTL = @Ngay_VTL";
            using (SqlConnection conn = new SqlConnection(str_VTL))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBN_VTL", maBN_VTL);
                    cmd.Parameters.AddWithValue("@Ngay_VTL", ngayKham_VTL);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    conn.Close();
                    return count > 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}