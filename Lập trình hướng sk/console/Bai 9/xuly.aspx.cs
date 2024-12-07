using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai_9
{
    public partial class xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Response.ContentType = "text/xml";
            var ten = "<TenVXL>" + Request.Form["tenhj"] + "</TenVXL>";
            var hang = "<Hang>" + Request.Form["hang"] + "</Hang>";
            var ngay = "<NgayRaMat>" + Request.Form["chuoingaythangnam"] + "</NgayRaMat>";
            var gia = "<Gia>" + Request.Form["gia"] + "</Gia>";
         //   Response.Write("<?xml version=\"1.0\"?> " + "<contact-info>" + ten + hang + ngay + gia + "</contact-info>");
         //   Response.End();
            Response.ClearHeaders();
            Response.AddHeader("content-type", "text/xml");
            Response.Write("<?xml version=\"1.0\"?> " + "<contact-info>" + ten + hang + ngay + gia + "</contact-info>");
            Response.End();
        }
    }
}