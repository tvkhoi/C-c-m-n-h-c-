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
    public partial class Form2_VTL : Form
    {
        private IChuyenDuLieu _ichuyendulieu_VTL;
        string selectedMaBN_VTL = "";
        public Form2_VTL(IChuyenDuLieu ichuyendulieu, string a)
        {
            InitializeComponent();
            _ichuyendulieu_VTL = ichuyendulieu;
            selectedMaBN_VTL = a;
        }
        string str_VTL = "Data Source = DESKTOP-BHIGK0R\\SQLEXPRESS; Initial Catalog= KT;Integrated Security=True;";
        private void LoadData()
        {
            
            string query = "SELECT Ngay_VTL, MaBN_VTL, DichVu_VTL FROM tblHopDong_VTL WHERE MaBN_VTL = @MaBN_VTL ORDER BY Ngay_VTL";

            using (SqlConnection conn_VTL = new SqlConnection(str_VTL))
            {
                using (SqlCommand cmd_VTL = new SqlCommand(query, conn_VTL))
                {
                    cmd_VTL.Parameters.AddWithValue("@MaBN_VTL", selectedMaBN_VTL);
                    conn_VTL.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd_VTL);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    conn_VTL.Close();

                    if (dt.Rows.Count > 0)
                    {
                        dgv_VTL.DataSource = dt;
                    }
                    else
                    {
                       MessageBox.Show("Không có bản ghi nào");
                        this.Close();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//02/02/2000
            int i = dgv_VTL.CurrentRow.Index;
            string a = dgv_VTL.Rows[i].Cells[1].Value.ToString();
            string b = (dgv_VTL.Rows[i].Cells[0].Value.ToString()).Substring(0,2);
            string c = (dgv_VTL.Rows[i].Cells[0].Value.ToString()).Substring(3, 2);
            string d = (dgv_VTL.Rows[i].Cells[0].Value.ToString()).Substring(6, 4);
            string f = dgv_VTL.Rows[i].Cells[2].Value.ToString();
            string g = $"{b}/{c}/{d} {dgv_VTL.Rows[i].Cells[2].Value.ToString()}";
            _ichuyendulieu_VTL.XyLyDuLieu(a,b,c,d,f,g);
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(selectedMaBN_VTL);
            form3.ShowDialog();
        }
    }
}
