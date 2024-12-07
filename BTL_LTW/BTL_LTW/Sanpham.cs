using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_LTW
{
    public class Sanpham
    {
        private string hinhanh;
        private string ten;
        private string mota;
        private string gia;
        private string giagoc;
        private string giamgia;
        private int soluong;
        public Sanpham() { }
        public string Hinhanh
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }

        public string Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public string Giagoc
        {
            get { return giagoc; }
            set { giagoc = value; }
        }

        public string Giamgia
        {
            get { return giamgia; }
            set { giamgia = value; }
        }

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
    }
}