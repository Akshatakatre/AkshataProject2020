using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            long i = 1;
            int n = Convert.ToInt32(TextBox1.Text);
            int r = n * n;
            for (i = 1; i < 10000000000; i++)
            {

            }
            Label1.Text = "square of number is " + r.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}