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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL_Csharp_vs1._0
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

       
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertSanPham frmInsertSanPham = new FrmInsertSanPham();
            frmInsertSanPham.MdiParent = this;
            frmInsertSanPham.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertNhanVien frmInsertNhanVien = new FrmInsertNhanVien();
            frmInsertNhanVien.MdiParent = this;
            frmInsertNhanVien.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertKhachHang frmInsertKhachHang = new FrmInsertKhachHang();
            frmInsertKhachHang.MdiParent = this;
            frmInsertKhachHang.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertNcc frmInsertNcc = new FrmInsertNcc();
            frmInsertNcc.MdiParent = this;
            frmInsertNcc.Show();
        }

       
        private void danhMụcBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonMua frmHoaDonMua = new FrmHoaDonMua(UserName, Password, EmployeeID, EmployeeName);
            frmHoaDonMua.MdiParent = this;
            frmHoaDonMua.Show();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtCaNhanVien.Text = "Ca Làm Việc Của :" + EmployeeName;
            CheckUserRole(EmployeeID);
        }


        // chứa thông tin nhân viên từ form đăng nhập
        public string UserName, Password, EmployeeID, EmployeeName;

        public FrmMain(string userName, string password, string employeeID, string employeeName)
        {
            InitializeComponent();
            this.UserName = userName;
            this.Password = password;
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmHoaDonNhap frmHoaDonNhap = new FrmHoaDonNhap(UserName, Password, EmployeeID, EmployeeName);
            frmHoaDonNhap.MdiParent = this;
            frmHoaDonNhap.Show();
        }

        public bool isThoat = true;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            Login login = new Login();
            login.Show();


        }

        private void thốngKêHDNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKeHDNhap frmThongKeHDNhap = new FrmThongKeHDNhap();
            frmThongKeHDNhap.MdiParent = this;
            frmThongKeHDNhap.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertNhanVien frmInsertNhanVien = new FrmInsertNhanVien();
            frmInsertNhanVien.MdiParent = this;
            frmInsertNhanVien.Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat == true)
            {
                Application.Exit();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isThoat == true)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();

                /*                Application.Exit();
                 *               
                */
            }
        }

        private void menutaikhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan frmTaiKhoan = new FrmTaiKhoan();
            frmTaiKhoan.MdiParent = this;
            frmTaiKhoan.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.MdiParent = this;
            report.Show();
        }

        private void tTSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTTSP frmHoaDonMua = new FrmTTSP();
            frmHoaDonMua.MdiParent = this;
            frmHoaDonMua.Show();
        }


        // phân quyền

        //lấy quyền
        private string GetUserRoleFromDatabase(string manv )
        {
            string userRole = "";
            string connectionString = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT sQuyenNv FROM TblTaiKhoan WHERE sMaNV = @MaNv";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNv", manv);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            userRole = result.ToString(); 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return userRole;
        }


        // kiểm tra phân quyền
        private void CheckUserRole(string manv)
        {
            string userRole = GetUserRoleFromDatabase(manv);

            switch (userRole)
            {
                case "Nhập Hàng":
                    MenuDanhMuc.Visible = false;                
                    menutaikhoan.Visible = false;
                    MenuQlBanHang.Visible = false;
                    MenuQLNhapHang.Visible = true;
                    break;
                case "Bán Hàng":
                    menutaikhoan.Visible = false;
                    MenuQLNhapHang.Visible= false;
                    MenuDanhMuc.Visible = false;                    
                    MenuKhachHang.Visible = true;
                    MenuQlBanHang.Visible = true;
                    break;
                case "admin":
                    break;
                default:
                    break;
            }
        }
    }
}
