using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW
{
    public partial class xuLy_dat_hang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["tenkh"]!=null)
            {
                // Đưa dữ liệu vào List đơn hàng
                var dulieu = Application["giohang"];
                Session["donhang"] = dulieu;
                // lưu thông tin khách hàng
                DataTable dt = new DataTable();
                dt.Columns.Add("tenkh", typeof(string));
                dt.Columns.Add("diachikh", typeof(string));
                dt.Columns.Add("sdtkh", typeof(string));
                dt.Columns.Add("namsinh", typeof(string));
                dt.Rows.Add(Request.QueryString["tenkh"], Request.QueryString["diachikh"], Request.QueryString["sdtkh"], Request.QueryString["namsinh"]);
                Session["thongtin_khachhang"] = dt;
            }
            
            // xóa dữ liệu mỏ hàng
            Application.Remove("giohang");
            Response.Redirect("https://localhost:44358/adminisTrator.aspx?id=donhang");
        }
    }
}