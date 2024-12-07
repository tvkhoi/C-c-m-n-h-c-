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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL_Csharp_vs1._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ktraTk();

        }
        public string MaNv;
        private void Login_Load(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void ktraTk()
        {
            string TenDangNhap = txtLogin.Text;
            string MatKhau = txtPass.Text;
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_KtraLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaiKhoan", TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string userName = dt.Rows[0]["UserName"].ToString();
                        string password = dt.Rows[0]["Password"].ToString();
                        string employeeID = dt.Rows[0]["EmployeeID"].ToString();
                        string employeeName = dt.Rows[0]["EmployeeName"].ToString();
                        MessageBox.Show("Đăng Nhập Thành Công"+ " { " + employeeID + " " + employeeName+ " }");
                        
                        // đưa thông tin nhân viên sang form main
                        FrmMain frmMain = new FrmMain(userName,password,employeeID,employeeName);
                        frmMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
