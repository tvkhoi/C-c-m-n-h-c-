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
    public partial class FrmInsertNhanVien : Form
    {
        public FrmInsertNhanVien()
        {
            InitializeComponent();
        }

        private void FrmInsertNhanVien_Load(object sender, EventArgs e)
        {
            HienDSNV();
        }
        private void HienDSNV()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_DsNV order by [Mã Nhân Viên] ASC", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;


                    }
                }
            }

        }
        public static bool KiemTraEmailUnique(string email)
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            string query = "SELECT COUNT(*) FROM TblNhanVien WHERE sEmail = @Email";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count == 0; 
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNameNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string gender = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (gender == "Nam")
            {
                GT_Nam.Checked = true;
            }
            else if (gender == "Nữ")
            {
                GT_Nu.Checked = true;
            }
            txt_Birthday.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_day_of_work.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPhoneNv.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCCCD.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAddressNv.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];                   
                txtCodeNV.Text = row.Cells[0].Value.ToString();
                txtNameNV.Text = row.Cells[1].Value.ToString();
                string gender = row.Cells[2].Value.ToString();
                if (gender == "Nam")
                {
                    GT_Nam.Checked = true;
                }
                else if (gender == "Nữ")
                {
                    GT_Nu.Checked = true;
                }
                txt_Birthday.Text = row.Cells[3].Value.ToString();
                txt_day_of_work.Text = row.Cells[4].Value.ToString();
                txtPhoneNv.Text = row.Cells[5].Value.ToString();
                txtCCCD.Text = row.Cells[6].Value.ToString();
                txtAddressNv.Text = row.Cells[7].Value.ToString();


            }
        }

        public void insertNV()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ThemNV", conn))
                    {
                        if (!KiemTraEmailUnique(txtEmail.Text))
                        {
                            MessageBox.Show("Email đã tồn tại trong cơ sở dữ liệu.");
                            return;
                        }
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", txtCodeNV.Text);
                        bool i = kiemtraKey(Key: txtCodeNV.Text, TableName: "TblNhanVien", NameColumnKey: "sMaNV");
                        if (i == false)
                        {
                            MessageBox.Show("Mã Nhân Viên Đã Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@TenNV", txtNameNV.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", GT_Nam.Checked ? "Nam" : "Nữ");
                        cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txt_Birthday.Text));
                        cmd.Parameters.AddWithValue("@NgayVaoLam", DateTime.Parse(txt_day_of_work.Text));
                        cmd.Parameters.AddWithValue("@SDT", txtPhoneNv.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtAddressNv.Text);
                        cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);


                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm Nhân Viên thành công");
                            HienDSNV();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Nhân Viên thất bại");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // kiểm tra khóa
        public static bool kiemtraKey(string Key, string TableName, string NameColumnKey)
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            string KiemTraPK = "SELECT * FROM " + TableName + " WHERE " + NameColumnKey + "= '" + Key + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodeNV.Text == "" || txtNameNV.Text == "" || txtPhoneNv.Text == "" || txtAddressNv.Text == "" || txt_Birthday.Text == "" || txt_day_of_work.Text == "" || txtCCCD.Text == "" ||(GT_Nam.Checked == false && GT_Nu.Checked == false) )
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Dữ Liệu Để Thêm ");
                return;
            }
            else
            {
                insertNV();
            }
            
        }
        
        public void xoaNV()
        {
            string maNV = dataGridView1.CurrentRow.Cells["Mã Nhân Viên"].Value.ToString();
            bool i = kiemtraKey(Key: txtCodeNV.Text, TableName: "TblNhanVien", NameColumnKey: "sMaNV");
            if (i == true)
            {
                MessageBox.Show("Mã Nhân Viên Bạn Muốn Xóa Không Tồn Tại");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
                try
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_XoaNV", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaNV", maNV);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa Nhân Viên thành công");
                                HienDSNV();
                            }
                            else
                            {
                                MessageBox.Show("Xóa Nhân Viên thất bại");
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
        // sửa
       

        public void suaSP()
        {                   
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SuaNV", conn))
                    {
                        
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", txtCodeNV.Text);
                        bool i = kiemtraKey(Key: txtCodeNV.Text, TableName: "TblNhanVien", NameColumnKey: "sMaNV");
                        if (i == true)
                        {
                            MessageBox.Show("Mã Nhân Viên Bạn Muốn sửa Không Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@TenNV", txtNameNV.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", GT_Nam.Checked ? "Nam" : "Nữ");
                        cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txt_Birthday.Text));
                        cmd.Parameters.AddWithValue("@NgayVaoLam", DateTime.Parse(txt_day_of_work.Text));
                        cmd.Parameters.AddWithValue("@SDT", txtPhoneNv.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtAddressNv.Text);
                        cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật Nhân Viên thành công");
                            HienDSNV();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin Nhân Viên thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suaSP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xoaNV();
        }
    }
}
