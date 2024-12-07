using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebChat
{
    public partial class Member1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Member> list = (List<Member>)Application["members"];
            if (list.Count <= 0)
                members.InnerHtml = "<div style=\"text-align: center; margin: 5px auto;\">Không có người dùng nào!</div><br />";
            else
            {
                members.InnerHtml = "";
                for(int i = 0; i < list.Count; i++)
                {

                    members.InnerHtml = "<div style=\"margin: 5px 20px;\"><b>"
                        + (i + 1) + ". </b>"
                        + "<span style=\"color:" + list[i].getColor() + "\">"
                        + list[i].getNickName() + "</span>";
                    members.InnerHtml += "</div><br />";
                }
            }
            members_title.InnerHtml = "Thành viên (" + list.Count + ")";
        }
    }
}