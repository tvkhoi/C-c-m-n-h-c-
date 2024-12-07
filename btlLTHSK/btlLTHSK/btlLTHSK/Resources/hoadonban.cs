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
    internal class hoadonban
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        public hoadonban() { }
        public bool kiemtratontai(int sohd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "kiemtrakhoa_hdban";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@isohd", sohd);
                    cmd.Parameters.Add("@isExisting", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    bool i = Convert.ToBoolean(cmd.Parameters["@isExisting"].Value); // true nếu mã nv tồn tại

                    return i;
                }
            }
        }
        public void hien_HoaDonban(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblHoaDonMuaHang";
                        cmd.CommandType = System.Data.CommandType.Text;
                        
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
                            // Ngắt kết nối


                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                // Tạo một hàng mới
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView);

                                // Gán giá trị cho các ô của hàng
                                row.Cells[0].Value = dataRow[0].ToString();
                                row.Cells[1].Value = dataRow[1].ToString();
                                row.Cells[2].Value = dataRow[2].ToString();
                                row.Cells[3].Value = ((DateTime)dataRow[3]).ToString("dd/MM/yyyy");

                                // Tạo một button cho cột 4
                                DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                                buttonCell.Value = "Chi Tiết";

                                // Thêm button vào cột 4 của hàng
                                row.Cells[4] = buttonCell;

                                // Thêm hàng vào DataGridView
                                dataGridView.Rows.Add(row);
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

        public bool them_HoaDon_ban(int MaPN, string MaNV, string Makh, string NgayNhap)
        {


            string insert_command = "INSERT INTO tblHoaDonMuaHang " +
                         "VALUES (" + MaPN + ",'" + MaNV + "','" + Makh + "','" + NgayNhap +
                         "')";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = insert_command;

                    
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();

                    return i > 0;
                }
            }

        }
        public void uploadComboBox(ComboBox comboBox_manv, ComboBox comboBox_makh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select sMaNhanVien  from tblNhanVien";
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
                                comboBox_manv.Items.Add(dataRow[0]);

                            }
                        }
                        cmd.CommandText = "select distinct sMaDoiTac from tblDoiTac where sMaDoiTac like '%KH%'";
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (SqlDataAdapter adapters = new SqlDataAdapter(cmd))
                        {
                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapters.Fill(dataTable);
                            // Ngắt kết nối
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                comboBox_makh.Items.Add(dataRow[0]);
                            }
                            conn.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }
        public bool update_HoaDon_ban(int MaPN, string MaNV, string Makh, string Ngayban)
        { // Sửa HD
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "update_HoaDon_ban";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@iSoHDMH", MaPN);
                    command.Parameters.AddWithValue("@sMaNhanVien", MaNV);
                    command.Parameters.AddWithValue("@sMakh", Makh);
                    command.Parameters.AddWithValue("@dNgayban", Ngayban);
                    int i = command.ExecuteNonQuery();
                    conn.Close();
                    return i > 0;
                }
            }

        }
        public bool xoa_HD_ban(int MaPN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "delete_HoaDon_ban";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@iSoHDNH", MaPN);
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    return (i > 0);
                }
            }
        }
    }
}
