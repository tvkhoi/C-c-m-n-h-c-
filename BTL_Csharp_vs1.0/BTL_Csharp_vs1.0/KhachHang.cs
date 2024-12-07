using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Csharp_vs1._0
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            hienKhachHang();
            btnReset.Click += btnReset_Click;
        }
        private void hienKhachHang()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_DsKH", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvKhachHang.DataSource = tb;
                    }
                }
            }
        }
        public static bool themKhachHang(string constr, string MaKH, string TenKH, string GioiTinh, string SDT, string DiaChi)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemKH";
                    cmd.Parameters.AddWithValue("@MaKH", MaKH);
                    cmd.Parameters.AddWithValue("@TenKH", TenKH);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public static bool xoaKhachHang(string constr, string MaKH)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_xoaKhachHang";
                    cmd.Parameters.AddWithValue("@MaKH", MaKH);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            string constr = ConfigurationManager.ConnectionStrings["QuanLyChQuanAo"].ConnectionString;

            string MaKH = txtMaKH.Text.Trim();
            string TenKH = txtTenKH.Text.Trim();
            string GioiTinh = (rbNam.Checked ? rbNam.Text : rbNu.Text);
            string SDT = txtSDT.Text.Trim();
            string DiaChi = txtDiaChi.Text.Trim();

            bool i = themKhachHang(constr, MaKH, TenKH, GioiTinh, SDT, DiaChi);

            if (i)
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                hienKhachHang();

            }
            else
            {
                MessageBox.Show("Thêm lỗi!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            string constr = ConfigurationManager.ConnectionStrings["QuanLyChQuanAo"].ConnectionString;

            string MaKH = txtMaKH.Text.Trim();
            string TenKH = txtTenKH.Text.Trim();
            string GioiTinh = (rbNam.Checked ? rbNam.Text : rbNu.Text);
            string SDT = txtSDT.Text.Trim();
            string DiaChi = txtDiaChi.Text.Trim();

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_suaKhachHang", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKH", MaKH);
                        cmd.Parameters.AddWithValue("@TenKH", TenKH);
                        cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                        cmd.Parameters.AddWithValue("@SDT", SDT);
                        cmd.Parameters.AddWithValue("@DiaChi", DiaChi);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Thông tin khách hàng đã được cập nhật!");
                        hienKhachHang();

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần xóa!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string MaKH = txtMaKH.Text;
                string constr = ConfigurationManager.ConnectionStrings["QuanLyChQuanAo"].ConnectionString;
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_xoaKhachHang", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaKH", MaKH);

                            con.Open();

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                                hienKhachHang();
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false;
            txtSDT.Clear();
            txtDiaChi.Clear();

            errorProvider1.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string constr = ConfigurationManager.ConnectionStrings["QuanLyChQuanAo"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = "SELECT * FROM TblKhachHang WHERE sMaKH LIKE @Keyword OR sTenKH LIKE @Keyword OR sGioiTinh LIKE @Keyword OR sSDT LIKE @Keyword OR sDiaChi LIKE @Keyword";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvKhachHang.DataSource = dt;
                    }
                }
            }
        }
    }
}
