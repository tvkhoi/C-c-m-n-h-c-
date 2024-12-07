using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTL_Csharp_vs1._0
{
    public partial class FrmHoaDonNhap : Form
    {
        public FrmHoaDonNhap()
        {
            InitializeComponent();
        }
        public string UserName, Password, EmployeeID, EmployeeName;

        public FrmHoaDonNhap(string userName, string password, string employeeID, string employeeName)
        {
            InitializeComponent();
            this.UserName = userName;
            this.Password = password;
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
        }

        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            HienHDNhap();
            LayDsNcc();
            txtNhanviennhap.Text = EmployeeName;
        }
    
        public void HienHDNhap()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_HoaDonNhap order by [Mã Hóa Đơn] ASC", conn))
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
                        txtNhacungcap.DataSource = tb;
                        txtNhacungcap.DisplayMember = "sTenNCC";
                        txtNhacungcap.ValueMember = "sMaNCC";


                    }
                }
            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeHD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNhacungcap.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNhanviennhap.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodeHD.Text = row.Cells[0].Value.ToString();
                txtNhacungcap.Text = row.Cells[2].Value.ToString();
                txtNhanviennhap.Text = row.Cells[1].Value.ToString();
                txtDate.Text = row.Cells[3].Value.ToString();
                txtTTien.Text = row.Cells[4].Value.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietHDNhap chitetHD = new ChiTietHDNhap(txtCodeHD.Text);
            chitetHD.Show();
        }

        public void insertHoaDonNhap()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ThemHDNhap", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHDNhap", txtCodeHD.Text);
                        bool i = kiemtraKey(Key: txtCodeHD.Text, TableName: "TblHoaDonNhap", NameColumnKey: "iMaHDNhap");
                        if (i == false)
                        {
                            MessageBox.Show("Mã Hóa Đơn Nhập Hàng Đã Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@MaNV", EmployeeID );
                        cmd.Parameters.AddWithValue("@MaNcc", txtNhacungcap.SelectedValue.ToString());
                        DateTime ngayNhap = DateTime.Parse(txtDate.Text);
                        if (ngayNhap > DateTime.Today)
                        {
                            MessageBox.Show("Ngày nhập không được lớn hơn ngày hiện tại.");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@Ngaynhap", DateTime.Parse( txtDate.Text));


                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm Hóa Đơn Nhập thành công");
                            HienHDNhap();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Hóa Đơn Nhập thất bại");
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

        

        public void xoaHDNhap()
        {
            string maHD = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bool i = kiemtraKey(Key: txtCodeHD.Text, TableName: "TblHoaDonNhap", NameColumnKey: "iMaHDNhap");
            if (i == true)
            {
                MessageBox.Show("Mã Hóa Đơn Nhập Bạn Muốn Xóa Không Tồn Tại");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Hóa Đơn Nhập này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
                try
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_XoaHDNhap", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@iMaHDNhap", maHD);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa Hóa Đơn Nhập thành công");
                                HienHDNhap();
                            }
                            else
                            {
                                MessageBox.Show("Xóa Hóa Đơn Nhập thất bại");
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


        public void suaHDNhap()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SuaHDNhap", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHDNhap", txtCodeHD.Text);
                        bool i = kiemtraKey(Key: txtCodeHD.Text, TableName: "TblHoaDonNhap", NameColumnKey: "iMaHDNhap");
                        if (i == true)
                        {
                            MessageBox.Show("Mã Hóa Đơn Nhập Bạn Muốn sửa Không Tồn Tại");
                            return;
                        }                     
                        cmd.Parameters.AddWithValue("@MaNV", EmployeeID);
                        cmd.Parameters.AddWithValue("@MaNcc", txtNhacungcap.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Ngaynhap", DateTime.Parse(txtDate.Text));


                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật Hóa Đơn Nhập thành công");
                            HienHDNhap();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Hóa Đơn Nhập thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCodeHD.Text == "" || txtNhacungcap.Text == "" || txtNhanviennhap.Text == "" || txtDate.Text == "" )
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Dữ Liệu Để Thêm ");
                return;
            }
            else
            {
                insertHoaDonNhap();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCodeHD.Text == "" || txtNhacungcap.Text == "" || txtNhanviennhap.Text == "" || txtDate.Text == "")
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Dữ Liệu Để Thực Hiện ");
                return;
            }
            else
            {
                suaHDNhap();

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            xoaHDNhap();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            ChiTietHDNhap chiTietHDNhap = new ChiTietHDNhap(txtCodeHD.Text);
            chiTietHDNhap.ShowDialog();
            this.Close();
            
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            HienHDNhap();
        }
    }
}
