using CrystalDecisions.Web.HtmlReportRender;
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

namespace cry_windowform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "lay_du_lieu_SV";
                    command.CommandType = CommandType.StoredProcedure;
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        CrystalReport6 crystal = new CrystalReport6();
                        crystal.SetDataSource(dt);
                        Form2 form = new Form2();
                        form.crystalReportViewer1.ReportSource = crystal;
                        form.Show();
                    }
                }
            }
        }
    }
}
