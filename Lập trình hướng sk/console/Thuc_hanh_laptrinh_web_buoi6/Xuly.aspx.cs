using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Thuc_hanh_laptrinh_web_buoi6
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
             string hoten = Request["hoten"].ToString();
             string namsinh = Request["namsinh"].ToString();
            List<Nhanvien> listNhanvien = (List<Nhanvien>)Session["danhsach"];
            Nhanvien nv = new Nhanvien();
            int check = 0;
            foreach (Nhanvien i in listNhanvien)
            {
                if (i.hoten_NV == hoten && i.nam_sinh_NV == namsinh)
                {
                    check = 1;
                    break;
                }
            }
            if (check == 0)
            {
                nv.hoten_NV = hoten;
                nv.nam_sinh_NV = namsinh;
                listNhanvien.Add(nv);
                Session["danhsach"] = listNhanvien;
            }
            string output = "";
            foreach (Nhanvien i in listNhanvien)
            {
                output += @"<tr>
                                    <td class='text-left'>" + i.hoten_NV + @"</td>
                                    <td class='text-left'>" + i.nam_sinh_NV + @"</td>
                                </tr>";
            }
            viewDanhSach.InnerHtml = output;
          

        }
    }
}