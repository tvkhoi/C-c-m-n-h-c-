using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW.Manage.DonHang
{
    public partial class donhangControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["donhang"]!=null)
            {
                if (!IsPostBack)
                {
                    // Lấy DataTable từ Session
                    DataTable gioHang = (DataTable)Session["donhang"];

                    // Lấy DataTable từ Session
                    DataTable thongTinKhachHang = (DataTable)Session["thongtin_khachhang"];

                    // Kiểm tra xem DataTable có dữ liệu không
                    if (thongTinKhachHang != null && thongTinKhachHang.Rows.Count > 0)
                    {
                       
                         DataRow firstRow = thongTinKhachHang.Rows[0];
                         tenkh.InnerText = firstRow["tenkh"].ToString();
                         diachikh.InnerText = firstRow["diachikh"].ToString();
                         sdtkh.InnerText = firstRow["sdtkh"].ToString();
                         namsinh.InnerText = firstRow["namsinh"].ToString() ;
                        
                    }

                    // Kiểm tra xem có dữ liệu trong DataTable không
                    if (gioHang != null && gioHang.Rows.Count > 0)
                    {
                        // Tính tiền 
                        if (Session["donhang"] != null)
                        {
                            
                            decimal totalPrice = CalculateTotalPrice((DataTable)Session["donhang"]);
                            tongtien.InnerText = totalPrice.ToString("C").Replace("Rp", "") + "₫"; // Hiển thị tổng tiền với định dạng tiền tệ
                        }
                        // Gán DataTable làm nguồn dữ liệu cho ListView hoặc Repeater (tùy thuộc vào việc bạn sử dụng điều gì)
                        ListViewCart.DataSource = gioHang;
                        ListViewCart.DataBind();
                    }
                }
            }
            check();
        }
        public void check()
        {
            if (Session["donhang"] != null)
            {
                chitiet_donhang.Style["display"] = "block";
                donhang.Style["display"] = "none";
            }
            else
            {
                chitiet_donhang.Style["display"] = "none";
                donhang.Style["display"] = "block";
            }
        }
        // Tính tổng tiền của giỏ hàng
        private decimal CalculateTotalPrice(DataTable gioHang)
        {
            decimal totalPrice = 0;

            foreach (DataRow row in gioHang.Rows)
            {
                string giaStr = row["gia"].ToString().Replace(",", "").Replace(".", "").Replace("₫", ""); // Xóa kí tự không mong muốn
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