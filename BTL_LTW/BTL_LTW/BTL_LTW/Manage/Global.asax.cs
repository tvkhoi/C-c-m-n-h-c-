using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_LTW.Manage
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
           Application["giohang"] = new DataTable();
           Application["danhsach_sanpham"] = new DataTable();

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["tinhieuxoa_sanpham"] = "";   
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
  
    }
}