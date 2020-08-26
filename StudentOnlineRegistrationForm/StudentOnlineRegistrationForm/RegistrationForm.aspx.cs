using StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace StudentOnlineRegistrationForm
{
    public partial class RegistrationForm : System.Web.UI.Page
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
            string pwd = TextBox5.Text;
            string cpwd = TextBox6.Text;
            int age =Convert.ToInt32( TextBox7.Text);
            string g ;
            if(RadioButton1.Checked)
            {
                 g = RadioButton1.Text;
            }
            else if(RadioButton2.Checked)
            {
              g = RadioButton2.Text;
            }
            else
            {
                 g = RadioButton3.Text;
            }
            DateTime dob = Convert.ToDateTime(TextBox8.Text);
            string c = DropDownList1.Text;
            DateTime rd = Convert.ToDateTime(TextBox9.Text);
            string p = FileUpload1.ID;
            Registration reg = new Registration();
            string res = reg.saveRegistration(n, a, mn, ei, pwd, cpwd, age, g, dob, c, rd, p);
            Label1.Text = res;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}