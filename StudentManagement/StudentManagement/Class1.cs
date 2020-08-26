using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobilenumber { get; set; }
        public string Emailid { get; set; }
        public string Password { get; set; }
        public string Conformpassword { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Course { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Photo { get; set; }

        //method to save the registration details
        public string saveRegistration(string n, string a, string mn, string ei, string pwd, string cpwd, int age, string g, DateTime dob, string c, DateTime rd, string p)
        {
            Name = n;
            Address = a;
            Mobilenumber = mn;
            Emailid = ei;
            Password = pwd;
            Conformpassword = cpwd;
            Age = age;
            Gender = g;
            DateofBirth = dob;
            Course = c;
            RegistrationDate = rd;
            Photo = p;
            string result = "";

            string cn = "data source=DANNY;integrated security=true;database=BUSPASSSYSTEMDatabase";
            SqlConnection con = new SqlConnection(cn);
            try
            {
                con.Open();
                string qr = "insert into StudentREGISTRATION(Name,Address,Mobile_Number,Email_id,Password,Conform_Password,Age,Gender,Date_of_Birth,Courses,Registration_Date,Photo)values('" + Name + "','" + Address + "','" + Mobilenumber + "','" + Emailid + "','" + Password + "','" + Conformpassword + "','" + Age + "','" + Gender + "','" + DateofBirth + "','" + Course + "','" + RegistrationDate + "','" + Photo + "')";
                //create an object of sqlcommand class for writing insert query
                SqlCommand command = new SqlCommand(qr, con);
                //use the executenonquery method of sqlcommand class to execute the above query
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
            }
            return result;
        }
    }
}
