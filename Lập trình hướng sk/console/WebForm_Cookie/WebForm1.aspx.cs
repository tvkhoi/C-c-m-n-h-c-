using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_Cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("col1");
            dt.Columns.Add("col2");
            dt.Columns.Add("col3");
            dt.Columns.Add("col4");
            dt.Columns.Add("col5");
            dt.Columns.Add("col6");
            string so_luong_cot = dt.Columns.Count.ToString();
            HttpCookie cookie = new HttpCookie("nguoidung");
            cookie.Value = so_luong_cot;
            cookie.Expires = DateTime.Now.AddDays(1);
            string soluongcot = cookie.Value;
            Response.Write(soluongcot);
        }
    }
}