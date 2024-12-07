using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace btlLTHSK.Resources
{
    internal class HoadonNhapcs01
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        public HoadonNhapcs01()
        {

        }
        public bool kiemtratontai(int sohd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "kiemtrakhoa_hdnhap";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@isohd", sohd);
                    cmd.Parameters.Add("@isExisting", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    bool i = Convert.ToBoolean(cmd.Parameters["@isExisting"].Value); // true nếu mã nv tồn tại

                    return i;
                }
            }
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

        public bool them_HoaDon_PhieuNhap(int MaPN, string MaNV, string MaNCC, string NgayNhap)
        {
         

                string insert_command = "INSERT INTO tblHoaDonNhapHang " +
                                  "VALUES (" + MaPN + ",'" + MaNV + "','" + MaNCC + "','" + NgayNhap +
                                   "')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = insert_command;

                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        connection.Close();

                        return i > 0;
                    }
                }

        }

        public bool update_HoaDon_PhieuNhap(int MaPN, string MaNV, string MaNCC, string NgayNhap)
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
                    command.Parameters.AddWithValue("@sMaNCC", MaNCC);
                    command.Parameters.AddWithValue("@dNgayNhap", NgayNhap);
                    int i = command.ExecuteNonQuery();
                    conn.Close();
                    return i > 0;
                }
            }

        }
      
        public bool xoa_HD_PhieuNhap(int MaPN)
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
                    return (i > 0);
                }
            }
        }


        public void search_HD_Nhap_duavaoMaNV(string sMaNV, DataGridView dataGridView)
        {

            try
            {
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.Connection = conn;
                        cmd.CommandText = "tim_kiem_Ma_NV_Nhap";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaNV", sMaNV);
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Tạo một kho dữ liệu ảo
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
                                // Tạo một button cho cột 4
                                DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                                buttonCell.Value = "Chi Tiết";

                                // Thêm button vào cột 4 của hàng
                                row.Cells[4] = buttonCell;

                                // Thêm hàng vào DataGridView
                                dataGridView.Rows.Add(row);
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
        public void search_HD_Nhap_duavaoMaNCC(string MaNCC, DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "tim_kiem_Ma_NCC";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaNCC", MaNCC);

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
                                // Tạo một button cho cột 4
                                DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                                buttonCell.Value = "Chi Tiết";

                                // Thêm button vào cột 4 của hàng
                                row.Cells[4] = buttonCell;

                                // Thêm hàng vào DataGridView
                                dataGridView.Rows.Add(row);
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
        public int search_HD_Nhap_duavaoMaNCC_sl(string MaNCC, DataGridView dataGridView)
        {
                int soluong = 0;
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "tim_kiem_Ma_NCC";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaNCC", MaNCC);

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
                                // Tạo một button cho cột 4
                                DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                                buttonCell.Value = "Chi Tiết";

                                // Thêm button vào cột 4 của hàng
                                row.Cells[4] = buttonCell;
                                soluong++;
                                // Thêm hàng vào DataGridView
                                
                                dataGridView.Rows.Add(row);
                               
                            }

                        }
                        conn.Close();
                    }
                }
                return soluong;
        }
        public void uploadComboBox(ComboBox comboBox_ma_NV, ComboBox comboBox_ma_NCC)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select sMaNhanVien from tblNhanVien";
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
                                comboBox_ma_NV.Items.Add(dataRow[0]);

                            }
                        }
                        cmd.CommandText = "select distinct sMaDoiTac from tblDoiTac where sMaDoiTac like '%NCC%'";
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
                                comboBox_ma_NCC.Items.Add(dataRow[0]);
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

    }
}
