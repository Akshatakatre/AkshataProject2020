using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PassDLL
{
    class Passenger
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Emailid { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string AdharcardNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Photo { get; set; }
        string cn;
        SqlConnection con;
        public Passenger()
        {
            cn = "data source= DANNY;integrated security=true;database=BUSPASSSYSTEMDatabase";
            con = new SqlConnection(cn);
        }
        public DataTable GetPassengerImageData(string email, string password)
        {
            con.Open();
            string qr = "select  Name,Photo from RegistrationTable where Email_id='" + email + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            con.Close();
            return ds;


        }
        public DataTable GetPassengerProfileData(string email, string password)
        {
            con.Open();
            string qr = "select Name,Address,Mobile_Number,Email_id,Gender,Date_of_Birth,Adharcard_Number,Registration_Date,Photo from RegistrationTable where Email_id='" + email + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            con.Close();
            return ds;

            
        }
    }
}
