using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls.WebParts;

namespace StudentRegistrationForm
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        public class student
        {
            public int RegistrationId { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string MobileNumber { get; set; }
            public string Emailid { get; set; }
            public string Password { get; set; }
            public string ConformPassword { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string DateofBirth { get; set; }
            public string Course { get; set; }
            public string RegistrationDate { get; set; }
            public string Photo { get; set; }
            //string result = "";

            public void saveRegistrationData(string n, string a, string mn, string ei, string pwd, string cpwd, int age, string g, string dob, string c, string rd, string p)
            {
                Name = n;
                Address = a;
                MobileNumber = mn;
                Emailid = ei;
                Password = pwd;
                ConformPassword = cpwd;
                Age = age;
                Gender = g;
                DateofBirth = dob;
                Course = c;
                RegistrationDate = rd;
                Photo = p;


                string cn = "data source=DANNY;integrated security=true;database=BUSPASSSYSTEMDatabase";
                /* SqlConnection con = new SqlConnection(cn);
                 try
                 {
                     con.Open();

                     string qr = "insert into StudentREGISTRATION(Name,Address,Monile_Number,Email_id,Password,Conform_Password,Age,Gender,Date_of_Birth,Courses,Registration_Date,Photo) values('" + Name + "','" + Address + "','" + MobileNumber + "','" + Emailid + "','" + Password + "','" + ConformPassword + "','" + Age + "','" + Gender + "','" + DateofBirth + "','" + RegistrationDate + "','" + Photo + "')";
                     //create an object of sqlcommand class for writing insert query.
                     SqlCommand command = new SqlCommand(qr, con);
                     //use the execution query method of sqlcommand class to execute above query.
                     //.CommandType = CommandType.Text;
                     command.ExecuteNonQuery();
                     result = "Registration Successful";
                 }
                 catch(Exception ee)
                 {
                     result = ee.ToString();
                 }
                 finally
                 {
                     con.Close();
                 }*/
                //return result;

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            string cn = "data source=DANNY;integrated security=true;database=BUSPASSSYSTEMDatabase";
            SqlConnection con = new SqlConnection(cn);
            try
            {
                con.Open();

                string qr = "insert into StudentREGISTRATION(Name,Address,Monile_Number,Email_id,Password,Conform_Password,Age,Gender,Date_of_Birth,Courses,Registration_Date,Photo) values('" + Name + "','" + Address + "','" + MobileNumber + "','" + Emailid + "','" + Password + "','" + ConformPassword + "','" + Age + "','" + Gender + "','" + DateofBirth + "','" + RegistrationDate + "','" + Photo + "')";
                //create an object of sqlcommand class for writing insert query.
                SqlCommand command = new SqlCommand(qr, con);
                //use the execution query method of sqlcommand class to execute above query.
                //.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                result = "Registration Successful";
            }
            catch (Exception ee)
            {
                result = ee.ToString();
            }
            finally
            {
                con.Close();
            }
           
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

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}