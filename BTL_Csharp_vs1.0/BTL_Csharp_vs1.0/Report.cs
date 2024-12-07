using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_Csharp_vs1._0
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            cbTenNhanVien.SelectedIndexChanged += cbTenNhanVien_SelectedIndexChanged;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LayDsNV();
            LoadReport();
        }

        private void LayDsNV()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from TblNhanVien", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        cbTenNhanVien.DataSource = tb;
                        cbTenNhanVien.DisplayMember = "sTenNV";
                        cbTenNhanVien.ValueMember = "sMaNV";
                    }
                }
            }
        }

        private void cbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\Dofolder\\C#\\WindowsFormsApp1\\BTL_Csharp_vs1.0\\CrystalReport2.rpt");
            string maNV = cbTenNhanVien.SelectedValue.ToString();
            reportDocument.SetParameterValue("@Manv", maNV);
            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
        }
    }
}
