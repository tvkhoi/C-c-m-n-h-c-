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

namespace Bai_Kiem_Tra_GK_WF
{
    public partial class FormGK2_TVK : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["baikiemtra"].ConnectionString;
        public FormGK2_TVK()
        {
            InitializeComponent();
        }
        public void loadGridView( DataGridView dataGridView)
        {
            if(radioButton_tatca_TVK.Checked==true)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {

                        using (SqlCommand cmd = conn.CreateCommand())
                        {

                            cmd.CommandText = "hiensinhvien";
                            cmd.CommandType = CommandType.StoredProcedure;
                            conn.Open();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                // Tạo một kho dữ liệu ảo
                                DataTable dataTable = new DataTable();
                                // Đổ dữ liệu từ csdl vào kho
                                adapter.Fill(dataTable);
                                // Ngắt kết nối
                                conn.Close();
                                foreach (DataRow dataRow in dataTable.Rows)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.CreateCells(dataGridView);
                                    row.Cells[0].Value = dataRow[0].ToString();
                                    row.Cells[1].Value = dataRow[1].ToString();
                                    row.Cells[2].Value = dataRow[2].ToString();
                                    row.Cells[3].Value = dataRow[3].ToString();
                                    row.Cells[4].Value = dataRow[4].ToString();

                                    dataGridView.Rows.Add(row);
                                    // Cách khác 
                                    //  DataGridViewRow row = new DataGridViewRow();
                                    //  // Đổ dữ liệu từ bảng ảo vào datagridView
                                    //  row.CreateCells(dataGridView);
                                    //  row.SetValues(dataRow.ItemArray);
                                    //  dataGridView.Rows.Add(row);

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString().Trim();
                }
            }
        }

        private void FormGK2_TVK_Load(object sender, EventArgs e)
        {
          
        }

        private void radioButton_tatca_TVK_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_tatca_TVK.Checked==true) {
                comboBox_ctdt_TVK.Items.Clear();
                dataGridView_sv.Rows.Clear();
                loadGridView(dataGridView_sv);
            }
            else
            {
                dataGridView_sv.Rows.Clear();
            }
        }

        private void radioButton_ctdt_TVK_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_ctdt_TVK.Checked==true) {
                comboBox_ctdt_TVK.Text = "";
                comboBox_ctdt_TVK.Items.Clear();
                do_du_lieu_vao_combo();
               
            }
            
        }
        public void do_du_lieu_vao_combo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblCTDT_TVK";
                        cmd.CommandType = System.Data.CommandType.Text;
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
                            // Ngắt kết nối


                            foreach (DataRow dataRow in dataTable.Rows)
                            {

                                comboBox_ctdt_TVK.Items.Add(dataRow[0].ToString()) ;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }

        private void comboBox_ctdt_TVK_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ctdt_TVK.BackColor = SystemColors.Window; // Màu nền mặc định
            if (comboBox_ctdt_TVK.Text.Trim() == "CTDT2017")
            {
                dataGridView_sv.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "ctdt";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ctdt", comboBox_ctdt_TVK.Text.Trim());
                        
                   //     int i = cmd.ExecuteNonQuery();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
                            // Ngắt kết nối
                            conn.Close();
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView_sv);
                                row.Cells[0].Value = dataRow[0].ToString();
                                row.Cells[1].Value = dataRow[1].ToString();
                                row.Cells[2].Value = dataRow[2].ToString();
                                row.Cells[3].Value = dataRow[3].ToString();
                                row.Cells[4].Value = dataRow[4].ToString();

                                dataGridView_sv.Rows.Add(row);
                                // Cách khác 
                                //  DataGridViewRow row = new DataGridViewRow();
                                //  // Đổ dữ liệu từ bảng ảo vào datagridView
                                //  row.CreateCells(dataGridView);
                                //  row.SetValues(dataRow.ItemArray);
                                //  dataGridView.Rows.Add(row);

                            }
                        }
                    }
                }
            }
                if (comboBox_ctdt_TVK.Text.Trim() == "CTDT2022")
                {
                    dataGridView_sv.Rows.Clear();
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                    conn.Open();
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "ctdt";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ctdt", comboBox_ctdt_TVK.Text.Trim());
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {

                                // Tạo một kho dữ liệu ảo
                                DataTable dataTable = new DataTable();
                                // Đổ dữ liệu từ csdl vào kho
                                adapter.Fill(dataTable);
                                // Ngắt kết nối
                                conn.Close();
                                foreach (DataRow dataRow in dataTable.Rows)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.CreateCells(dataGridView_sv);
                                    row.Cells[0].Value = dataRow[0].ToString();
                                    row.Cells[1].Value = dataRow[1].ToString();
                                    row.Cells[2].Value = dataRow[2].ToString();
                                    row.Cells[3].Value = dataRow[3].ToString();
                                    row.Cells[4].Value = dataRow[4].ToString();

                                    dataGridView_sv.Rows.Add(row);
                                    // Cách khác 
                                    //  DataGridViewRow row = new DataGridViewRow();
                                    //  // Đổ dữ liệu từ bảng ảo vào datagridView
                                    //  row.CreateCells(dataGridView);
                                    //  row.SetValues(dataRow.ItemArray);
                                    //  dataGridView.Rows.Add(row);

                                }
                            }
                            
                        }
                    }
                }
        }
    }
}
