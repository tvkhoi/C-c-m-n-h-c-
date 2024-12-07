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

namespace BTL_Csharp_vs1._0
{
    public partial class FrmThangKeNcc_LoaiSP : Form
    {
        public FrmThangKeNcc_LoaiSP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LayNcc();
            LayLoaiSP();
            HienDS();
            
        }

        private void LayNcc()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblNhaCC  ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txtNcc.DataSource = tb;
                        txtNcc.DisplayMember = "sTenNCC";
                        


                    }
                }
            }

        }
        private void HienDS()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_SP_NCC order by [sMaSP] ASC", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;


                    }
                }
            }

        }
        private void LayLoaiSP()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_LoaiSP ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txtLoaiSp.DataSource = tb;
                        txtLoaiSp.DisplayMember = "sLoaiSP";


                    }
                }
            }

        }

        private void search()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using(SqlConnection conn = new SqlConnection(constr))
                {
                    string Command = "select * from v_SP_NCC where 1=1 ";
                    string NCC = txtNcc.Text;
                    string LoaiSP = txtLoaiSp.Text;
                    if (NCC != "" )
                    {
                        Command += "AND sTenNCC LIKE '%' + @NCC + '%' ";
                    }
                    if (LoaiSP != "" )
                    {
                        Command += "AND sLoaiSP LIKE '%' + @LoaiSP + '%' ";
                    }

                    using (SqlCommand cmd = new SqlCommand(Command,conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        if (NCC != "")
                        {
                            cmd.Parameters.AddWithValue("@NCC", NCC);
                        }
                        if (LoaiSP != "")
                        {
                            cmd.Parameters.AddWithValue("@LoaiSP", LoaiSP);
                        }
                        conn.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());

                        dataGridView1.DataSource = dt;

                    }
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNcc_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void txtLoaiSp_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
