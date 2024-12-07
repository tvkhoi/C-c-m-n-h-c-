using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGiaoHang
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = new List<product>() {
                new product()
                {
                    id = 1,
                    ten = "Iphone 1",
                    image = "assets/img/sp1-1.jpg",
                    soluong = 1,
                    giamgia = 25000,
                    tien = 19000
                },
                new product()
                {
                    id = 2,
                    ten = "Iphone 2",
                    image = "assets/img/sp1-2.jpg",
                    soluong = 1,
                    giamgia = 320000,
                    tien = 290000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 3,
                    ten = "Iphone 3",
                    image = "assets/img/sp1-3.jpg",
                    soluong = 1,
                    giamgia = 120000,
                    tien = 100000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 4,
                    ten = "Iphone 4",
                    image = "assets/img/sp1-4.jpg",
                    soluong = 1,
                    giamgia = 50000,
                    tien = 30000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 5,
                    ten = "Iphone 5",
                    image = "assets/img/sp1-5.jpg",
                    soluong = 1,
                    giamgia = 420000,
                    tien = 400000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 6,
                    ten = "Iphone 6",
                    image = "assets/img/sp1-6.jpg",
                    soluong = 1,
                    giamgia = 30000,
                    tien = 25000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 7,
                    ten = "Samsung 1",
                    image = "assets/img/sp2-1.jpg",
                    soluong = 1,
                    giamgia = 35000,
                    tien = 29000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 8,
                    ten = "Samsung 2",
                    image = "assets/img/sp2-2.jpg",
                    soluong = 1,
                    giamgia = 23000,
                    tien = 20000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 9,
                    ten = "Samsung 3",
                    image = "assets/img/sp2-3.jpg",
                    soluong = 1,
                    giamgia = 80000,
                    tien = 50000,
                    thanhtien = 1
                },new product()
                {
                    id = 10,
                    ten = "Samsung 4",
                    image = "assets/img/sp2-4.jpg",
                    soluong = 1,
                    giamgia = 150000,
                    tien = 130000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 11,
                    ten = "Samsung 5",
                    image = "assets/img/sp2-5.jpg",
                    soluong = 1,
                    giamgia = 20000,
                    tien = 16000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 12,
                    ten = "Samsung 6",
                    image = "assets/img/sp2-6.png",
                    soluong = 1,
                    giamgia = 40000,
                    tien = 35000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 13,
                    ten = "Xiaomi 1",
                    image = "assets/img/SP3-1.jpg",
                    soluong = 1,
                    giamgia = 330000,
                    tien = 25000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 14,
                    ten = "Xiaomi 2",
                    image = "assets/img/SP3-2.png",
                    soluong = 1,
                    giamgia = 220000,
                    tien = 180000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 15,
                    ten = "Xiaomi 3",
                    image = "assets/img/SP3-3.jpg",
                    soluong = 1,
                    giamgia = 420000,
                    tien = 400000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 16,
                    ten = "Xiaomi 4",
                    image = "assets/img/sp3-4.jpg",
                    soluong = 1,
                    giamgia = 50000,
                    tien = 40000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 17,
                    ten = "Xiaomi 5",
                    image = "assets/img/sp3-5.jpg",
                    soluong = 1,
                    giamgia = 35000,
                    tien = 28000,
                    thanhtien = 1
                },
                new product()
                {
                    id = 18,
                    ten = "Xiaomi 6",
                    image = "assets/img/sp3-6.jpg",
                    soluong = 1,
                    giamgia = 40000,
                    tien = 35000,
                    thanhtien = 1
                },
            };

            ArrayList arr = (ArrayList)Application["giohang"];
            int cnt = 0;
            Int64 sum = 0;

            foreach (inforproduct i in arr)
            {
                cnt++;
            }

            SoluongSP.Text = cnt.ToString() + "<br/>";

            if (cnt > 0)
            {

                if (System.Web.HttpContext.Current.Session["cart"] == null)
                {
                    crateCart();
                }

                System.Web.HttpContext.Current.Session["cart"] = null;
                DataTable dt = new DataTable();
                dt.Columns.Add("productID", typeof(Int32));
                dt.Columns.Add("name", typeof(string));
                dt.Columns.Add("img", typeof(string));
                dt.Columns.Add("soluong", typeof(Int32));
                dt.Columns.Add("giatien", typeof(string));
                dt.Columns.Add("thanhtien", typeof(Int32));
                DataRow dr;


                foreach (inforproduct i in arr)
                {
                    foreach (product product in list)
                    {
                        if (product.image.ToString().CompareTo(i.img.ToString().Trim()) == 0)
                        {
                            dr = dt.NewRow();
                            dr["productID"] = product.id;
                            dr["name"] = product.ten.ToString();
                            dr["img"] = product.image.ToString();
                            dr["soluong"] = i.soluong;
                            dr["giatien"] = product.tien;
                            dr["thanhtien"] = i.soluong * product.tien;

                            sum += i.soluong * product.tien;
                            dt.Rows.Add(dr);
                        }
                    }
                }

                System.Web.HttpContext.Current.Session["cart"] = dt;
                DataTable u = new DataTable();
                u = (DataTable)System.Web.HttpContext.Current.Session["cart"];
                d2.DataSource = u;
                d2.DataBind();
            }
            lblTongTien.Text = sum.ToString() + "VND";
        }


        protected void crateCart()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("productID", typeof(Int32));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("img", typeof(string));
            dt.Columns.Add("soluong", typeof(Int32));
            dt.Columns.Add("giatien", typeof(string));
            dt.Columns.Add("thanhtien", typeof(Int32));

            d2.DataSource = dt;
            d2.DataBind();
            System.Web.HttpContext.Current.Session["cart"] = dt;
        }

        public void delete(object sender, EventArgs e)
        {
            int id = int.Parse(((sender as LinkButton).NamingContainer.FindControl("lblProductID") as Label).Text);

            ArrayList arr = (ArrayList)Application["giohang"];
            int j = 0;
            foreach (inforproduct i in arr)
            {
                if (i.id == id)
                {
                    break;
                }
                j++;
            }
            arr.RemoveAt(j);

            Response.Redirect("GioHang.aspx");
        }

        protected int KiemTra(string s)
        {
            int ans = 0;
            int ok = 1;

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] - 48 > 9 || s[i] - 48 < 0)
                {
                    ok = 0;
                    break;
                }
                else
                {
                    ans = ans * 10 + (s[i] - 48);
                }
            }
            if (ok == 1) return ans;
            else return -1;
        }

        protected void Update(object sender, EventArgs e)
        {

            string s = IDThaydoi.Text;
            string ss = SLThaydoi.Text;


            if (s == "" || ss == "")
            {
                lblLoiUpdate.Text = "Không được để trống !!!!" + "<br/>";
            }
            else
            {
                int u = KiemTra(s);
                int v = KiemTra(ss);

                if (u == -1 || v == -1)
                {
                    lblLoiUpdate.Text = "Chỉ chấp nhận ký tự là số !!! Hãy thử nhập lại" + "<br/>";
                    IDThaydoi.Text = string.Empty;
                    SLThaydoi.Text = string.Empty;
                }
                else
                {
                    if (v <= 0)
                    {
                        lblLoiUpdate.Text = "Số lượng thay đổi không thể nhỏ hơn hoặc bằng 0 !!!!" + "<br/>";
                    }
                    else
                    {
                        int ok = 1;
                        string k = "";
                        ArrayList arr = (ArrayList)Application["giohang"];
                        foreach (inforproduct i in arr)
                        {
                            if (u == i.id)
                            {
                                i.soluong = v;
                                ok = 0;
                                break;
                            }

                            k += i.id;
                        }

                        if (ok == 1)
                        {
                            lblLoiUpdate.Text = "Không tìm thấy ID của sản phẩm trong giỏ hàng!!!!" + "<br/>";
                        }
                        else
                        {
                            Response.Redirect("GioHang.aspx");
                        }
                    }
                }
            }
        }

        protected void Muahang(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                lblMuaHangLoi.Text = "Vui lòng đăng nhập vô hệ thống để tiến hành thanh toán!!!" + "<br/>";
            }
            else
            {
                ArrayList arr = (ArrayList)Application["giohang"];
                int j = 0;
                arr.Clear();
                Response.Redirect("TrangChu.aspx");
            }
        }

        
    }
}