using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_SEssion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("fjfjfjf");
            list.Add("khởi trần");
            list.Add("hướng trần");
            Session["danhsach"] = list;
            string chuoi = "";
            foreach (string item in (List<string>)Session["danhsach"])
            {
                chuoi+= item;
            }
            Response.Write(chuoi);
        }
    }
}