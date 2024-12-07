using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace btlLTHSK.Resources
{
    internal class Chitiet_hdon_ban
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        public Chitiet_hdon_ban() { }
        public bool kiemtratontai(int sohd, string masp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "kiemtratontaichitiet_ban";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@isohd", sohd);
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.Parameters.Add("@isExisting", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    bool i = Convert.ToBoolean(cmd.Parameters["@isExisting"].Value); // true nếu mã nv tồn tại

                    return i;
                }
            }
        }
        public bool them_ChiTiet_hoadon(int MaPN, string MaSP, decimal soLuong, decimal TGia, decimal giamgia)
        {
            
            string insert_command = "INSERT INTO tblChiTietHDMuaHang " +
                              "VALUES (" + MaPN + ", '" + MaSP + "', '"+TGia+"' ,  '" + soLuong + "' , " + giamgia +
                               ")";
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
        public bool update_ChiTiet_hoadon(int MaChiTietPN, string MaSP,
        float dongia, float Soluong, float TGiagia)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "update_ChiTiet_hoadon";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@iCTHDMH", MaChiTietPN);
                    command.Parameters.AddWithValue("@sMaLaptop", MaSP);
                    command.Parameters.AddWithValue("@fSoLuongNhap", Soluong);
                    command.Parameters.AddWithValue("@fgiamgia", TGiagia);
                    command.Parameters.AddWithValue("@fGiaban", dongia);


                    int i = command.ExecuteNonQuery();
                    conn.Close();
                    return i > 0;
                }
            }

        }
        public bool xoa_ChiTiet_PhieuNHap(int MaChiTietPN, string MaSP)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "xoa_ChiTiethoadon";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@iCTHDNH", MaChiTietPN);
                    cmd.Parameters.AddWithValue("@sMaLaptop", MaSP);
                    int i = cmd.ExecuteNonQuery();

                    connection.Close();
                    return i > 0;
                }
            }

        }
        public void uploadComboBox(ComboBox comboBox_ma_sp)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select sMaLaptop from tblLaptop";
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
                                comboBox_ma_sp.Items.Add(dataRow[0]);

                            }
                        }

                        conn.Close();

                    }
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }
        public void hien_ChiTiethd(DataGridView dataGridView, int sohd)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "dschitietban";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sohd", sohd);
                        
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
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
