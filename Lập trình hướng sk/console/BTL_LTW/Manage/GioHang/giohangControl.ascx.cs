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
            try
            {
                // Kiểm tra xem có tham số 'sp' trong URL không
                if (!string.IsNullOrEmpty(Request.QueryString["sp"]))
                {
                    // Lấy ID sản phẩm từ URL
                    string spID = Request.QueryString["sp"];

                    // Lấy thông tin sản phẩm từ Application hoặc bất kỳ nguồn dữ liệu nào khác
                    DataTable danhSachSanPham = (DataTable)Application["danhsach_sanpham"];

                    // Tìm sản phẩm trong danh sách dựa trên ID
                    DataRow[] rows = danhSachSanPham.Select("masp = '" + spID + "'");

                    // Nếu tìm thấy sản phẩm, thêm vào giỏ hàng
                    if (rows.Length > 0)
                    {
                        DataRow product = rows[0];
                        AddToCart(product);
                    }
                }

                // Hiển thị dữ liệu từ giỏ hàng ra màn hình 
                BindCartData();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
            }
        }

        // Thêm sản phẩm vào giỏ hàng
        private void AddToCart(DataRow product)
        {
            string masp = product["masp"].ToString();
            string hinhanh = product["hinhanh"].ToString();
            string mota = product["mota"].ToString();
            string gia = product["gia"].ToString();
            string giagoc = product["giagoc"].ToString();

            if (Application["giohang"] != null)
            {
                DataTable gioHang = (DataTable)Application["giohang"];

                // Kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
                DataRow[] existingProducts = gioHang.Select("masp = '" + masp + "'");
                if (existingProducts.Length == 0)
                {
                    // Thêm sản phẩm mới vào giỏ hàng
                    gioHang.Rows.Add(masp, hinhanh, mota, gia, giagoc);
                }
            }
            else
            {
                // Khởi tạo giỏ hàng nếu chưa tồn tại
                DataTable gioHang = new DataTable();
                gioHang.Columns.Add("masp", typeof(string));
                gioHang.Columns.Add("hinhanh", typeof(string));
                gioHang.Columns.Add("mota", typeof(string));
                gioHang.Columns.Add("gia", typeof(string));
                gioHang.Columns.Add("giagoc", typeof(string));
                gioHang.Rows.Add(masp, hinhanh, mota, gia, giagoc);
                Application["giohang"] = gioHang;
            }
        }

        // Hiển thị dữ liệu từ giỏ hàng ra màn hình
        private void BindCartData()
        {
            if (Application["giohang"] != null)
            {
                DataTable gioHang = (DataTable)Application["giohang"];

                if (gioHang.Rows.Count > 0)
                {
                    ListViewCart.DataSource = gioHang;
                    ListViewCart.DataBind();

                    // Hiển thị phần giỏ hàng
                    check_giohang.Style["display"] = "none";
                    thongtinkhachhang.Style["display"] = "block";
                }
                else
                {
                    // Hiển thị thông báo giỏ hàng trống
                    check_giohang.Style["display"] = "block";
                    thongtinkhachhang.Style["display"] = "none";
                }
            }
            else
            {
                // Hiển thị thông báo giỏ hàng trống
                check_giohang.Style["display"] = "block";
                thongtinkhachhang.Style["display"] = "none";
            }
            // Tính tiền 
            if (Application["giohang"] != null)
            {
                DataTable gioHang = (DataTable)Application["giohang"];
                decimal totalPrice = CalculateTotalPrice(gioHang);
                tongtien.InnerText = totalPrice.ToString("C").Replace("Rp","")+ "₫"; // Hiển thị tổng tiền với định dạng tiền tệ
            }
        }

        // Tính tổng tiền của giỏ hàng
        private decimal CalculateTotalPrice(DataTable gioHang)
        {
            decimal totalPrice = 0;

            foreach (DataRow row in gioHang.Rows)
            {
                string giaStr = row["gia"].ToString().Replace(",", "").Replace(".", "").Replace("₫",""); // Xóa kí tự không mong muốn
                decimal gia;
                if (decimal.TryParse(giaStr, out gia))
                {
                    totalPrice += gia;
                }
            }

            return totalPrice;
        }



    }
}