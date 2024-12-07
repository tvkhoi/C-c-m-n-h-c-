using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Json_Web_Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string filePath = Server.MapPath("json.json");
                string json = File.ReadAllText(filePath);

                dynamic data = JsonConvert.DeserializeObject(json);

                if (data != null && data.students != null)
                {
                    for (int i = 0; i < data.students.Count; i++)
                    {
                        
                        HtmlInputText nameInput = (HtmlInputText)FindControl("name" + i);
                        HtmlImage imageInput = (HtmlImage)FindControl("image" + i);
                        if (nameInput != null && imageInput != null)
                        {
                          
                                nameInput.Value = data.students[i].name;
                                imageInput.Src = "item4.jpg";
                                

                        }
                        else
                        {
                            Console.WriteLine("fjfjfjff");
                        }
                    }
                }
            }
        }
    }
}