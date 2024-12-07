using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh7
{
    public partial class Form2 : Form
    {
        private IChuyenDuLieu _ichuyendulieu;
        string selectedMaBN = "";
        public Form2(IChuyenDuLieu ichuyendulieu, string a)
        {
            InitializeComponent();
            _ichuyendulieu = ichuyendulieu;
            selectedMaBN = a;
            LoadData();
        }

        private void LoadData()
        {
            string str_VTL = "Data Source = DESKTOP-BHIGK0R\\SQLEXPRESS; Initial Catalog= KT;Integrated Security=True;";
            string query = "SELECT Ngay_VTL, MaBN_VTL, DichVu_VTL FROM tblHopDong_VTL WHERE MaBN_VTL = @MaBN_VTL ORDER BY Ngay_VTL";

            using (SqlConnection conn = new SqlConnection(str_VTL))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBN_VTL", selectedMaBN);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    conn.Close();

                    if (dt.Rows.Count > 0)
                    {
                        dgv_VTL.DataSource = dt;
                    }
                    else
                    {
                        DialogResult ret = MessageBox.Show("Không có bản ghi nào");         
                        if (ret == DialogResult.Yes)
                        {
                            this.Close();
                        }
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
            _ichuyendulieu.XyLyDuLieu(a,b,c,d,f,g);
            this.Close();
        }
        
    }
}
