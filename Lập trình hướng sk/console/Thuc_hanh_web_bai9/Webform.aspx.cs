using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Thuc_hanh_web_bai9
{
    public partial class Webform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ten = Request.Form["ten"];
            string hang = Request.Form["hang"];
            string ngay = Request.Form["ngay"];
            string gia = Request.Form["gia"];

            // Xử lý dữ liệu ở đây, ví dụ: lưu vào CSDL, xử lý logic, ...
            //Response.AddHeader("fjfjfjf", "text/xml");
           // Response.ClearHeaders();
            Response.AddHeader("content-type", "text/xml");
            Response.Write("<?xml version=\"1.0\"?> " + "<contact-info>" + ten + hang + ngay + gia + "</contact-info>");
            
            Response.End();
           
            // Code xử lý khi trang được load
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            // Code khởi tạo trang
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
