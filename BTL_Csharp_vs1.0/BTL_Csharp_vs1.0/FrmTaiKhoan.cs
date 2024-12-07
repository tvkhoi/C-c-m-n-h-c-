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
using System.Xml.Linq;

namespace BTL_Csharp_vs1._0
{
    public partial class FrmTaiKhoan : Form
    {
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            LayDsNV();
            LayRole();
            HienTk();
        }
        private void LayDsNV()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from TblNhanVien", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txtNV.DataSource = tb;
                        txtNV.DisplayMember = "sTenNV";
                        txtNV.ValueMember = "sMaNV";


                    }
                }
            }
        }
        private void LayRole()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT [sQuyenNv]\r\nFROM [dbo].[TblTaiKhoan];", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txtRole.DataSource = tb;
                        txtRole.DisplayMember = "sQuyenNv";



                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNV.Text = grvTaiKhoan.CurrentRow.Cells["Tên Nhân Viên"].Value.ToString();
            txtRole.Text = grvTaiKhoan.CurrentRow.Cells["Quyền"].Value.ToString();
            txtTK.Text = grvTaiKhoan.CurrentRow.Cells["Tên Đăng Nhập"].Value.ToString();
            txtPw.Text = grvTaiKhoan.CurrentRow.Cells["Mật Khẩu"].Value.ToString();
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNV.Text = grvTaiKhoan.CurrentRow.Cells["Tên Nhân Viên"].Value.ToString();
            txtRole.Text = grvTaiKhoan.CurrentRow.Cells["Quyền"].Value.ToString();
            txtTK.Text = grvTaiKhoan.CurrentRow.Cells["Tên Đăng Nhập"].Value.ToString();
            txtPw.Text = grvTaiKhoan.CurrentRow.Cells["Mật Khẩu"].Value.ToString();
        }

        private void HienTk()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_TaiKhoan", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        grvTaiKhoan.DataSource = tb;


                    }
                }
            }

        }
        public void insertTK()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("ThemTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", txtNV.SelectedValue.ToString());
                        bool i = kiemtra2Key(Key1: txtNV.Text, TableName: "TblTaiKhoan", NameColumnKey1: "sMaNV", Key2: txtTK.Text , NameColumnKey2: "sTenDangNhap");
                        if (i == true)
                        {
                            MessageBox.Show("Tài Khoản Đã Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTK.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtPw.Text);
                        cmd.Parameters.AddWithValue("@QuyenNv", txtRole.Text);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                            HienTk();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static bool kiemtra2Key(string Key1, string Key2, string TableName, string NameColumnKey1, string NameColumnKey2)
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            string KiemTraPK = "SELECT * FROM " + TableName + " WHERE " + NameColumnKey1 + "= '" + Key1 + "' and " + NameColumnKey2 + "= '" + Key2 + "'";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(KiemTraPK, conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertTK();

        }
        public void UpdateTk()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SuaTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", txtNV.SelectedValue.ToString());
                        bool i = kiemtra2Key(Key1: txtNV.Text, TableName: "TblTaiKhoan", NameColumnKey1: "sMaNV", Key2: txtTK.Text, NameColumnKey2: "sTenDangNhap");
                        if (i == false)
                        {
                            MessageBox.Show("Tài Khoản không Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTK.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtPw.Text);
                        cmd.Parameters.AddWithValue("@QuyenNv", txtRole.Text);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("sửa thành công");
                            HienTk();
                        }
                        else
                        {
                            MessageBox.Show("sửa thất bại");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            UpdateTk();
        }
        public void xoaTK()
        {
            bool i = kiemtra2Key(Key1: txtNV.Text, TableName: "TblTaiKhoan", NameColumnKey1: "sMaNV", Key2: txtTK.Text, NameColumnKey2: "sTenDangNhap");
            if (i == false)
            {
                MessageBox.Show("Tài Khoản không Tồn Tại");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Tài Khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
                try
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("XoaTaiKhoan", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaNV", txtNV.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@TenDangNHap", txtTK.Text);


                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                                HienTk();
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xoaTK();
        }
    }
}
