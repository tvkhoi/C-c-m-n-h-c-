using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai_9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          Response.Write("Url: " + Request.Url.ToString());
          Response.Write("Cookies: " + Request.Cookies.ToString());
          Response.Write("ApplicationPath: " + Request.ApplicationPath.ToString());
            Response.Write("Browser" + Request.Browser.ToString());
        }
       
    }
}