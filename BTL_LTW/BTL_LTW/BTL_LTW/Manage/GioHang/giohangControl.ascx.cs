using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW.Manage.GioHang
{
    public partial class giohangControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                try { 

                // Thêm dữ liệu vào giỏ hàng nếu có sự yêu cầu của người dùng
                if (Application["danhsach_sanpham"] != null)
                {
                    string hinhanh = "";
                    string masp = "";
                    string mota = "";
                    string gia = "";
                    string  giagoc = "";
                    DataTable dataTable = (DataTable)Application["danhsach_sanpham"];
                    // Lặp qua từng dòng trong DataTable để in ra giá trị của các cột
                    if (Request["sp"]!=null) { 
                    foreach (DataRow row in dataTable.Rows)
                    {

                        if (row["masp"].ToString() == Request["sp"].ToString())
                        {
                            hinhanh = string.Format(row["hinhanh"].ToString());
                            masp = row["masp"].ToString();
                            mota = row["mota"].ToString();
                            gia = row["gia"].ToString();
                            giagoc = row["giagoc"].ToString();
                        }
                       
                    }
                    if (Application["giohang"] != null)
                            {

                                DataTable dataTablea = (DataTable)Application["giohang"];
                                foreach (DataRow row in dataTablea.Rows)
                                {
                                        string masptrunggian = row["masp"].ToString();
                                        if(masptrunggian.Equals(masp)==true)
                                        {
                                            check();
                                            return;
                                        }
                                }
                                // Thêm dữ liệu vào DataTable nếu đã có
                                dataTablea.Rows.Add(masp, hinhanh, mota, gia, giagoc);
                                Application["giohang"] = dataTablea;
                            }
                            else
                            {
                                // Khởi tạo DataTable mới nếu chưa tồn tại
                                DataTable dataTablef = new DataTable();
                                dataTablef.Columns.Add("masp", typeof(string));
                                dataTablef.Columns.Add("hinhanh", typeof(string));
                                dataTablef.Columns.Add("mota", typeof(string));
                                dataTablef.Columns.Add("gia", typeof(string));
                                dataTablef.Columns.Add("giagoc", typeof(string));
                                dataTablef.Rows.Add(masp, hinhanh, mota, gia, giagoc);

                                Application["giohang"] = dataTablef;
                            }
                        
                       }
                   
                }

                // Gán DataTable mới làm nguồn dữ liệu cho ListView
                    ListViewCart.DataSource = Application["giohang"];
                    ListViewCart.DataBind();
            }
            catch { }



            check();
            
            
        }
        public void check()
        {
            // Load dữ liệu từ giỏ hàng ra màn hình 
            if (Application["giohang"] == null)
            {
                check_giohang.Style["display"] = "block";
                thongtinkhachhang.Style["display"] = "none";
            }
            else
            {
                check_giohang.Style["display"] = "none";
                thongtinkhachhang.Style["display"] = "block";
            }
        }
        public void XoaSanPham(string masp)
        {
            Response.Write("fjfjfjfjffkkkkkkkkkkkkkkkkkkkkkkkkk");
            masp = "sp1";
            if (Application["giohang"] != null)
            {
                DataTable gioHang = (DataTable)Application["giohang"];

                // Lặp qua từng dòng trong DataTable để tìm và xóa sản phẩm cần xóa
                for (int i = 0; i < gioHang.Rows.Count; i++)
                {
                    if (gioHang.Rows[i]["masp"].ToString() == masp)
                    {
                        gioHang.Rows.RemoveAt(i); // Xóa sản phẩm khỏi DataTable
                        Application["giohang"] = gioHang; // Cập nhật lại giỏ hàng trong Application
                        break; // Thoát khỏi vòng lặp sau khi xóa sản phẩm
                    }
                }
            }

            // Sau khi xóa sản phẩm, cập nhật lại hiển thị trên giao diện
           // hienthidulieu();
        }



    }
}