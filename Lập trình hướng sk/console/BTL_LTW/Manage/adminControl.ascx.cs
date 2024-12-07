using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW.Manage
{
    public partial class adminControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            
            switch (id) {
                case "donhang":
                    placeholder.Controls.Add(LoadControl("DonHang/donhangControl.ascx"));
                    break;
                case "chitietsanpham":
                    placeholder.Controls.Add(LoadControl("Chitietsanpham/chitietsanphamControl.ascx"));
                    break;
                case "giohang":
                    placeholder.Controls.Add(LoadControl("GioHang/giohangControl.ascx"));
                    footerControl.Visible = false;
                    break;
                case "laptopvanphong":
                        placeholder.Controls.Add(LoadControl("Laptop_vanphong/laptopvanphongControl.ascx"));
                    break;
                case "laptopgaming":
                    placeholder.Controls.Add(LoadControl("Laptop_gaming/laptopgamingControl.ascx"));
                    break;
                case "laptopgear":
                    placeholder.Controls.Add(LoadControl("Laptop_gear/laptopgearControl.ascx"));
                    break;
                case "phukien":
                    placeholder.Controls.Add(LoadControl("Phukien/phukienControl.ascx"));
                    break;
                case "phanmem":
                    placeholder.Controls.Add(LoadControl("Phanmem/phanmemControl.ascx"));
                    break;
                default :
                    placeholder.Controls.Add(LoadControl("TrangChu/trangchuControl.ascx"));
                    break;
            }

            
        }

       
    }
}