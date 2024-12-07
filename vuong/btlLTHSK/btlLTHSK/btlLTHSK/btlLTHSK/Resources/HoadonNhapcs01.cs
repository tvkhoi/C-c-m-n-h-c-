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
    internal class HoadonNhapcs01
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        public HoadonNhapcs01()
        {

        }
       

        public void hien_HoaDonPN(DataGridView dataGridView)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblHoaDonNhapHang";
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

        public bool them_HoaDon_PhieuNhap(double MaPN, string MaNV, string MaNCC ,string NgayNhap)
        {
            try
            {
                string insert_command = "INSERT INTO tblHoaDonNhapHang " +
                                  "VALUES (" + MaPN + ",'" + MaNV + "','" + MaNCC + "','"+NgayNhap +
                                   "')";
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

        public void update_HoaDon_PhieuNhap(double MaPN, string MaNV, string MaNCC, string NgayNhap)
        { // Sửa HD
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "update_HoaDon_PhieuNhap";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@iSoHDNH", MaPN);
                    command.Parameters.AddWithValue("@sMaNhanVien", MaNV);
                    //  command.Parameters.AddWithValue("@fSoLuon", TenSP);
                    command.Parameters.AddWithValue("@sMaNCC", MaNCC);
                    command.Parameters.AddWithValue("@dNgayNhap", NgayNhap);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa thành công !");

                }
            }

        }
        public void xoa_HD_PhieuNhap(double MaPN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    double a = MaPN;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "delete_HoaDon_PhieuNhap";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@iSoHDNH", MaPN);
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xoa thanh cong");
                }
            }
        }
        
      
       
            

    }
}
