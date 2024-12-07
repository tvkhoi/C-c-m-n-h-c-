using System;
using System.Collections;
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
        // tạo biến lưu thông tin nhân viên
        public string UserName, Password, EmployeeID, EmployeeName;

        // lấy thông tin nhân viên từ đăng nhập
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
            LayMaHoaDonTiepTheo();
            HienHDNhap();
            LayDsNcc();
            txtNhanviennhap.Text = EmployeeName;
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
        }
    
        // hiện danh sách hóa đơn nhập
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

        // lấy danh sách nhà cung cấp
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

       
        // đẩy dữ liệu từ gribview lên các text box
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeHD.Text = dataGridView1.CurrentRow.Cells["Mã Hóa Đơn"].Value.ToString();
            txtNhacungcap.Text = dataGridView1.CurrentRow.Cells["Nhà Cung Cấp"].Value.ToString();
            txtNhanviennhap.Text = dataGridView1.CurrentRow.Cells["Nhân Viên Lập"].Value.ToString();
            txtDate.Text = dataGridView1.CurrentRow.Cells["Ngày Lập"].Value.ToString();
            txtTTien.Text = dataGridView1.CurrentRow.Cells["Tổng Tiền"].Value.ToString();
            if (e.ColumnIndex == dataGridView1.Columns["btnViewDetail"].Index && e.RowIndex >= 0)
            {
                string maHDNhap = dataGridView1.Rows[e.RowIndex].Cells["Mã Hóa Đơn"].Value.ToString();
                ChiTietHDNhap chiTietHDNhap = new ChiTietHDNhap(maHDNhap);
                chiTietHDNhap.ShowDialog();
            }

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodeHD.Text = row.Cells["Mã Hóa Đơn"].Value.ToString();
                txtNhacungcap.Text = row.Cells["Nhà Cung Cấp"].Value.ToString();
                txtNhanviennhap.Text = row.Cells["Nhân Viên Lập"].Value.ToString();
                txtDate.Text = row.Cells["Ngày Lập"].Value.ToString();
                txtTTien.Text = row.Cells["Tổng Tiền"].Value.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietHDNhap chitetHD = new ChiTietHDNhap(txtCodeHD.Text);
            chitetHD.Show();
        }

        //  thêm 
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
                        cmd.Parameters.AddWithValue("@MaNV", EmployeeID);
                        cmd.Parameters.AddWithValue("@MaNcc", txtNhacungcap.SelectedValue.ToString());
                        // Đặt ngày nhập mặc định là ngày hiện tại
                        cmd.Parameters.AddWithValue("@Ngaynhap", DateTime.Today);

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

        
        // xóa
        public void xoaHDNhap()
        {
            string maHD = txtCodeHD.Text;
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
        /*// sửa
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
        }*/

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

       /* private void btnUpdate_Click(object sender, EventArgs e)
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
            
        }*/

 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            xoaHDNhap();
        }

        private void txtCodeHD_TextChanged(object sender, EventArgs e)
        {
            txtTTien.Text = "";
            txtDate.Text = "";
            txtNhacungcap.Text = "";
            txtNhanviennhap.Text = EmployeeName;
        }

        private void reload()
        {
            LayMaHoaDonTiepTheo();
            txtNhanviennhap.Text = EmployeeName;
            txtCodeHD.Text = nextInvoiceID;
            txtNhacungcap.Text = "";
            txtDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            txtTTien.Text = "";
            HienHDNhap();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string TenNV = txtTennv.Text.Trim();

            if (string.IsNullOrEmpty(TenNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để tìm kiếm.");
                return;
            }

            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                string query = "SELECT * FROM v_HoaDonNhap WHERE [Nhân Viên Lập] LIKE '%' + @TenNv + '%'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenNv", TenNV);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("HoaDonNhap");
                        ad.Fill(tb);
                        if (tb.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy");
                        }
                        dataGridView1.DataSource = tb;
                    }
                }
            }
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
                string query = "SELECT MAX(iMaHDNhap) FROM TblHoaDonNhap";
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
