using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace b9
{
    public partial class xuly2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xml = "<xml>" +
                "<tenVXL>Tên VXL: " + Request.QueryString["cpuName"] + "</tenVXL>" +
                "<hang>Hãng: " + Request.QueryString["cpuFirm"] + "</hang>" +
                "<NgaySX>Ngày SX: " + Request.QueryString["cpuDate"] + "</NgaySX>" +
                "<Gia>Giá: " + Request.QueryString["cpuPrice"] + "</Gia></xml>";
            Response.ClearHeaders();
            Response.AddHeader("content-type", "text/xml");
            Response.Write(xml);
            Response.End();

        }

    }
}