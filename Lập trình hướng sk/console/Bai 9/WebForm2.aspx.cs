using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai_9
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Url: " + Request.Url.ToString());
            Response.Write("<br>Cookies: " + Request.Cookies.ToString());
            Response.Write("<br>ApplicationPath: " + Request.ApplicationPath.ToString());
            Response.Write("<br>Browser: " + Request.Browser.ToString());
            Response.Write("<br>QueryString: " + Request.QueryString.ToString());
        }
    }
}