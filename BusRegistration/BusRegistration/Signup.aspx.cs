using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusRegistrationDLL;

namespace BusRegistration
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string gender;
            string password = "";
            string name = TextBox1.Text;
            string address = TextBox2.Text;
            string mobilenumber = TextBox3.Text;
            string emailid = TextBox5.Text;
            if (TextBox11.Text == TextBox7.Text)
            {
                password = TextBox11.Text;
            }
            if (RadioButton1.Checked)
            {
                gender = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                gender = RadioButton2.Text;
            }
            else
            {
                gender = RadioButton3.Text;
            }
            DateTime dob = Convert.ToDateTime(TextBox10.Text);
            int adharcardnumber = Convert.ToInt32(TextBox8.Text);
            string question = DropDownList1.Text;
            string answer = TextBox9.Text;
            string registrationdate = TextBox10.Text;
            string photo = FileUpload1.FileName;

            if (FileUpload1.HasFile)
            {
                string fn1 = Server.MapPath(photo);
                FileUpload1.SaveAs(fn1);
            }

            string pp = Session["prePage"].ToString();
            Response.Write("PP =" + pp);
            if (pp == "home.aspx")
            {

                Class1 reg = new Class1();
                string ch = reg.CheckEmailid(emailid);

                if (ch == "false")
                {

                    string res = reg.NewRegistration(name, address, mobilenumber, emailid, password, gender, dob, adharcardnumber, question, answer, registrationdate, photo);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Test", res, true);
                    if (true)
                    {
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox5.Text = "";
                        TextBox11.Text = "";
                        TextBox7.Text = "";
                        TextBox10.Text = "";
                        TextBox8.Text = "";
                        TextBox9.Text = "";
                        // DropDownList1.SelectedValue = "";
                        RadioButton1.Checked = false;
                        RadioButton2.Checked = false;
                        RadioButton3.Checked = false;
                    }

                }

                else if (ch == "true")
                {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Test", "alert('Email id already exist.');", true);
                    TextBox5.Text = "";
                    TextBox5.Focus();
                }
            }


        }
    }
}
                