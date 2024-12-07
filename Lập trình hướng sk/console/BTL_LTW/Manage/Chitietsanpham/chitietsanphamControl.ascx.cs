using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BTL_LTW.Manage.Chitietsanpham
{
    public partial class chitietsanphamControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Application["danhsach_sanpham"] != null)
                {
                    DataTable dataTable = (DataTable)Application["danhsach_sanpham"];
                    // Lặp qua từng dòng trong DataTable để in ra giá trị của các cột
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["masp"].ToString() == Request["sp"].ToString())
                        {
                            hinhanh.Src = string.Format(row["hinhanh"].ToString());
                            ten.InnerText = row["ten"].ToString();
                            mota.InnerText = row["mota"].ToString();
                            gia.InnerText = row["gia"].ToString();
                            giagoc.InnerText = row["giagoc"].ToString();
                            giamgia.InnerText = row["giamgia"].ToString();
                            string congketnoi = row["congketnoi"].ToString()+"";
                            string vixuly = row["vixuly"].ToString()+"";
                            string card = row["card"].ToString() + "";
                            thongtinsanpham.InnerHtml = @"
 <h3><a style=""color:cornflowerblue; font-size:20px;"" previewlistener=""true"">Laptop " + ten.InnerText + @"" + mota.InnerText + @"</a>
 <a style=""color:cornflowerblue; font-size:20px;""  previewlistener=""true"">.Một chiếc Laptop học tập - văn phòng</a> đáng để bạn cân nhắc lựa chọn mua.</h3>
 <p>• Bộ vi xử lý&nbsp;<strong>" + vixuly + @"</strong> và card đồ họa <strong>" + card + @"</strong>cho phép người dùng vận hành hoàn hảo mọi tác vụ học tập, văn phòng trên Word, Excel, PowerPoint,... hay thậm chí thực hiện chỉnh sửa hình ảnh 2D đơn giản bằng Photoshop.</p>
 <p>• Cổng kết nối đáp ứng mọi nhu cầu: " + congketnoi + @".</p>";
                        }
                    }
                    
                }
               
            }
            catch { }
        }

       

      
    }
}