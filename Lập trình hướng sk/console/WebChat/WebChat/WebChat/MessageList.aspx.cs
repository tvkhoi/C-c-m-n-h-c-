using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebChat
{
    public partial class MessageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Message> list = (List<Message>)Application["messages"];
            if (list.Count <= 0)
                messages.InnerHtml = "<div style=\"text-align: center; margin: 5px auto;\">Chưa có tin nhắn nào được gửi!</div><br />";
            else
            {
                foreach(Message m in list)
                {
                    messages.InnerHtml += "<div style=\"margin: 5px 15px;\">"
                        + "<span style=\"font-weight: 600;\">[" + m.getTimeStamp() + "] " + "</span>"
                        + m.getNickname()
                        + ": " + m.getMessage();
                    messages.InnerHtml += "</div>";
                }
                /*
                if (Session["localMessage"] != null)
                {
                    messages.InnerHtml += "<div style=\"margin: 5px 15px;\">"
                        + "<span style=\"font-weight: 600;\">[COMMAND HANDLER] " + "</span>" + Session["localMessage"];
                    messages.InnerHtml += "</div>";
                }
                */
            }
        }
    }
}