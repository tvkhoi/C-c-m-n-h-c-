using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat
{
    public class Message
    {
        private string nickname;
        private string message;
        private string timeStamp;
        public Message()
        {
            nickname = null;
            message = null;
            timeStamp = null;
        }
        public Message(string nickname, string message, string timeStamp)
        {
            this.nickname = nickname;
            this.message = message;
            this.timeStamp = timeStamp;
        }
        public string getNickname()
        { return this.nickname; }
        public string getMessage()
        { return this.message; }
        public string getTimeStamp()
        { return this.timeStamp; }
        public void setNickname(string nickname)
        { this.nickname = nickname; }
        public void setMessage(string message)
        { this.message = message; }
        public void setTimeStamp(string timeStamp)
        { this.timeStamp = timeStamp; }
    }
}