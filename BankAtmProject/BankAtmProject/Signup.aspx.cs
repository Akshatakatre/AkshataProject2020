using AtmManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankAtmProject
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string n = TextBox1.Text;
            string a = TextBox2.Text;
            string mn = TextBox3.Text;
            string ei = TextBox4.Text;
            string p = TextBox5.Text;
            string cp = TextBox6.Text;
            string age = TextBox7.Text;
          
            string dob = TextBox8.Text;

            RegisterClass rc = new RegisterClass();
            //string res = rc.saveRegistration(n, a, mn, ei, p, cp, age, dob);

            string res1 = rc.checkemailid(ei);
            if (res1 == "false")
            {
                string res = rc.saveregistration(n,a,mn, ei,p,cp,a,dob);
                Label1.Text = res;
                Response.Redirect("signup1.aspx?email=" + ei);
            }
            else
            {
                Label1.Text = "User with this email id already exists, please use some other emailid";
                TextBox3.Text = "";
                TextBox3.Focus();
            }

        }
    }
}