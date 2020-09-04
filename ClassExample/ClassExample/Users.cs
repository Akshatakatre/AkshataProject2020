using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassExample
{
    public class Users
    {
        public int userid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Emailid { get; set; }
        public string Mobilenumber { get; set; }
        public string imagename { get; set; }
        public string Role { get; set; }

        public Users(int ui,string un,string p,string ei,string mn,string imgn,string r)
        {
            userid = ui;
            UserName = un;
            Password = p;
            Emailid = ei;
            Mobilenumber = mn;
            imagename = imgn;
            Role = r;
        }
    }
}