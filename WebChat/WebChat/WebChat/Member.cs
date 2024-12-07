using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat
{
    public class Member
    {
        private string NickName;
        private string Color;
        public Member()
        {
            this.NickName = null;
            this.Color = null;
        }
        public Member(string NickName, string Color)
        {
            this.NickName = NickName;
            this.Color = Color;
        }
        public void setNickName(string NickName)
        {
            this.NickName = NickName;
        }
        public void setColor(string Color)
        { 
            this.Color = Color;
        }
        public string getNickName()
        {
            return this.NickName;
        }
        public string getColor()
        {
            return this.Color;
        }
    }
}