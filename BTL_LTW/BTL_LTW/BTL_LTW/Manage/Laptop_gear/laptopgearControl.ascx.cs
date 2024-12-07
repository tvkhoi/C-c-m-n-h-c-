using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BTL_LTW.Manage.Laptop_gear
{
    public partial class laptopgearControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string filePath = @"D:\BTL\BTL_LTW\BTL_LTW\dat_GamingGear.json";

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);

                    dynamic data = JsonConvert.DeserializeObject(json);

                    if (data != null && data.sanphamf != null)
                    {
                        for (int i = 0; i < data.sanphamf.Count; i++)
                        {
                            var hinhanh = (HtmlImage)FindControl("hinhanh" + (i + 1));
                            var ten = (HtmlGenericControl)FindControl("ten" + (i + 1));
                            var mota = (HtmlGenericControl)FindControl("mota" + (i + 1));
                            var gia = (HtmlGenericControl)FindControl("gia" + (i + 1));
                            var giagoc = (HtmlGenericControl)FindControl("giagoc" + (i + 1));
                            var giamgia = (HtmlGenericControl)FindControl("giamgia" + (i + 1));

                            if (hinhanh != null && ten != null && mota != null && gia != null && giagoc != null && giamgia != null)
                            {
                                hinhanh.Src = data.sanphamf[i].hinhanh;
                                ten.InnerHtml = data.sanphamf[i].ten;
                                mota.InnerHtml = data.sanphamf[i].mota;
                                gia.InnerHtml = data.sanphamf[i].gia;
                                giagoc.InnerHtml = data.sanphamf[i].giagoc;
                                giamgia.InnerHtml = data.sanphamf[i].giamgia;
                                string congketnoi = data.sanphamf[i].congketnoi;
                                string vixuly = data.sanphamf[i].vixuly;
                                string card = data.sanphamf[i].card;
                                string sp = "sp" + (i + 1);
                                // Kiểm tra Session["danhsach_sanpham"] đã tồn tại chưa
                                if (Session["danhsach_sanpham"] == null)
                                {
                                    // Nếu chưa tồn tại, tạo mới DataTable và thêm cột
                                    DataTable dataTable = new DataTable();
                                    dataTable.Columns.Add("masp", typeof(string));
                                    dataTable.Columns.Add("hinhanh", typeof(string));
                                    dataTable.Columns.Add("ten", typeof(string));
                                    dataTable.Columns.Add("mota", typeof(string));
                                    dataTable.Columns.Add("gia", typeof(string));
                                    dataTable.Columns.Add("giagoc", typeof(string));
                                    dataTable.Columns.Add("giamgia", typeof(string));
                                    dataTable.Columns.Add("congketnoi", typeof(string));
                                    dataTable.Columns.Add("vixuly", typeof(string));
                                    dataTable.Columns.Add("card", typeof(string));
                                    // Thêm dòng dữ liệu vào DataTable
                                    dataTable.Rows.Add(sp, hinhanh.Src, ten.InnerText, mota.InnerText, gia.InnerText, giagoc.InnerText, giamgia.InnerText, congketnoi, vixuly, card);

                                    // Lưu DataTable vào Session
                                    Session["danhsach_sanpham"] = dataTable;
                                }
                                else
                                {
                                    // Nếu đã tồn tại, lấy DataTable từ Session
                                    DataTable dataTable = (DataTable)Session["danhsach_sanpham"];
                                    // Thêm dòng dữ liệu vào DataTable
                                    dataTable.Rows.Add(sp, hinhanh.Src, ten.InnerText, mota.InnerText, gia.InnerText, giagoc.InnerText, giamgia.InnerText, congketnoi, vixuly, card);
                                    // Lưu DataTable sau khi thêm dữ liệu vào Session
                                    Session["danhsach_sanpham"] = dataTable;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lỗi");
                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("File JSON không tồn tại.");
                }
            }

        }
    }
}