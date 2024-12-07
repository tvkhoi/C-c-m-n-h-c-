using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGiaoHang
{
    public partial class SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddProduct(string s)
        {
            var list = new List<product>() {
                new product()
                {
                    id = 1,
                    ten = "Điện Thoại 1",
                    image = "assets/img/sp1-1.jpg",
                    soluong = 1,
                    giamgia = 25000,
                    tien = 10000000
                },
                new product()
                {
                    id = 2,
                    ten = "Điện Thoại 2",
                    image = "assets/img/sp1-2.jpg",
                    soluong = 1,
                    giamgia = 320000,
                    tien = 2900000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 3,
                    ten = "Điện Thoại 3",
                    image = "assets/img/sp1-3.jpg",
                    soluong = 1,
                    giamgia = 120000,
                    tien = 1000000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 4,
                    ten = "Điện Thoại 4",
                    image = "assets/img/sp1-4.jpg",
                    soluong = 1,
                    giamgia = 50000,
                    tien = 30000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 5,
                    ten = "Điện Thoại 5",
                    image = "assets/img/sp1-5.jpg",
                    soluong = 1,
                    giamgia = 420000,
                    tien = 400000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 6,
                    ten = "Điện Thoại 6",
                    image = "assets/img/sp1-6.jpg",
                    soluong = 1,
                    giamgia = 30000,
                    tien = 25000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 7,
                    ten = "Điện Thoại 7",
                    image = "assets/img/sp2-1.jpg",
                    soluong = 1,
                    giamgia = 35000,
                    tien = 29000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 8,
                    ten = "Điện Thoại 8",
                    image = "assets/img/sp2-2.jpg",
                    soluong = 1,
                    giamgia = 23000,
                    tien = 20000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 9,
                    ten = "Điện Thoại 9",
                    image = "assets/img/sp2-3.jpg",
                    soluong = 1,
                    giamgia = 80000,
                    tien = 50000,
                    thanhtien = 1
                },new product()
                {
                    id = 10,
                    ten = "Điện Thoại 10",
                    image = "assets/img/sp2-4.jpg",
                    soluong = 1,
                    giamgia = 150000,
                    tien = 130000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 11,
                    ten = "Điện Thoại 11",
                    image = "assets/img/sp2-5.jpg",
                    soluong = 1,
                    giamgia = 20000,
                    tien = 16000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 12,
                    ten = "Điện Thoại 12",
                    image = "assets/img/sp2-6.jpg",
                    soluong = 1,
                    giamgia = 40000,
                    tien = 35000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 13,
                    ten = "Điện Thoại 13",
                    image = "assets/img/SP3-1.jpg",
                    soluong = 1,
                    giamgia = 330000,
                    tien = 25000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 14,
                    ten = "Điện Thoại 14",
                    image = "assets/img/SP3-2.jpg",
                    soluong = 1,
                    giamgia = 220000,
                    tien = 180000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 15,
                    ten = "Điện Thoại 15",
                    image = "assets/img/SP3-3.jpg",
                    soluong = 1,
                    giamgia = 420000,
                    tien = 400000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 16,
                    ten = "Điện Thoại 16",
                    image = "assets/img/sp3-4.jpg",
                    soluong = 1,
                    giamgia = 50000,
                    tien = 40000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 17,
                    ten = "Điện Thoại 17",
                    image = "assets/img/sp3-5.jpg",
                    soluong = 1,
                    giamgia = 35000,
                    tien = 28000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 18,
                    ten = "Điện Thoại 18",
                    image = "assets/img/sp3-6.jpg",
                    soluong = 1,
                    giamgia = 40000,
                    tien = 35000,
                    thanhtien = 1
                },
            };

            ArrayList arr = (ArrayList)Application["giohang"];
            int ok = 1;
            foreach (inforproduct i in arr)
            {
                if (i.img.ToString().CompareTo(s.ToString().Trim()) == 0)
                {
                    ok = 0;
                    i.soluong += 1;
                    break;
                }
            }
            if (ok == 1)
            {
                inforproduct temp = new inforproduct();
                temp.img = s.ToString().Trim();
                temp.soluong = 1;
                foreach (product product in list)
                {
                    if (product.image.ToString().CompareTo(s.ToString().Trim()) == 0)
                    {
                        temp.id = product.id;
                        break;
                    }
                }
                arr.Add(temp);
            }

        }

        public void function1(object sender, EventArgs e)
        {
            string s = stringImg1.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function2(object sender, EventArgs e)
        {
            string s = stringImg2.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function3(object sender, EventArgs e)
        {
            string s = stringImg3.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function4(object sender, EventArgs e)
        {
            string s = stringImg4.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function5(object sender, EventArgs e)
        {
            string s = stringImg5.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function6(object sender, EventArgs e)
        {
            string s = stringImg6.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function7(object sender, EventArgs e)
        {
            string s = stringImg7.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function8(object sender, EventArgs e)
        {
            string s = stringImg8.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function9(object sender, EventArgs e)
        {
            string s = stringImg9.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function10(object sender, EventArgs e)
        {
            string s = stringImg10.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function11(object sender, EventArgs e)
        {
            string s = stringImg11.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function12(object sender, EventArgs e)
        {
            string s = stringImg12.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function13(object sender, EventArgs e)
        {
            string s = stringImg13.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function14(object sender, EventArgs e)
        {
            string s = stringImg14.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function15(object sender, EventArgs e)
        {
            string s = stringImg15.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function16(object sender, EventArgs e)
        {
            string s = stringImg16.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function17(object sender, EventArgs e)
        {
            string s = stringImg17.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }
        public void function18(object sender, EventArgs e)
        {
            string s = stringImg18.Text.ToString();
            AddProduct(s);
            Response.Redirect("SanPham.aspx");
        }

    }
}