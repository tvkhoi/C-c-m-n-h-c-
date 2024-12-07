using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = LAPTOP-I9P04673\\SQLEXPRESS; Initial Catalog= hsk;Integrated Security=True;";
            // Code nhập vào các biến để ghi vào SQL
            string input;
            string sMaSV, sHoTen, sDiaChi, sNgaySinh,sDienThoai;
            int gioiTinh;
            Console.Write("Nhap ma sinh vien: ");
            input = Console.ReadLine();
            sMaSV = input;
            Console.Write("Nhap ho va ten: ");
            input = Console.ReadLine();
            sHoTen = input;
            Console.Write("Nhap dia chi: ");
            input = Console.ReadLine();
            sDiaChi = input;
            Console.Write("Nhap ngay sinh: ");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            sNgaySinh = dateTime.ToString("yyyy/MM/dd");
            Console.Write("Nhap so dien thoai: ");
            input = Console.ReadLine();
            sDienThoai = input;
            Console.Write("Nhap gioi tinh (nam | nu): ");
            input = Console.ReadLine();
            if (input.Equals("nam"))
            {
                gioiTinh = 1;
            }
            else
            {
                gioiTinh = 0;
            }
            Console.WriteLine(sMaSV + sHoTen + sDiaChi + sNgaySinh + gioiTinh);
            bool conect;
            conect = ThemSinhVien(connectionString, sMaSV, sHoTen, sDiaChi, sNgaySinh,sDienThoai, gioiTinh);
        }
        private static bool ThemSinhVien(string connectionString, string sMaSV,
            string sHovaTen, string sDiaChi, string sNgaySinh,string sDienThoai, int gioitinh)
        {

            string insert_command = "INSERT INTO tblSINHVIEN " +
                                  "VALUES ('"+ sMaSV+ "', '"+ sHovaTen+ "', '" + sNgaySinh+ "', '"+ sDiaChi+ "', '"+ sDienThoai+ "', '" + gioitinh+"')";
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

                        return (i > 0);
                    }
                }
            
            
        }
    }
 }

