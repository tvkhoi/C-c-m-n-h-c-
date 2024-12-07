using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebChat
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["members"] = new List<Member>();
            Application["messages"] = new List<Message>();
            Application["guests"] = 0;
            Application["registered"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["guests"] = (int)Application["guests"] + 1;
            Session["member"] = new Member();
            Session["message"] = new Message();
            Session["registering"] = 0;
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