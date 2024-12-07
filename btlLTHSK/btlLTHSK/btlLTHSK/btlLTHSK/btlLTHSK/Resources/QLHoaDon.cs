using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
namespace btlLTHSK.Resources
{
    internal class QLHoaDon
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;


        public QLHoaDon() { }

        public void update_HoaDon(double MaHD, string sMaNV, string sMaKH, string dNgayBan)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = conn.CreateCommand())
                {

                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "update_HDMuaHang";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@iCTHDMH", MaHD);
                    command.Parameters.AddWithValue("@sMaNhanVien", sMaNV);
                    command.Parameters.AddWithValue("@sMaKhachHang", sMaKH);
                    command.Parameters.AddWithValue("@dNgayMuaHang", dNgayBan);
                    int i = command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa hóa đơn thành công!");
                }
            }
        }

        public void xoa_HoaDon(double MaHD, string sMaNV, string sMaKH, string dNgayBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {


                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "delete_HoaDonMH";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iSoHDMH", MaHD);
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }

        }
        public bool ThemHoaDon(double MaHD, string sMaNV, string sMaKH, string dNgayBan)
        {
            try
            {
                string insert_command = "INSERT INTO tblHoaDonMuaHang " +
                                  "VALUES ('" + MaHD + "', N'" + sMaNV + "', N'" + sMaKH + "', N'" + dNgayBan + "')";
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
            catch
            {
                return false;

            }
        }

        public void hien_HoaDon(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblHoaDonMuaHang";
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
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView);
                                row.Cells[0].Value = dataRow[0].ToString();
                                row.Cells[1].Value = dataRow[1].ToString();
                                
                                row.Cells[2].Value = dataRow[2].ToString();
                                row.Cells[3].Value = dataRow[3].ToString();
                                row.Cells[4].Value = "Chi Tiết";
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


    }
}