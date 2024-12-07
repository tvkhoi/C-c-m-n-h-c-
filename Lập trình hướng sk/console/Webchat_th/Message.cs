using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webchat_th
{
    public class Message
    {
        public string NickName { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}