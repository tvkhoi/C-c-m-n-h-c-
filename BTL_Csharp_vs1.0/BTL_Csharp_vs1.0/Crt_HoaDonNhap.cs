using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Csharp_vs1._0
{
    public partial class Crt_HoaDonNhap : Form
    {
        public Crt_HoaDonNhap()
        {
            InitializeComponent();
        }
        public int sohd;
        public Crt_HoaDonNhap(int soHd)
        {
            InitializeComponent();
            this.sohd = soHd;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\Dofolder\\C#\\WindowsFormsApp1\\BTL_Csharp_vs1.0\\CrystalReport1.rpt");
            reportDocument.SetParameterValue("@mahd", sohd);
            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
            
        }
    }
}
