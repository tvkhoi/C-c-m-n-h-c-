using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DemoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = "Data Source=admin;" +
            //                          "Initial Catalog=QLSV_Demo;" +
            //                          "Integrated Security=True";

            string connectionString = 
                ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;

            string maSV, tenSV, ngaySinh, diaChi, sdt, gioiTinh;
            DateTime dateTime;

            Console.Write("Nhap ma sinh vien: ");
            maSV = Console.ReadLine();
            Console.Write("Nhap ten sinh vien: ");
            tenSV = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            sdt = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            gioiTinh = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            dateTime = Convert.ToDateTime(Console.ReadLine());
            ngaySinh = dateTime.ToString("yyyy/MM/d");

            bool i = ThemSinhVien(connectionString, maSV, tenSV,
                ngaySinh, diaChi, sdt, IsGender(gioiTinh));

            if (i)
            {
                Console.WriteLine("Them moi thanh cong!");
            } else
            {
                Console.WriteLine("Them moi khong thanh cong!");
            }
        }

        public static bool IsGender (string gioiTinh)
        {
            bool index;
            if(gioiTinh.ToLower() == "nam")
            {
                index = true;
            }
            else
            {
                index = false;
            }
            return index;
        }

        public static bool ThemSinhVien (string connectionString, string maSV, string tenSV, string ngaySinh, string diaChi, string sdt, bool gioiTinh)
        {
            //string sqlInsert = "INSERT INTO tblSINHVIEN (sMaSV, sHoTen, dNgaySinh, sDiaChi, sSoDienThoai, bGioiTinh)" +
            //                   "VALUES('"+maSV+"',N'"+tenSV+"','"+ngaySinh+"',N'"+diaChi+"','"+sdt+"','"+gioiTinh+"')";
            string procInsert = "Insert_tblSINHVIEN";
            using (SqlConnection sqlConnection = 
                        new SqlConnection(connectionString))
            {
                using(SqlCommand sqlCommand = 
                        sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = procInsert;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@maSV", maSV);
                    sqlCommand.Parameters.Add("@tenSV", SqlDbType.NVarChar, 
                                                        50, "sHoTen").Value = tenSV;

                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    return i>0;
                }
            }
        }

        public static void HienSinhVien( string connectionString)
        {
            string procSelect = "Select_tblSINHVIEN";
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using(SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = procSelect;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    //su dung dataReader de doc va hien thi du lieu
                    sqlConnection.Open();
                    using(SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                                            dataReader["sMaSV"],
                                            dataReader["sHoTen"],
                                            dataReader["dNgaySinh"],
                                            dataReader["sDiaChi"]);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
        }
    }
}
