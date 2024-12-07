using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
    
        private static void Main(string[] args)
        {
            string connectionString = "Data Source = LAPTOP-I9P04673\\SQLEXPRESS; Initial Catalog= hsk;Integrated Security=True;";
            // Code nhập vào các biến để ghi vào SQL
            string input;
            string sMaSV, sHoTen, sDiaChi, sNgaySinh;
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
            Console.Write("Nhap gioi tinh (nam | nu): ");
            input = Console.ReadLine();
            if(input.Equals("nam")) {
                gioiTinh = 1;
            } 
            else
            {
                gioiTinh = 0;
            }
            Console.WriteLine(sMaSV + sHoTen + sDiaChi + sNgaySinh + gioiTinh);
            bool conect;
            conect = ThemSinhVien(connectionString,sMaSV, sHoTen, sDiaChi, sNgaySinh, gioiTinh);
        }
        private static bool ThemSinhVien(string connectionString,string sMaSV,
            string sHovaTen,string sDiaChi,string sNgaySinh,int gioitinh)
        {
            try
            {
                using(SqlConnetion sqlConnetion = new SqlConnetion(connectionString))
                {

                }
            } catch
            {

            }
            return true;
        }
    }
}