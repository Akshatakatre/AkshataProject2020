using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStoreManagement
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile_Number { get; set; }
        public string Email_id { get; set; }
        public string Password { get; set; }
        public string Conform_Password { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public DateTime Registration_Date { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string cn = "data source=DANNY;integrated security=true;database=PracticeDatabase";
            SqlConnection con = new SqlConnection(cn);
            try
            {
                con.Open();
                string qr = "insert into UserRegistrationForBookStore(Name,Address,Mobile_Number,Email_id,Password,Conform_Password,Gender,Age,Date_of_Birth,Registration_Date) values('" + Name + "','" + Address + "','" + Mobile_Number + "','" + Email_id + "','" + Password + "','" + Conform_Password + "','" + Gender + "','" + Age + "','" + Date_of_Birth + "','" + Registration_Date + "')";

                SqlCommand command = new SqlCommand(qr, con);
                command.ExecuteNonQuery();

            }
            catch(Exception ee)
            {
                
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}