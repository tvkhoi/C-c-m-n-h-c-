using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webchat_th
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Member> members = (List<Member>)Application["Members"];
                rptMembers.DataSource = members;
                rptMembers.DataBind();
            }
        }
    }
}