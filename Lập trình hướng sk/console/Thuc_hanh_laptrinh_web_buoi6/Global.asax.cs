﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Thuc_hanh_laptrinh_web_buoi6
{
    public class Global : System.Web.HttpApplication
    {
       
        protected void Application_Start(object sender, EventArgs e)
        {
          
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            
            Session["danhsach"] = new List<Nhanvien>();
            
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