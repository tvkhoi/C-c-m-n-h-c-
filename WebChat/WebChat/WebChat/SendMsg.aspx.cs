using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebChat
{
    public partial class SendMsg : System.Web.UI.Page
    {
        protected bool Check_Member(Member mem)
        {
            foreach (Member i in (List<Member>)Application["members"])
            {
                if (i == mem)
                    return true;
            }
            return false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Open register if user doesnt have account
            if (!Check_Member((Member)Session["member"]))
            {
                if (!IsPostBack)
                {
                    if ((int)Session["registering"] == 0)
                    {
                        Session["registering"] = 1;
                        ScriptManager.RegisterStartupScript(this, GetType(), "forceParentLoad",
                            "window.top.location.href = 'SendMsg.aspx';", true);
                    }
                    form_auth.Style.Add("display", "block");
                    return;
                }
                int a_err = 0;
                string a_nick = HttpUtility.HtmlEncode(Request.Form["auth_nickname"]);
                string a_color = HttpUtility.HtmlEncode(Request.Form["auth_color"]);
                divError.InnerHtml = "ERROR:";
                if (a_nick == null || a_nick.Trim().Length <= 0)
                {
                    divError.InnerHtml += "<br />- Nickname không được để trống!";
                    a_err++;
                }
                if (a_color == null || a_color.Trim().Length <= 0)
                {
                    divError.InnerHtml += "<br />- Color không được để trống!";
                    a_err++;
                }
                if (a_err == 0)
                {
                    Member member = new Member(a_nick, a_color);
                    Session["member"] = member;
                    ((List<Member>)Application["members"]).Add(member);
                    Application["registered"] = (int)Application["registered"] + 1;
                    
                    Session["registering"] = 0;

                    form_auth.Style.Add("display", "none");

                    Response.Redirect("FrameSet.html");
                }
                return;
            }
            // Send message if user have account
            string msg = HttpUtility.HtmlEncode(Request.Form["txtMessage"]);
            if (msg == null || msg.Trim().Length <= 0)
            {
                Response.Redirect("PostMsg.html");
                return;
            }
            string nick = "<span style=\"color:" + ((Member)Session["member"]).getColor() + "\">" + ((Member)Session["member"]).getNickName() + "</span>";
            string time = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
            Message message = new Message(nick, msg, time);
            Session["message"] = message;
            ((List<Message>)Application["messages"]).Add(message);
            Response.Redirect("PostMsg.html");
        }
    }
}