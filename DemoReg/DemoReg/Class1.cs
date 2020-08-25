using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DemoReg
{
    public class Class1
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string email { get; set; }
        public string Gender { get; set; }
        public string AdharNumber { get; set; }
        public string Password { get; set; }
         public void newRegistration(string n,string a,string m,string e,string g,string an,string p)
        {
            Name = n;
            Address = a;
            Mobile = m;
            email = e;
            Gender = g;
            AdharNumber = an;
            Password = p;
            string result = "";

            SqlConnection sc = new SqlConnection();
            
            try
            {
                sc.Open();
                string nr = "insert into registration(Name,Address,Mobile,email,Gender,AdharNumber,Password)values('" + Name + "','" + Address + "','" + Mobile + "','" + email + "','" + Gender + "','" + AdharNumber + "','" + Password + "')";
                SqlCommand command = new SqlCommand(nr, sc);
                command.ExecuteNonQuery();
                result = "registration successfully";
            }
            catch(Exception ee)
            {
                result = ee.ToString();
            }
            finally
            {
                sc.Close();
            }
        }


    }
}
