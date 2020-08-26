using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SignUpDll;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DigitalPass1
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        string previousPageName = "";
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.UrlReferrer != null)
                {
                    previousPageName = Request.UrlReferrer.Segments[Request.UrlReferrer.Segments.Length - 1];
                    Response.Write(previousPageName);
                }
                Session["prePage"] = previousPageName;
            }
            TextBox10.Text = DateTime.Today.ToShortDateString();

            
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
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
            int adharcardnumber =Convert.ToInt32(TextBox8.Text);
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

                Registration reg = new Registration();
                string ch = reg.CheckEmailid(emailid);

                if (ch == "false")
                {

                    
                    string res = reg.NewRegistration(name, address, mobilenumber, emailid, password, gender, dob, adharcardnumber, question, answer, registrationdate, photo);
                    Response.Write(res);
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


            else if (pp == "RoleAdminSignup.aspx")
            {

                string role = Request.QueryString["role"].ToString();
                Admin ad = new Admin();
                Registration reg1 = new Registration();
                string chk = reg1.CheckEmailid(emailid);
               
                if (chk == "false")
                {
                     
                    string res1 = ad.AdminNewRegistration(name, address, mobilenumber, emailid, password, gender, dob, adharcardnumber, question, answer, role, registrationdate, photo);
                    Response.Write(res1);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Test", res1, true);
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
                        //DropDownList1.SelectedValue = "";
                        RadioButton1.Checked = false;
                        RadioButton2.Checked = false;
                        RadioButton3.Checked = false;
                    }

                }
                else if (chk == "true")
                {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Test", "alert('Email id already exist.');", true);
                    TextBox5.Text = "";
                    TextBox5.Focus();
                }
            }
            

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            

        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
           
        }
    }
}