using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW.Manage.GioHang
{
    public partial class giohangControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Application["giohang"]==null)
            {
                check_giohang.Style["display"] = "block";
            }
            else
            {
                check_giohang.Style["display"] = "none";
            }

        }
    }
}