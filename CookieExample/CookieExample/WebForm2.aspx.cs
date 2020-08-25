using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieExample
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //code to retrieve cookie from client machine

            HttpCookie cookie12 = Request.Cookies["cook1"];
            if (cookie12 != null)
            {
                string uname = cookie12.Values["Name"].ToString();
                string uemail = cookie12.Values["Email"].ToString();
                string mobileno = cookie12.Values["Mobile number"].ToString();
                Label1.Text = uname;
                Label2.Text = uemail;
                Label3.Text = mobileno;
            }
            else
            {
                Label1.Text = "no permanent cookie exist";
            }

        }
    }
}