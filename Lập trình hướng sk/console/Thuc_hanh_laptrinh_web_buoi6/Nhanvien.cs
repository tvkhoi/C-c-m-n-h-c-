using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thuc_hanh_laptrinh_web_buoi6
{
     
    public class Nhanvien
    {
        private string hoten;
        private String nam_Sinh;
        public Nhanvien(string hoten,String namsinh) { 
            this.hoten = hoten;
            this.nam_Sinh = namsinh;
        }
        public Nhanvien() { }
        public string hoten_NV
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public String nam_sinh_NV
        {
            get { return nam_Sinh; }
            set { nam_Sinh = value; }
        }
    }
}