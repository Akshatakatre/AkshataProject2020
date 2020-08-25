using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            HttpCookie cookie12 = new HttpCookie("cook1");
            cookie12.Values.Add("Name", TextBox1.Text);
            cookie12.Values.Add("Email", TextBox2.Text);
            cookie12.Values.Add("Mobile Number", TextBox3.Text);
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 2, 0);
            cookie12.Expires = dt.Add(ts);
            Label1.Text = "permanent cookie added to client machine";



            Response.Cookies.Add(cookie12);
            //Label1.Text = "temporary cookie added to client machine";

            Response.Redirect("WebForm2.aspx");
        }
    }
}