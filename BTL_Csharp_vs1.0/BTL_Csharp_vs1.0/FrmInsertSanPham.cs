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
    public partial class FrmInsertSanPham : Form
    {
        public FrmInsertSanPham()
        {
            InitializeComponent();
        }

        // ev_Load 
        private void FrmInsertSanPham_Load(object sender, EventArgs e)
        {
            LayDsNcc();
            HienDSSP();
            DataGridViewButtonColumn btnViewDetail = new DataGridViewButtonColumn();
            {
                btnViewDetail.Name = "btnViewDetail";
                btnViewDetail.HeaderText = "Xem chi tiết";
                btnViewDetail.Text = "Xem chi tiết";
                btnViewDetail.UseColumnTextForButtonValue = true;

            }
            dataGridView1.Columns.Add(btnViewDetail);
        }

        private void LayDsNcc()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from TblNhaCC", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txtNcc.DataSource = tb;
                        txtNcc.DisplayMember = "sTenNCC";
                        txtNcc.ValueMember = "sMaNCC";


                    }
                }
            }
        }

        private void HienDSSP()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_DsSp order by [Mã Sản Phẩm] ASC", conn))
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
        // thêm
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCodeSP.Text == "" || txtNcc.Text == "" || txtName.Text == "" || txtSoLuong.Text == "" || txtLoaiSP.Text == "")
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Dữ Liệu Để Thêm ");
                return;
            }
            else
            {
                insertSp();
            }
            
        }

        public void insertSp()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ThemSP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaSP", txtCodeSP.Text);
                        bool i = kiemtraKey(Key: txtCodeSP.Text, TableName: "TblSanPham", NameColumnKey: "sMaSP");
                        if (i == false)
                        {
                            MessageBox.Show("Mã Sản Phẩm Đã Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@MaNcc", txtNcc.SelectedValue);
                        cmd.Parameters.AddWithValue("@TenSP", txtName.Text);

                      
                        int soLuong = int.Parse(txtSoLuong.Text);
                        if ( soLuong <= 0)
                        {
                            MessageBox.Show("Số lượng phải lớn hơn 0");
                            return;
                        }
                        
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@LoaiSp", txtLoaiSP.Text);
                        cmd.Parameters.AddWithValue("@ChatLieu", txtchatlieu.Text);


                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm Sản Phẩm thành công");
                            HienDSSP();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Sản Phẩm thất bại");
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
            txtCodeSP.Text = dataGridView1.CurrentRow.Cells["Mã Sản Phẩm"].Value.ToString();
            txtNcc.Text = dataGridView1.CurrentRow.Cells["Tên Nhà cung cấp"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["Tên Sản Phẩm"].Value.ToString();
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells["Số Lượng"].Value.ToString();
            txtLoaiSP.Text = dataGridView1.CurrentRow.Cells["Loại Sản Phẩm"].Value.ToString();
            txtchatlieu.Text = dataGridView1.CurrentRow.Cells["Chất Liệu"].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtCodeSP.Text = row.Cells["Mã Sản Phẩm"].Value.ToString();
                txtNcc.Text = row.Cells["Tên Nhà cung cấp"].Value.ToString();
                txtName.Text = row.Cells["Tên Sản Phẩm"].Value.ToString();
                txtSoLuong.Text = row.Cells["Số Lượng"].Value.ToString();
                txtLoaiSP.Text = row.Cells["Loại Sản Phẩm"].Value.ToString();
                txtchatlieu.Text = row.Cells["Chất Liệu"].Value.ToString();

            }
        }
        // xóa
        private void button2_Click(object sender, EventArgs e)
        {
            xoaSP();
        }
        public void xoaSP()
        {
            string maSP = dataGridView1.CurrentRow.Cells["Mã Sản Phẩm"].Value.ToString();
            bool i = kiemtraKey(Key: txtCodeSP.Text, TableName: "TblSanPham", NameColumnKey: "sMaSP");
            if (i == true)
            {
                MessageBox.Show("Mã Sản Phẩm Bạn Muốn Xóa Không Tồn Tại");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
                try
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_XoaSP", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaSP", maSP);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa Sản Phẩm thành công");
                                HienDSSP();
                            }
                            else
                            {
                                MessageBox.Show("Xóa Sản Phẩm thất bại");
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
        private void button3_Click(object sender, EventArgs e)
        {
            suaSP();
        }
         
        public void suaSP() {

            string maSP = txtCodeSP.Text;
            bool i = kiemtraKey(Key: txtCodeSP.Text, TableName: "TblSanPham", NameColumnKey: "sMaSP");
            if (i == true)
            {
                MessageBox.Show("Mã Sản Phẩm Bạn Muốn sửa Không Tồn Tại");
                return;
            }
            string maNCC = txtNcc.SelectedValue.ToString();
            string tenSP = txtName.Text;
            int soLuong = int.Parse(txtSoLuong.Text);
            string chatlieu = txtchatlieu.Text;
            string loaisp = txtLoaiSP.Text;

            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SuaSP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                        cmd.Parameters.AddWithValue("@TenSP", tenSP);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@LoaiSP", loaisp);
                        cmd.Parameters.AddWithValue("@ChatLieu", chatlieu);


                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công");
                            HienDSSP();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin sản phẩm thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        
        private void TimKiem()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string Command = "select * from tblSanPham where 1=1 ";
                    string @maSP = txtCodeSP.Text;
                    string @Name = txtName.Text;
                    string @maNcc = txtNcc.SelectedValue.ToString();
                    string @soLuong = txtSoLuong.Text;
                    string @ChatLieu = txtchatlieu.Text;

                    if (@maSP != "")
                    {
                        Command += "AND sMaSP = @MaSP ";
                    }
                    if (@Name != "")
                    {
                        Command += "AND sTenSP LIKE '%' + @TenSP + '%' ";
                    }
                    if (@maNcc != "")
                    {
                        Command += "AND sMaNCC = @MaNCC ";
                    }
                    if (@soLuong != "")
                    {
                        Command += "AND iSoLuong = @SoLuong ";
                    }
                    if (@ChatLieu != "")
                    {
                        Command += "AND sChatLieu = @ChatLieu ";
                    }

                    using (SqlCommand cmd = new SqlCommand(Command, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        if (@maSP != "")
                        {
                            cmd.Parameters.AddWithValue("@MaSP", @maSP);
                        }
                        if (@Name != "")
                        {
                            cmd.Parameters.AddWithValue("@TenSP", @Name);
                        }
                        if (@maNcc != "")
                        {
                            cmd.Parameters.AddWithValue("@MaNCC", @maNcc);
                        }
                        if (@soLuong != "")
                        {
                            cmd.Parameters.AddWithValue("@SoLuong", @soLuong);
                        }
                        if (@ChatLieu != "")
                        {
                            cmd.Parameters.AddWithValue("@ChatLieu", @ChatLieu);
                        }

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                        }
                        MessageBox.Show("Tìm Thấy " + count + " Sản phẩm");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}

