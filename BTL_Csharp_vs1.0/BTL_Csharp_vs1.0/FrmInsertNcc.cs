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
using System.Xml.Linq;

namespace BTL_Csharp_vs1._0
{
    public partial class FrmInsertNcc : Form
    {
        public FrmInsertNcc()
        {
            InitializeComponent();
        } 

        private void btnBack_Click(object sender, EventArgs e)
        {
           
        }

        private void bntInsert_Click(object sender, EventArgs e)
        {
            if (txtCodeNcc.Text == "" || txtNameNCC.Text == "" || txtPhoneNcc.Text == "" || txtAddressNcc.Text == "")
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Dữ Liệu Để Thêm ");
                return;
            }
            else
            {
                insertNCC();
            }
           
        }
        public void insertNCC()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ThemNcc", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNcc", txtCodeNcc.Text);
                        bool i = kiemtraKey(Key: txtCodeNcc.Text, TableName: "TblNhaCC", NameColumnKey: "sMaNCC");
                        if (i == false)
                        {
                            MessageBox.Show("Mã Nhà Cung Cấp Đã Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@TenNCC", txtNameNCC.Text);
                        cmd.Parameters.AddWithValue("@Sdt", txtPhoneNcc.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtAddressNcc.Text);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm nhà cung cấp thành công");
                            HienDSNcc();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhà cung cấp thất bại");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeNcc.Text = GrvNcc.CurrentRow.Cells["Mã Nhà cung cấp"].Value.ToString();
            txtNameNCC.Text = GrvNcc.CurrentRow.Cells["Tên Nhà cung cấp"].Value.ToString();
            txtPhoneNcc.Text = GrvNcc.CurrentRow.Cells["Số Điện Thoại"].Value.ToString();
            txtAddressNcc.Text = GrvNcc.CurrentRow.Cells["Địa chỉ"].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0) {
                DataGridViewRow row = GrvNcc.Rows[e.RowIndex];

                txtCodeNcc.Text = row.Cells["Mã Nhà cung cấp"].Value.ToString();
                txtNameNCC.Text = row.Cells["Tên Nhà cung cấp"].Value.ToString();
                txtPhoneNcc.Text = row.Cells["Số Điện Thoại"].Value.ToString().Replace(" ", "");
                txtAddressNcc.Text = row.Cells["Địa chỉ"].Value.ToString();


            }
        }

        private void FrmInsertNcc_Load(object sender, EventArgs e)
        {
            HienDSNcc();
        }

        private void HienDSNcc()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_DsNCC order by [Mã Nhà Cung Cấp] ASC", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        GrvNcc.DataSource = tb;


                    }
                }
            }

        }

        public void SuaNcc()
        {
            string maNCC = txtCodeNcc.Text;
            bool i = kiemtraKey(Key: txtCodeNcc.Text, TableName: "TblNhaCC", NameColumnKey: "sMaNCC");
            if (i == true)
            {
                MessageBox.Show("Mã Nhà Cung Cấp Bạn Muốn sửa Không Tồn Tại");
                return;
            }
            string tenNcc = txtNameNCC.Text;
            string SDT = txtPhoneNcc.Text;
            string adrsNcc = txtAddressNcc.Text;

            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;

            try{
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using ( SqlCommand cmd = new SqlCommand("sp_SuaNcc",conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNcc", maNCC);
                        cmd.Parameters.AddWithValue("@TenNCC" ,tenNcc );
                        cmd.Parameters.AddWithValue("@Sdt", SDT);
                        cmd.Parameters.AddWithValue("@DiaChi", adrsNcc);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa Nhà Cung Cấp Thành Công");
                            HienDSNcc();
                        }
                        else
                        {
                            MessageBox.Show("Sửa Nhà Cung Cấp Không Thành Công");
                        }
                    }
                }
    
            }
            catch(Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SuaNcc();
        }

        public void XoaNcc()
        {
            string MaNcc = txtCodeNcc.Text;
            bool i = kiemtraKey(Key: txtCodeNcc.Text, TableName: "TblNhaCC", NameColumnKey: "sMaNCC");
            if (i == true)
            {
                MessageBox.Show("Mã Nhà Cung Cấp Bạn Muốn Xóa Không Tồn Tại");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhà Cung Cấp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
                try
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_XoaNcc", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaNcc", MaNcc);
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa Nhà Cung Cấp Thành Công");
                                HienDSNcc();
                            }
                            else
                            {
                                MessageBox.Show("Xóa Nhà Cung Cấp Không Thành Công");
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show($"Error: {e.Message}");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XoaNcc();
        }
    }
}
