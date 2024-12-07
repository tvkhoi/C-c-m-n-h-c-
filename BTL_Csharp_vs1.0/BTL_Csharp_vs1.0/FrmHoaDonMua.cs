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
    public partial class FrmHoaDonMua : Form
    {
        public FrmHoaDonMua()
        {
            InitializeComponent();
        }
        // tạo biến lưu thông tin nhân viên
        public string UserName, Password, EmployeeID, EmployeeName;

        // lấy thông tin nhân viên từ đăng nhập
        public FrmHoaDonMua(string userName, string password, string employeeID, string employeeName)
        {
            InitializeComponent();
            this.UserName = userName;
            this.Password = password;
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDonMua chitetHD = new FrmChiTietHoaDonMua(txtCodeHD.Text);
            chitetHD.Show();
        }

        private void FrmHoaDonMua_Load(object sender, EventArgs e)
        {
            LayMaHoaDonTiepTheo();
            txtNv.Text = EmployeeName;
            reload();
            // thêm nút xem chi tiết vào bảng gridview
            DataGridViewButtonColumn btnViewDetail = new DataGridViewButtonColumn();
            {
                btnViewDetail.Name = "btnViewDetail";
                btnViewDetail.HeaderText = "Xem chi tiết";
                btnViewDetail.Text = "Xem chi tiết";
                btnViewDetail.UseColumnTextForButtonValue = true;

            }
            dataGridView1.Columns.Add(btnViewDetail);
            HienHDMua();
            LayDsKH();
        }
        public void HienHDMua()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_HoaDonMua order by [Mã Hóa Đơn] ASC", conn))
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
        private void LayDsKH()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from TblKhachHang", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txtKH.DataSource = tb;
                        txtKH.DisplayMember = "sTenKH";
                        txtKH.ValueMember = "sMaKH";


                    }
                }
            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeHD.Text = dataGridView1.CurrentRow.Cells["Mã Hóa Đơn"].Value.ToString();
            txtKH.Text = dataGridView1.CurrentRow.Cells["Khách Hàng"].Value.ToString();
            txtNv.Text = dataGridView1.CurrentRow.Cells["Nhân Viên"].Value.ToString();
            txtDate.Text = dataGridView1.CurrentRow.Cells["Ngày Bán"].Value.ToString();
            txtTTien.Text = dataGridView1.CurrentRow.Cells["Tổng Tiền"].Value.ToString();
            if (e.ColumnIndex == dataGridView1.Columns["btnViewDetail"].Index && e.RowIndex >= 0)
            {
                string maHDNhap = dataGridView1.Rows[e.RowIndex].Cells["Mã Hóa Đơn"].Value.ToString();
                ChiTietHDNhap chiTietHDNhap = new ChiTietHDNhap(maHDNhap);
                chiTietHDNhap.ShowDialog();
            }


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodeHD.Text = dataGridView1.CurrentRow.Cells["Mã Hóa Đơn"].Value.ToString();
                txtKH.Text = dataGridView1.CurrentRow.Cells["Khách Hàng"].Value.ToString();
                txtNv.Text = dataGridView1.CurrentRow.Cells["Nhân Viên"].Value.ToString();
                txtDate.Text = dataGridView1.CurrentRow.Cells["Ngày Bán"].Value.ToString();
                txtTTien.Text = dataGridView1.CurrentRow.Cells["Tổng Tiền"].Value.ToString();

            }
        }


        public void insertHoaDonMua()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ThemHDMua", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHDMua", txtCodeHD.Text);
                        bool i = kiemtraKey(Key: txtCodeHD.Text, TableName: "TblHoaDonMua", NameColumnKey: "iMaHDMua");
                        if (i == false)
                        {
                            MessageBox.Show("Mã Hóa Đơn Đã Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@MaNV", EmployeeID);
                        cmd.Parameters.AddWithValue("@MaKH", txtKH.SelectedValue.ToString());
                        // Đặt ngày nhập mặc định là ngày hiện tại
                        cmd.Parameters.AddWithValue("@NgayBan", DateTime.Today);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm Hóa Đơn thành công");
                            HienHDMua();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Hóa Đơn thất bại");
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



        public void xoaHDMua()
        {
            string maHD = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bool i = kiemtraKey(Key: txtCodeHD.Text, TableName: "TblHoaDonMua", NameColumnKey: "iMaHDMua");
            if (i == true)
            {
                MessageBox.Show("Mã Hóa Đơn Mua Bạn Muốn Xóa Không Tồn Tại");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Hóa Đơn Mua này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
                try
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_XoaHDMua", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@iMaHDMua", maHD);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa Hóa Đơn Mua thành công");
                                HienHDMua();
                            }
                            else
                            {
                                MessageBox.Show("Xóa Hóa Đơn Mua thất bại");
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

        public void suaHDMua()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SuaHDMua", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHDMua", txtCodeHD.Text);
                        bool i = kiemtraKey(Key: txtCodeHD.Text, TableName: "TblHoaDonMua", NameColumnKey: "iMaHDMua");
                        if (i == true)
                        {
                            MessageBox.Show("Mã Hóa Đơn Mua Bạn Muốn sửa Không Tồn Tại");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@MaNV", EmployeeID);
                        cmd.Parameters.AddWithValue("@MaKH", txtKH.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@NgayBan", DateTime.Parse(txtDate.Text));


                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật Hóa Đơn Mua thành công");
                            HienHDMua();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Hóa Đơn Mua thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void reload()
        {
            LayMaHoaDonTiepTheo();
            txtNv.Text = EmployeeName;
            txtCodeHD.Text = nextInvoiceID;
            txtKH.Text = "";
            txtDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            txtTTien.Text = "";
            HienHDMua();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtCodeHD.Text == "" || txtKH.Text == "" || txtNv.Text == "" || txtDate.Text == "")
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Dữ Liệu Để Thêm ");
                return;
            }
            else
            {
                insertHoaDonMua();

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            reload();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reload();

        }

        private string nextInvoiceID;
        private void LayMaHoaDonTiepTheo()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                // Truy vấn để lấy mã hóa đơn tiếp theo
                string query = "SELECT MAX(iMaHDMua) FROM TblHoaDonMua";
                SqlCommand cmd = new SqlCommand(query, conn);
                // Thực thi truy vấn và lấy kết quả
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    int maxID = Convert.ToInt32(result);
                    // Tăng giá trị của mã hóa đơn tiếp theo lên 1
                    int nextID = maxID + 1;
                    // Gán giá trị cho txtCodeHD
                    nextInvoiceID = nextID.ToString();
                }
                else
                {
                    // Nếu không có hóa đơn nào trong cơ sở dữ liệu, bắt đầu từ 1
                    nextInvoiceID = "1";
                }
                txtCodeHD.Text = nextInvoiceID;
            }
        }

    }
}
