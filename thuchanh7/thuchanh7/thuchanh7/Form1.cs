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
    public partial class Form1 : Form, IChuyenDuLieu
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
            Form2 form2_VTL = new Form2(this,cbb_mabenhnhan_VTL.Text);
            form2_VTL.Show();
        }
        string str_VTL = "Data Source = DESKTOP-BHIGK0R\\SQLEXPRESS; Initial Catalog= KT;Integrated Security=True;";
        private DataTable dtSINHVIEN_MaBN_VTL = new DataTable(); // DataTable cho MaBN
        private DataTable dtSINHVIEN_DichVu_VTL = new DataTable(); // DataTable cho DichVu
        private int previousSelectedIndex_VTL = -1; // Biến lưu trữ chỉ mục trước đó
        public Form1()
        {
            InitializeComponent();
            LoadDataToComboBox();
            LoadDataToComboBox1();
            tb_dsdv_VTL.Text = "";
            b_VTL = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        }

        private void LoadDataToComboBox()
        {
            string queryStr = "hienmabenhnhan1";
            using (SqlConnection conn = new SqlConnection(str_VTL))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
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
            string queryStr = "hienchondichvu";
            using (SqlConnection conn = new SqlConnection(str_VTL))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
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
                string selectedMaBN = cbb_mabenhnhan_VTL.SelectedValue.ToString(); // Sử dụng SelectedValue thay vì ToString()
                string queryStr = "SELECT TenBN_VTL FROM tblBenhNhan_VTL WHERE MaBN_VTL = @MaBN_VTL";
                using (SqlConnection conn = new SqlConnection(str_VTL))
                {
                    using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaBN_VTL", selectedMaBN);
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
                using (SqlConnection conn = new SqlConnection(str_VTL))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
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
            int ngay_VTL = int.Parse(tb_ngay_VTL.Text);
            int thang_VTL = int.Parse(tb_thang_VTL.Text);
            int nam_VTL = int.Parse(tb_nam_VTL.Text);

            // Tạo một đối tượng DateTime từ các giá trị ngày, tháng, năm
            DateTime ngayKham_VTL = new DateTime(nam_VTL, thang_VTL, ngay_VTL);

            // Mở kết nối đến cơ sở dữ liệu và thực thi câu lệnh SQL
            using (SqlConnection conn = new SqlConnection(str_VTL))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO tblHopDong_VTL (Ngay_VTL, MaBN_VTL, DichVu_VTL) VALUES (@Ngay_VTL, @MaBN_VTL, @DichVu_VTL)";
                    cmd.Parameters.AddWithValue("@Ngay_VTL", ngayKham_VTL); // Sử dụng ngày hiện tại
                    cmd.Parameters.AddWithValue("@MaBN_VTL", cbb_mabenhnhan_VTL.Text.ToString());
                    cmd.Parameters.AddWithValue("@DichVu_VTL", b_VTL);
                    int rowsAffected = cmd.ExecuteNonQuery();
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
            string checkID_proc = "checkID_proc";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connection;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    //cmd.Connection= conn;
                    cmd.CommandText = checkID_proc;
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
    }
}
