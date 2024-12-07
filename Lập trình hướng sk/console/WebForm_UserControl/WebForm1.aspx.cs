using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_UserControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            switch (id) {
                case "trangchu":
                    PlaceHolder.Controls.Add(LoadControl("TrangChu.ascx"));
                    break;
                case "laptop":
                    PlaceHolder.Controls.Add(LoadControl("Laptop.ascx"));
                    break;
            }
        }
    }
}