using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FileName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string ten = TextBox_ten.Text;

           // string strBuider = "<script> alert('"+ten+"') </ script > ";
           // Response.Write(strBuider);
           if(!string.IsNullOrEmpty(ten))
            {
                Label2.Text = "Welcome, "+ Server.HtmlEncode(ten) +"<br/> The url is "+ Server.UrlEncode(Request.Url.ToString());
            }
           // Server.Execute("fajfjff.aspx");
            Server.Transfer("fajfjff.aspx");
           
        }

        protected void textbox_name_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox_ten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}