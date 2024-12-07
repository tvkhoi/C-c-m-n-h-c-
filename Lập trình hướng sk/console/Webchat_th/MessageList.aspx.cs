using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webchat_th
{
    public partial class MessageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Message> messages = (List<Message>)Application["Messages"];
            List<Message> sortedMessages = messages.OrderBy(m => m.TimeStamp).ToList();

            rptMessages.DataSource = sortedMessages;
            rptMessages.DataBind();
        }
    }
}