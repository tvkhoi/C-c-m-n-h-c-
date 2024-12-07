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
    public partial class FrmInsertKhachHang : Form
    {
        public FrmInsertKhachHang()
        {
            InitializeComponent();
        }

        private void FrmInsertKhachHang_Load(object sender, EventArgs e)
        {
            HienDSKH();
        }
        private void HienDSKH()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_DsKH order by [Mã Khách Hàng] ASC", conn))
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeKH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNameKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string gender = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (gender == "Nam")
            {
                GT_Nam.Checked = true;
            }
            else if (gender == "Nữ")
            {
                GT_Nu.Checked = true;
            }
            txtPhoneKH.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAddressKH.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodeKH.Text = row.Cells[0].Value.ToString();
                txtNameKH.Text = row.Cells[1].Value.ToString();
                string gender = row.Cells[2].Value.ToString();
                if (gender == "Nam")
                {
                    GT_Nam.Checked = true;
                }
                else if (gender == "Nữ")
                {
                    GT_Nu.Checked = true;
                }
                txtPhoneKH.Text = row.Cells[3].Value.ToString();
                txtAddressKH.Text = row.Cells[4].Value.ToString();
               


            }
        }

        public void insertKH()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ThemKH", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKH", txtCodeKH.Text);
                        bool i = kiemtraKey(Key: txtCodeKH.Text, TableName: "tblKhachHang", NameColumnKey: "sMaKH");
                        if (i == false)
                        {
                            MessageBox.Show("Mã Khách Hàng Đã Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@TenKH", txtNameKH.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", GT_Nam.Checked ? "Nam" : "Nữ");                     
                        cmd.Parameters.AddWithValue("@SDT", txtPhoneKH.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtAddressKH.Text);


                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm Khách Hàng thành công");
                            HienDSKH();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Khách Hàng thất bại");
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
            if (txtCodeKH.Text == "" || txtNameKH.Text == "" || txtPhoneKH.Text == "" || txtAddressKH.Text == "" || (GT_Nam.Checked == false && GT_Nu.Checked == false))
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Dữ Liệu Để Thêm ");
                return;
            }
            else
            {
                insertKH();
                
            }

        }

        public void xoaKH()
        {
            string maNV = dataGridView1.CurrentRow.Cells["Mã Khách Hàng"].Value.ToString();
            bool i = kiemtraKey(Key: txtCodeKH.Text, TableName: "tblKhachHang", NameColumnKey: "sMaKH");
            if (i == true)
            {
                MessageBox.Show("Mã Khách Hàng Bạn Muốn Xóa Không Tồn Tại");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Khách Hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
                try
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_XoaKH", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaKH", maNV);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa Khách Hàng thành công");
                                HienDSKH();
                            }
                            else
                            {
                                MessageBox.Show("Xóa Khách Hàng thất bại");
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
                    using (SqlCommand cmd = new SqlCommand("sp_SuaKH", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKH", txtCodeKH.Text);
                        bool i = kiemtraKey(Key: txtCodeKH.Text, TableName: "tblKhachHang", NameColumnKey: "sMaKH");
                        if (i == true)
                        {
                            MessageBox.Show("Mã Khách Hàng Bạn Muốn sửa Không Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@TenKH", txtNameKH.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", GT_Nam.Checked ? "Nam" : "Nữ");                    
                        cmd.Parameters.AddWithValue("@SDT", txtPhoneKH.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtAddressKH.Text);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật Khách Hàng thành công");
                            HienDSKH();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin Khách Hàng thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            insertKH();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suaSP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xoaKH();
        }

        private void txtCodeKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void GT_Nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GT_Nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNameKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
