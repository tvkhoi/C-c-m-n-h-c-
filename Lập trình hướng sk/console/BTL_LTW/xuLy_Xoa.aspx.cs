using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW.Manage.GioHang
{
    public partial class xuLy_Xoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
            if (Request["sp"]!=null) { 
                string masp = Request["sp"].ToString();
                if (Application["giohang"] != null)
                {
                    DataTable gioHang = (DataTable)Application["giohang"];

                    // Lặp qua từng dòng trong DataTable để tìm và xóa sản phẩm cần xóa
                    for (int i = 0; i < gioHang.Rows.Count; i++)
                    {
                        if(gioHang.Rows[i]["masp"].ToString() == masp)
                        {
                            gioHang.Rows.RemoveAt(i); // Xóa sản phẩm khỏi DataTable
                            Application["giohang"] = gioHang; // Cập nhật lại giỏ hàng trong Application
                            
                            break; // Thoát khỏi vòng lặp sau khi xóa sản phẩm
                        }
                    }
                }
                // Sau khi xóa sản phẩm, cập nhật lại hiển thị trên giao diện   //  hienthidulieu();
            }
            Response.Redirect("https://localhost:44358/adminisTrator.aspx?id=giohang");
        }
    }
}