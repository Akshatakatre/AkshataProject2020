using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PassDLL;

namespace DigitalPass1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.Form.Get("t1");
            string password = Request.Form.Get("t2");
            if (email == "admin" && password == "admin")
            {
                //Response.Write("successfull");

                Response.Redirect("AdminDashboard.aspx");
            }
            else 
            {
                PassDLL.Login log = new PassDLL.Login();
                string chk = log.Checklogin(email, password);
                if (chk == "true")
                {
                    Response.Redirect("PassengerHomeP.aspx");
                    //Response.Write ("login successfull");
                }
                else
                {
                    //Response.Redirect("login.aspx");
                    // Response.Write("invalid credentials , try again");
                    // string msg = "invalid credentials , try again...";
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Test", "login.aspx;", true);
                    //Request.Form.Clear();

                }
            }
        }
    }
}