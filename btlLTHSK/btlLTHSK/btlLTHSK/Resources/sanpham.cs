using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace btlLTHSK.Resources
{
    internal class sanpham
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;

        public sanpham() { }        
        public bool kiemtra_maSP(string masp, ErrorProvider error, TextBox textBox_MaSanPham)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "kiemtr_khoa_chinh_SanPham";
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.Parameters.AddWithValue("@maLT", masp);
                        cmd.Parameters.Add("@isExisting", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        bool i = Convert.ToBoolean(cmd.Parameters["@isExisting"].Value); // true nếu mã nv tồn tại
                        Console.WriteLine("Mã sinh viên đã tồn tại" + i);
                        conn.Close();
                        if (i)
                        {

                            error.SetError(textBox_MaSanPham, "Mã nhân viên đã tồn tại!");

                            return true;
                        }
                        else
                        {
                            error.SetError(textBox_MaSanPham, null);
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

        public bool update_sanpham(string sMaLaptop,
    string sTenLaptop, string sMaLoai, string sMaNCC, float fSoLuong, float fGiaBan)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "updateSp";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TenLaptop", sTenLaptop);
                    command.Parameters.AddWithValue("@MaLaptop", sMaLaptop);                    
                    command.Parameters.AddWithValue("@sMaLoai", sMaLoai);
                    command.Parameters.AddWithValue("@sMaNCC", sMaNCC);                    
                    command.Parameters.AddWithValue("@fSoLuong", fSoLuong);
                    command.Parameters.AddWithValue("@fGiaBan", fGiaBan);                    

                    int i =  command.ExecuteNonQuery();
                    conn.Close();
                    return i > 0;
                    
                }
            }
        }

        public bool xoa_SP(string sMaLaptop)
        {
          
            string delete_sp = "XoaSP";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = delete_sp;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaSP",sMaLaptop);                    
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();
                    return i > 0;
                }
            }
            
        }

        public void ThemSP(string sMaLaptop, string sTenLaptop, string sMaLoai, string sMaNCC, double fSoLuong, double fGiaBan)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "ThemSP";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@sMaLaptop", sMaLaptop);
                    command.Parameters.AddWithValue("@sTenLaptop", sTenLaptop);
                    command.Parameters.AddWithValue("@sMaNCC", sMaNCC);
                    command.Parameters.AddWithValue("@sMaLoai", sMaLoai);
                    command.Parameters.AddWithValue("@fSoLuong", fSoLuong);
                    command.Parameters.AddWithValue("@fGiaBan", fGiaBan);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        
        public void hien_SP(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select sMaLaptop, sTenLaptop, LLT.sMaLoai, sTenLoai, sMaDoiTac, sTenDoiTac, fSoLuong, fGiaBan from tblLaptop as LT, tblDoiTac as DT, tblLoaiLaptop as LLT where LT.sMaLoai = LLT.sMaLoai and LT.sMaNCC = DT.sMaDoiTac and DT.sMaDoiTac like '%NCC%'";
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
                                row.Cells[5].Value = dataRow[5].ToString();
                                row.Cells[6].Value = dataRow[6].ToString();
                                row.Cells[7].Value = dataRow[7].ToString();
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
        public void uploadComboBox(ComboBox comboBox_ma_loai,ComboBox comboBox_ma_NCC)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select sMaLoai from tblLoaiLaptop ";
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
                                comboBox_ma_loai.Items.Add(dataRow[0]);

                            }
                        }
                        cmd.CommandText = "select distinct sMaDoiTac from tblDoiTac inner join tblLaptop on sMaDoiTac = sMaNCC";
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

        public void layten_loai(string maloai, TextBox textBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT sTenLoai FROM tblLoaiLaptop WHERE sMaLoai = @maloai";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@maloai", maloai); // Sử dụng parameters để tránh SQL injection

                    connection.Open(); // Mở kết nối trước khi thực hiện command

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox.Text = reader["sTenLoai"].ToString(); // Đọc dữ liệu từ cột "sTenLoai"
                        }
                    }
                }
            }
        }
        public void layten_ncc(string maloai,TextBox textBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT sTenDoiTac FROM tblDoiTac WHERE sMaDoiTac = @madoitac and sMaDoiTac like '%NCC%'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@madoitac", maloai); // Sử dụng parameters để tránh SQL injection

                    connection.Open(); // Mở kết nối trước khi thực hiện command

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox.Text = reader["sTenDoiTac"].ToString(); // Đọc dữ liệu từ cột "sTenLoai"
                        }
                    }
                }
            }
        }
    }
}
