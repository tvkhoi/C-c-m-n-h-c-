using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlLTHSK.Resources
{
    internal class NCC
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        public NCC() { }
        public bool kiemtra_maNCC(string maNCC, ErrorProvider error, TextBox textBox_maNCC)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "kiemtr_khoa_chinh_NCC";
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.Parameters.AddWithValue("@maNCC", maNCC);
                        cmd.Parameters.Add("@isExisting", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        bool i = Convert.ToBoolean(cmd.Parameters["@isExisting"].Value); // true nếu mã nv tồn tại

                        conn.Close();
                        if (i)
                        {

                            error.SetError(textBox_maNCC, "Mã NCC đã tồn tại!");

                            return true;
                        }
                        else
                        {
                            error.SetError(textBox_maNCC, null);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool kiemtra_email(string email, ErrorProvider error, TextBox textBox_maNCC)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "kiemtr_khoa_email";
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.Add("@isExisting", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        bool i = Convert.ToBoolean(cmd.Parameters["@isExisting"].Value); // true nếu mã nv tồn tại

                        conn.Close();
                        if (i)
                        {

                            error.SetError(textBox_maNCC, "email đã tồn tại!");

                            return true;
                        }
                        else
                        {
                            error.SetError(textBox_maNCC, null);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void hien_NCC(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.CommandText = "select * from tblDoiTac where sMaDoiTac LIKE '%NCC%'";
                        cmd.CommandType = System.Data.CommandType.Text;
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
        public bool ThemNCC(string sMaNCC,
string sTenNCC, string sDiaChi, string sdt,string email)
        {
            try
            {
                string insert_command = "INSERT INTO tblDoiTac " +
                                  "VALUES ('" + sMaNCC + "', N'" + sTenNCC + "', '" + sdt + "', N'" + sDiaChi + "','"+email+"')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = insert_command;

                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        connection.Close();

                        return i > 0;
                    }
                }
            }
            catch (Exception exf) { }
            {

                return false;

            }



        }

        public void tim_kiem_NCC_duavaoSDT(string sdt, DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "tim_kiem_sdt_NCC";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sdt", sdt);

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

                                dataGridView.Rows.Add(row);
                                // Cách khác 
                                //  DataGridViewRow row = new DataGridViewRow();
                                //  // Đổ dữ liệu từ bảng ảo vào datagridView
                                //  row.CreateCells(dataGridView);
                                //  row.SetValues(dataRow.ItemArray);
                                //  dataGridView.Rows.Add(row);

                            }



                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
        public void tim_kiem_NCC_duavaoTen(string ten, DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "tim_kiem_ten_NCC";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ten", ten);

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

                                dataGridView.Rows.Add(row);
                                // Cách khác 
                                //  DataGridViewRow row = new DataGridViewRow();
                                //  // Đổ dữ liệu từ bảng ảo vào datagridView
                                //  row.CreateCells(dataGridView);
                                //  row.SetValues(dataRow.ItemArray);
                                //  dataGridView.Rows.Add(row);

                            }



                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
        public void tim_kiem_NCC_duavaoDiaChi(string diachi, DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "tim_kiem_diachi_NCC";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@diachi", diachi);

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

                                dataGridView.Rows.Add(row);
                                // Cách khác 
                                //  DataGridViewRow row = new DataGridViewRow();
                                //  // Đổ dữ liệu từ bảng ảo vào datagridView
                                //  row.CreateCells(dataGridView);
                                //  row.SetValues(dataRow.ItemArray);
                                //  dataGridView.Rows.Add(row);

                            }



                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
       public bool suaNCC(string maNCC,string tenNCC, string lienhe,string sdt,string email)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using(SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "suaNCC";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@maNCC", maNCC);
                    cmd.Parameters.AddWithValue("@tenNCC", tenNCC);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@diachi", lienhe);
                    cmd.Parameters.AddWithValue("@email", email);
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    return i > 0;
                }
            }
        }
       // public bool xoaNCC(string maNCC)
       // {
          //  using (SqlConnection con = new SqlConnection(connectionString))
         //   {
          //      con.Open();
          //      using (SqlCommand cmd = con.CreateCommand())
           //     {
            //        cmd.CommandText = "suaNCC";
            //        cmd.CommandType = CommandType.StoredProcedure;

           //         cmd.Parameters.AddWithValue("@maNCC", maNCC);

           //         int i = cmd.ExecuteNonQuery();
           //         con.Close();
          //          return i > 0;
          //      }
          //  }
       // }
    }
}
