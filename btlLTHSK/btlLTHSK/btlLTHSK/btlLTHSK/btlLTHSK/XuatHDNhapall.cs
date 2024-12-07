using CrystalDecisions.CrystalReports.Engine;
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

namespace btlLTHSK
{
    public partial class XuatHDNhapall : Form
    {
        public XuatHDNhapall()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        private void XuatHDNhapall_Load(object sender, EventArgs e)
        {
            xuat_HDNhap_All();
        }
        public void xuat_HDNhap_All()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "xuat_hoadon_TheoMa_ALL";
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        ReportDocument report = new ReportDocument();
                        string path = string.Format("{0}\\CryHDNhapALL.rpt",
                            Application.StartupPath);

                        report.Load(path);
                        report.Database.Tables["xuat_hoadon_TheoMa_ALL"].SetDataSource(dt);
                        //crystalReportViewer1.ReportSource = report;
                        crystalReportViewer_XuatHDall.ReportSource = report;
                        crystalReportViewer_XuatHDall.Refresh();
                    }
                }
                conn.Close();
            }
        }
    }
}
