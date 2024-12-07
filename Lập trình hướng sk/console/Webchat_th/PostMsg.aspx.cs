using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webchat_th
{
    public partial class PostMsg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            List<Message> messages = (List<Message>)Application["Messages"];
            string nickName = Session["NickName"].ToString();
            string message = txtMessage.Text;
            DateTime timeStamp = DateTime.Now;

            messages.Add(new Message { NickName = nickName, Content = message, TimeStamp = timeStamp });
            Application["Messages"] = messages;

            Response.Redirect("PostMsg.aspx");
        }
    }
}