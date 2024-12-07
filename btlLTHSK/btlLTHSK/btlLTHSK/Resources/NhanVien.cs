
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace btlLTHSK.Resources
{
    internal class NhanVien
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        public NhanVien() { }
        public bool kiemtra_maNV(string manv, ErrorProvider error, TextBox textBox_maNV)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "kiemtr_khoa_chinh_NhanVien";
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.Parameters.AddWithValue("@maNV", manv);
                        cmd.Parameters.Add("@isExisting", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        bool i = Convert.ToBoolean(cmd.Parameters["@isExisting"].Value); // true nếu mã nv tồn tại
                        Console.WriteLine("Mã sinh viên đã tồn tại" + i);
                        conn.Close();
                        if (i)
                        {

                            error.SetError(textBox_maNV, "Mã nhân viên đã tồn tại!");

                            return true;
                        }
                        else
                        {
                            error.SetError(textBox_maNV, null);
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
        public void tim_kiem_NhanVien_duavaoMa(string maNV, DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "tim_kiem_ma_NV ";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@maNV", maNV);

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
                                row.Cells[5].Value = dataRow[5].ToString();
                                row.Cells[6].Value = dataRow[6].ToString();
                                row.Cells[7].Value = dataRow[7].ToString();
                                row.Cells[8].Value = dataRow[8].ToString();


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
        public void tim_kiem_NhanVien_duavaoTen(string tenNV, DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "tim_kiem_ten_NV";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tenNV", tenNV);

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
                                row.Cells[5].Value = dataRow[5].ToString();
                                row.Cells[6].Value = dataRow[6].ToString();
                                row.Cells[7].Value = dataRow[7].ToString();
                                row.Cells[8].Value = dataRow[8].ToString();


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
        public void tim_kiem_NhanVien_duavaoDiaChi(string diachi, DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "tim_kiem_DiaChi_NV";
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
                                row.Cells[4].Value = dataRow[4].ToString();
                                row.Cells[5].Value = dataRow[5].ToString();
                                row.Cells[6].Value = dataRow[6].ToString();
                                row.Cells[7].Value = dataRow[7].ToString();
                                row.Cells[8].Value = dataRow[8].ToString();


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
        public void update_NhanVien(string sMaNhanVien,
    string sTenNhanVien, string gioitinh, string sDiaChi, string sdt, string dNgaysinh
    , string dNgayVaoLam, double fLuongCoBan, double fPhuCap)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "update_nhanVien";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@maNV", sMaNhanVien);
                    command.Parameters.AddWithValue("@tenNV", sTenNhanVien);
                    command.Parameters.AddWithValue("@gioitinh", gioitinh);
                    command.Parameters.AddWithValue("@diachi", sDiaChi);
                    command.Parameters.AddWithValue("@sdt", sdt);
                    command.Parameters.AddWithValue("@ngaysinh", dNgaysinh);
                    command.Parameters.AddWithValue("@ngayvaolam", dNgayVaoLam);
                    command.Parameters.AddWithValue("@luong", fLuongCoBan);
                    command.Parameters.AddWithValue("@phucap", fPhuCap);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void xoa_Nhanvien(string sMaNhanVien,
            string sTenNhanVien, string gioitinh, string sDiaChi, string sdt, string dNgaysinh
            , string dNgayVaoLam, double fLuongCoBan, double fPhuCap)
        {
            //   try
            //    {
            string delete_nv = "xoa_NhanVien";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = delete_nv;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNV", sMaNhanVien);
                    cmd.Parameters.AddWithValue("@tenNV", sTenNhanVien);
                    cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", sDiaChi);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@ngaysinh", dNgaysinh);
                    cmd.Parameters.AddWithValue("@ngayvaolam", dNgayVaoLam);
                    cmd.Parameters.AddWithValue("@luong", fLuongCoBan);
                    cmd.Parameters.AddWithValue("@phucap", fPhuCap);

                    int i = cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
            //   }
            //    catch (Exception ex)
            //    {

            //   }
        }
        public bool ThemSinhVien(string sMaNhanVien,
            string sTenNhanVien, string gioitinh, string sDiaChi, string sdt, string dNgaysinh
            , string dNgayVaoLam, double fLuongCoBan, double fPhuCap)
        {
            try
            {
                string insert_command = "INSERT INTO tblNhanVien " +
                                  "VALUES ('" + sMaNhanVien + "', N'" + sTenNhanVien + "', N'" + gioitinh + "', N'" + sDiaChi + "', '" + sdt +
                                  "', '" + dNgaysinh + "','" + dNgayVaoLam + "','" + fLuongCoBan + "','" + fPhuCap + "')";
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
        public void hien_NhanVien(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.CommandText = "select * from tblNhanVien";
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
                                row.Cells[5].Value = ((DateTime)dataRow[5]).ToString("dd/MM/yyyy");
                                row.Cells[6].Value = ((DateTime)dataRow[6]).ToString("dd/MM/yyyy");
                                row.Cells[7].Value = dataRow[7].ToString();
                                row.Cells[8].Value = dataRow[8].ToString();


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
}