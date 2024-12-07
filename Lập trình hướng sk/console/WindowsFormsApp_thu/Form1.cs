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
namespace WindowsFormsApp_thu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conectionString = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "lay_du_lieu_doitac";
                    command.CommandType = CommandType.StoredProcedure;
                    
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        CrystalReport4 report = new CrystalReport4();
                        report.SetDataSource(dataTable);
                        Form2 form2 = new Form2();
                        form2.crystalReportViewer1.ReportSource = report;
                        form2.Show();
                      

                    }
                   
                    
                }
            }

        }
    }
}
