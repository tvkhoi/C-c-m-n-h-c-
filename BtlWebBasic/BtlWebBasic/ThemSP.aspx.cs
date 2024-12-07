using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebBasic
{
    public partial class ThemSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = "product.xml";
            List<Product> list = new List<Product>();

            if (File.Exists(Server.MapPath(path)))
            {
                // Đọc file
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Product>));
                StreamReader file = new StreamReader(Server.MapPath(path));

                list = (List<Product>)reader.Deserialize(file);
                list = list.OrderByDescending(Product => Product.Id).ToList();
                file.Close();
            }
            string html = "";

            foreach (Product product in list)
            {
                html += "<div >" +
                            "<div>";
                html += "<label class=\"checkbox-inline\"><img src=\"" + product.Images + "\" width=\"50%\" height=\"\" alt=\"\"></label>";
                html += "</div>";
                html += "<div >";
                html += "<h4>Tên sp: " + product.Name + "</h4>" +
                                "<br/>" +
                                "<h4>ID: " + product.Id + "</h4>";
                html += "</div>";
                html += "<div class=\"col-xs-12 col-sm-6 col-md-2 col-lg-2\">";
                if (product.Gia > 0)
                {
                    html += "<h4 style = \"color: orange\" >Giá gốc: <del>" + product.Gia + "</del></h4>";
                }

                listProduct.InnerHtml = html;
            }

            foreach (Product product in list)
            {
                if (Request.Form["btnXoa"] == Convert.ToString(product.Id))
                {
                    list.Remove(product);
                    //Ghi file
                    System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Product>));

                    System.IO.FileStream _file = System.IO.File.Create(Server.MapPath(path));

                    writer.Serialize(_file, list);
                    _file.Close();

                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                    break;
                }
            }
        }

        public void btnUpload_Click(object o, EventArgs e)
        {
            if (Page.IsValid && inputAnh1.HasFile)
            {
                if (CheckFileType(inputAnh1.FileName))
                {
                    string fileName = "images/" + inputAnh1.FileName;
                    string filePath = MapPath(fileName);
                    inputAnh1.SaveAs(filePath);
                    Image1.ImageUrl = fileName;
                }
                else
                {
                    string alert = "";
                    alert += "<script>alert('Chỉ nhận file ảnh!!!');</script>";
                    Response.Write(alert);
                }
            }
        }

        private bool CheckFileType(string fileName)
        {
            throw new NotImplementedException();
        }

        public void btnThem_Click(object o, EventArgs e)
        {
            string path = "listProduct.xml";

            List<Product> list = new List<Product>();

            if (File.Exists(Server.MapPath(path)))
            {
                // Đọc file
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Product>));
                StreamReader file = new StreamReader(Server.MapPath(path));

                list = (List<Product>)reader.Deserialize(file);
                list = list.OrderByDescending(Product => Product.Id).ToList();
                file.Close();
            }

            Product prod = new Product();

            prod.Id = Request.Form["txtId"];
            prod.Name = Request.Form["txtTen"];
            prod.Price = (Request.Form["txtPrice"]);
            
            prod.Images = Image1.ImageUrl;

            

            
        
    }
    }
}