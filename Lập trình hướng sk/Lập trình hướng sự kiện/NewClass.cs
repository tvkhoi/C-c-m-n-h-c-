using System;

namespace Lập_trình_hướng_sự_kiện
{
    public class NewClass
    {
      string connectionString = "Data Source = LAPTOP-I9P04673\\SQLEXPRESS;"+
                                "Initial Catalog= hsk;"+
                                "Integrated Security=True;";
       static void Main(string[] args) {
        string a = "Nguyen van A";
         object o = a;
         string b = (string) o;
         Console.WriteLine(b);
         Console.Beep();
         float ia , ib;
         string input;
         Console.Write("Nhap so a: ");
         input = Console.ReadLine();
         ia = float.Parse(input);
         Console.Write("Nhap so b: ");
         input = Console.ReadLine();
         ib = float.Parse(input);
         Console.WriteLine("Tong a + b : "+ (ia+ib));
         
       }
    }
   
}