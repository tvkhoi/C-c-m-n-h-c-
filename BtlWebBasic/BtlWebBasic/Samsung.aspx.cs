﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebBasic
{
    public partial class Samsung : System.Web.UI.Page
    {
        protected void Page_Load(object sender,EventArgs e)
        {
            if (Session["username"]!=null)
            {
                login.InnerHtml="<p class='user'>Xin chào "+Session["username"].ToString()+" | "+"</p>"+
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

            }
            List<Product> ProductList = (List<Product>)Application["productList"];
            List<Product> dt = new List<Product>();
            foreach (Product product in ProductList)
            {
                string id = product.Id;
                if (id=="30"||id=="31"||id=="32"||id=="33"||id=="34"||id=="35"||id=="36"||id=="37")
                {
                    dt.Add(product);
                }
            }
            dienthoai.DataSource=dt;
            dienthoai.DataBind();
        }
    }
}