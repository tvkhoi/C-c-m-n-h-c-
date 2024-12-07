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
using System.Xml.Linq;

namespace BTL_Csharp_vs1._0
{
    public partial class FrmShowSanPham : Form
    {
        public FrmShowSanPham()
        {
            InitializeComponent();
        }

        private void FrmShowSanPham_Load(object sender, EventArgs e)
        {
          LaySize();
          LayColor();
          HienSP();
          
        }
        /*private void HienGrVDsSP()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from v_DsSP order by [Mã Sản Phẩm]", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        listView1.Clear();
                        listView1.View = View.Details;
                        listView1.GridLines = true;
                        listView1.FullRowSelect = true;
                        listView1.Columns.Add("Mã Sản Phẩm", 100);
                        listView1.Columns.Add("Tên Sản Phẩm", 200);
                        listView1.Columns.Add("Nhà Cung Cấp", 150);
                        listView1.Columns.Add("Số Lượng", 70);
                        listView1.Columns.Add("Đơn Gía", 100);
                        int i = 0, j = 0;
                        foreach (DataRow row in tb.Rows)
                        {
                            listView1.Items.Add(row[0].ToString());
                            for (j = 1; j < tb.Columns.Count; j++)
                                listView1.Items[i].SubItems.Add(row[j].ToString());
                            i++;

                        }

                    }
                }
            }

        }*/
        private void HienSP()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_TTChiTietSanPham order by [Mã Sản Phẩm] ASC", conn))
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LaySize()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_Size ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txtSize.DataSource = tb;
                        txtSize.DisplayMember = "sSize";


                    }
                }
            }

        }
        private void LayColor()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_Color ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txt_color.DataSource = tb;
                        txt_color.DisplayMember = "sMau";


                    }
                }
            }

        }

        private void TimKiem()
        {
            int foundProductCount = 0;

            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string Command = "select * from v_TTChiTietSanPham where 1=1 ";
                    string @maSP = txtCodeSP.Text;
                    string @Name = txtTen.Text;
                    string @size = txtSize.Text;
                    string @color = txt_color.Text;

                    if (@maSP != "" && ckb_Code.Checked == true)
                    {
                        Command += "AND [Mã Sản Phẩm] = @MaSP ";
                    }
                    if (@Name != "" && ckb_Name.Checked == true)
                    {
                        Command += "AND [Tên Sản Phẩm] LIKE '%' + @TenSP + '%' ";
                    }
                    if (@size != "" && ckb_Size.Checked == true)
                    {
                        Command += "AND [Kích Thước] = @size ";
                    }
                    if (@color != "" && chk_Corlor.Checked == true)
                    {
                        Command += "AND [Màu Sắc] = @color ";
                    }
                    if(ckb_Size.Checked != true && ckb_Name.Checked != true && ckb_Code.Checked != true && chk_Corlor.Checked != true)
                    {
                        MessageBox.Show("Bạn Hãy Chọn Các Mục Để Tìm Kiếm");
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(Command, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        if (@maSP != "" && ckb_Code.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@MaSP", @maSP);
                        }
                        if (@Name != "" && ckb_Name.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@TenSP", @Name);
                        }
                        if (@size != "" && ckb_Size.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@size", @size);
                        }
                        if (@color != "" && chk_Corlor.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@color", @color);
                        }
                        con.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        foundProductCount = dt.Rows.Count;

                        lblFoundProductCount.Text = "Tìm thấy: " + foundProductCount + " sản phẩm";

                        dataGridView1.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
