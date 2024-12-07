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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_Csharp_vs1._0
{
    public partial class FrmThongKeHDNhap : Form
    {
        public FrmThongKeHDNhap()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmThongKeHDNhap_Load(object sender, EventArgs e)
        {
            LayDsNcc();
            LayDsNv();
        }
        private void LayDsNv()
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
                        txtNv.DataSource = tb;
                        txtNv.DisplayMember = "sTenNV";
                        txtNv.ValueMember = "sMaNV";


                    }
                }
            }
        }

        private void LayDsNcc()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from TblNhaCC", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txtNhacungcap.DataSource = tb;
                        txtNhacungcap.DisplayMember = "sTenNCC";
                        txtNhacungcap.ValueMember = "sMaNCC";


                    }
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            
            TimKiemVaHienThiKetQua();
        }

        private void TimKiemVaHienThiKetQua()
        {
            string query = "SELECT * FROM v_HoaDonNhap WHERE 1=1 AND ";
            if (checkBox1.Checked==true && txtCodeHD.Text != "")
            {
                query += "sMaHDNhap = '" + txtCodeHD.Text + "' AND ";
            }
            if (checkBox2.Checked)
            {
                query += "sMaNCC = '" + txtNhacungcap.SelectedValue.ToString() + "' AND ";
            }
            if (checkBox3.Checked==true && txtNv.Text!= "")
            {
                query += "sMaNV = '" + txtNv.SelectedValue.ToString() + "' AND ";
            }
            if (checkBox4.Checked)
            {
                query += "MONTH(dNgayNhap) = " + txtThang.SelectedItem.ToString() + " AND ";
            }
            /*if (checkBox5.Checked)
            {
                query += "YEAR(dNgayNhap) = " + comboBox2.SelectedItem.ToString() + " AND ";
            }*/

            // Xử lý checkbox tổng tiền
            if (checkBox6.Checked)
            {
                query += "fTongTien < 1000000 AND ";
            }
            else if (checkBox7.Checked)
            {
                query += "fTongTien BETWEEN 5000000 AND 10000000 AND ";
            }
            else if (checkBox8.Checked)
            {
                query += "fTongTien BETWEEN 1000000 AND 5000000 AND ";
            }
            else if (checkBox9.Checked)
            {
                query += "fTongTien > 10000000 AND ";
            }

            query = query.TrimEnd(' ', 'A', 'N', 'D', ' ');

            try
            {
                string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}

