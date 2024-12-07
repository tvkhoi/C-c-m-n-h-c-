using CrystalDecisions.ReportAppServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuchanh7.SoKhamBenh;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Data.SqlClient;

namespace thuchanh7
{
    public partial class Form3 : Form
    {
        string mabn = "";
        public Form3(string a)
        {
            InitializeComponent();
            mabn = a;
        }
        string str = "Data Source = DESKTOP-BHIGK0R\\SQLEXPRESS; Initial Catalog= KT;Integrated Security=True;";

        CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
        public void ShowReport()
        {

            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select_sokhambenh";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBN", mabn);
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            ReportDocument report = new ReportDocument();
                            string path = string.Format("{0}\\SoKhamBenh\\SoKhamBenh.rpt", Application.StartupPath);
                            report.Load(path);
                            report.Database.Tables["select_sokhambenh"].SetDataSource(dt);
                            report.SetParameterValue("Nguoilapbieu", "VTL");
                            crystalReportViewer1.ReportSource = report;
                            crystalReportViewer1.Refresh();
                        }

                    }
                }
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ShowReport();
        }
    }
}
