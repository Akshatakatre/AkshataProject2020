using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ServerSideStateManagement
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //code that run in application startup
            // declaring one application variable and initialize it
            Application["companyname"] = "MKPlacement";
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["username"] = "Rahul";
            //code that runs when the new session will start
            Response.Write("<br> session is now begining");
            Response.Write("<br> session variable value :" + Session["username"].ToString());
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Response.Write("Request is now beging");
            Response.Write("<br> Company Name:" + Application["companyname"].ToString());
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            //code that run in application shut down
        }
    }
}