using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGiaoHang
{
    public class product
    {
        public int id;
        public string ten;
        public string image;
        public int giamgia;
        public int tien;
        public int soluong;
        public int thanhtien;

        public product() { }

        public product(int id, string ten, string image, int giamgia, int tien, int soluong, int thanhtien)
        {
            this.id = id;
            this.ten = ten;
            this.image = image;
            this.giamgia = giamgia;
            this.tien = tien;
            this.soluong = soluong;
            this.thanhtien = soluong * tien;
        }
    }
}