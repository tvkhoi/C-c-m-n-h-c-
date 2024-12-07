
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

namespace Json_Web_Form
{
    public class JsonHelper
    {
        public JsonHelper() { }
        public static void SaveToJson(object obj, string filePath)
        {
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(filePath, json);
        }
        //  public static List<T> LoadListFromJson<T>(string filePath)
        // {
        //     string json = File.ReadAllText(filePath);
        //     return JsonConvert.DeserializeObject<List<T>>(json);
        // }
        public static T LoadFromJson<T>(string filePath)
        {
            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public static void PopulateFormFromJson<T>(T data, HtmlForm form)
        {
            foreach (var prop in typeof(T).GetProperties())
            {
                var input = form.FindControl(prop.Name) as HtmlInputControl;
                if (input != null)
                {
                    object value = prop.GetValue(data);
                    if (value != null)
                    {
                        input.Value = value.ToString();
                    }
                }
            }
        }
    }
}