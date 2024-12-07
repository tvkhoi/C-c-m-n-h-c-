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
    internal class QLChiTietHoaDon
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        public QLChiTietHoaDon()
        {

        }
        public bool them_ChiTietHD_Ban(double MaHD, string MaSP, double giaBan, double soLuong, double GiamGia)
        {         

            try
            {
                string insert_command = "INSERT INTO tblChiTietHDMuaHang " +
                                  "VALUES (" + MaHD + ", N'" + MaSP + "', " + giaBan + ", " + soLuong + ", " + GiamGia 
                                   + ")";
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

        public void hien_ChiTietHD_Ban(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "tblChiTietHDMuaHang_GiamGia_Hien";
                        cmd.CommandType = CommandType.StoredProcedure;
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
                                row.Cells[2].Value = dataRow[3].ToString();
                                row.Cells[3].Value = dataRow[4].ToString();
                                row.Cells[4].Value = dataRow[5].ToString();
                                row.Cells[5].Value = dataRow[6].ToString();
                               
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



        public bool update_ChiTietHD_Ban(double MaHD, string MaSP, double giaBan, double soLuong, int giamGia)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   using (SqlCommand command = conn.CreateCommand())
                   {
                      conn.Open();
                      command.Connection = conn;
                      command.CommandText = "update_ChiTietHD_Ban";
                      command.CommandType = CommandType.StoredProcedure;
                      command.Parameters.AddWithValue("@iCTHDMH", MaHD);
                      command.Parameters.AddWithValue("@sMaLT", MaSP);
                      command.Parameters.AddWithValue("@fDonGia", giaBan);
                      command.Parameters.AddWithValue("@fSoLuong", soLuong);
                      command.Parameters.AddWithValue("@fGiamGia", giamGia);
                      int i = command.ExecuteNonQuery();
                      conn.Close();                    
                      return i > 0;

                    }
                 }
            }
            catch
            {
                return false;
            }
            

        }



        public void xoa_ChiTietHD_Ban(double MaHD, string MaSP)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "xoa_ChiTietHDMuaHang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iCTHDMH", MaHD);
                    cmd.Parameters.AddWithValue("@sMaLaptop", MaSP);
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

        }
        public void cho_Nhap_So(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải là số
            }
            else { e.Handled = false; }
        }
        public void khongcho_nhap_tu_banphim(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)
                || char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự 
            }
            else { e.Handled = false; }
        }
    }
}
