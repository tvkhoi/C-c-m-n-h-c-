using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace btlLTHSK.Resources
{
    internal class sanpham
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        private ErrorProvider error = new ErrorProvider();
        private string maNCC;
        private string maLoai;

        public sanpham() { }
        public bool kiemtra_maSP(string masp, ErrorProvider error, TextBox textBox_MaSanPham)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
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

        public void update_sanpham(string sMaLaptop,
    string sTenLaptop, string sMaLoai, string sMaNCC, double fSoLuong, double fGiaBan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "updateSP";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaLaptop", sMaLaptop);
                    command.Parameters.AddWithValue("@TenLaptop", sTenLaptop);
                    command.Parameters.AddWithValue("@sMaLoai", sMaLoai);               
                    command.Parameters.AddWithValue("@sMaNCC", sMaNCC);
                    command.Parameters.AddWithValue("@fSoLuong", fSoLuong);
                    command.Parameters.AddWithValue("@fGiaBan", fGiaBan);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void xoa_SP(string sMaLaptop,
    string sTenLaptop, string sTenLoai, string sTenNCC, double fSoLuong, double fGiaBan)
        {
            //   try
            //    {
            string delete_sp = "xoaSP";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = delete_sp;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sTenLT", sTenLaptop);
                    cmd.Parameters.AddWithValue("@sMaLT", sMaLaptop);
                    cmd.Parameters.AddWithValue("@sTenNCC", sTenNCC);
                    cmd.Parameters.AddWithValue("@sTenLoaiLT", sTenLoai);
                    cmd.Parameters.AddWithValue("@fSoLuong", fSoLuong);
                    cmd.Parameters.AddWithValue("@fGiaBan", fGiaBan);

                    int i = cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
            //   }
            //    catch (Exception ex)
            //    {

            //   }
        }

        public bool ThemSP(string sMaLaptop, string sTenLaptop, string sMaLoai, string sMaNCC, double fSoLuong, double fGiaBan)
        {
            try
            {
                string insert_command = "INSERT INTO tblLapTop " +
                                  "VALUES ( '" + sMaLaptop + "',N'"+ sTenLaptop +"','" + sMaNCC + "','" + sMaLoai + "'," + fSoLuong +
                                   ","+fGiaBan+")";
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


        public void hien_SP(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select *from tblLapTop";
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
