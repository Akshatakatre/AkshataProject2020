using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieExample
{
    public partial class Temporarycookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            HttpCookie cookie1 = new HttpCookie("cook");
            cookie1.Values.Add("Name", TextBox1.Text);
            Response.Cookies.Add(cookie1);
            Label1.Text = "temporary cookie added to client machine";



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine

            HttpCookie cookie1 = Request.Cookies["cook"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["Name"].ToString();
                Label1.Text = "Name : " + uname;
            }
            else
            {
                Label1.Text = "no cookie exist";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            HttpCookie cookie12 = new HttpCookie("cook1");
            cookie12.Values.Add("Name", TextBox1.Text);
            cookie12.Values.Add("email", TextBox2.Text);
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 2, 0);
            cookie12.Expires = dt.Add(ts);
            Label1.Text = "permanent cookie added to client machine";



            Response.Cookies.Add(cookie12);
            //Label1.Text = "temporary cookie added to client machine";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine

            HttpCookie cookie12 = Request.Cookies["cook1"];
            if (cookie12 != null)
            {
                string uname = cookie12.Values["Name"].ToString();
                string uemail = cookie12.Values["email"].ToString();
                Label1.Text = "Name : " + uname;
                Label2.Text = "email : " + uemail;
            }
            else
            {
                Label1.Text = "no permanent cookie exist";
            }

        }
    }
}