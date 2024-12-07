using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace BTL_LTW.Manage
{
    public class JsonHelper
    {
        public static void SaveToJson(object obj, string filePath)
        {
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(filePath, json);
        }
        public static List<T> LoadListFromJson <T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
       
    }
}