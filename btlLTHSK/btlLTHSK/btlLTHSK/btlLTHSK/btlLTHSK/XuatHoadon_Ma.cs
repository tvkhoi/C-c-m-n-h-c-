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
    public partial class XuatHoadon_Ma : Form
    {
        public XuatHoadon_Ma()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;

        private void XuatHoadon_Ma_Load(object sender, EventArgs e)
        {
            XuatHoadon_Ma_HDN(a);
        }
        double a = 0;
        public void XuatHoadon_Ma_HDN(double iMaHD)
        {
             a = iMaHD;

            SqlConnection conn = new SqlConnection(connectionString);
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "xuat_hoadon_TheoMa";
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.Parameters.AddWithValue("@iMaHDN", iMaHD);


                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        ReportDocument report = new ReportDocument();
                        string path = string.Format("{0}\\xuatHDNhap01.rpt",
                            Application.StartupPath);

                        report.Load(path);
                        report.Database.Tables["xuat_hoadon_TheoMa"].SetDataSource(dt);
                        //crystalReportViewer1.ReportSource = report;
                        crystalReportViewer1.ReportSource = report;
                        crystalReportViewer1.Refresh();
                    }
                }
                conn.Close();
            }
        }
    }
}
