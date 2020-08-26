using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PassDLL
{
    public class Login
    {
        public string emailid { get; set; }
        public string password { get; set; }
        string cn;
        SqlConnection con;
        public Login()
        {
            cn = "data source= DANNY;integrated security=true;database=BUSPASSSYSTEMDatabase";
            con = new SqlConnection(cn);
        }
        public string Checklogin(string email, string pwd)
        {
            string result = "";
            try
            {
                con.Open();
                string qr = "select count(*) from RegistrationTable where Email_Id='" + email + "' and Password='" + pwd + "'";
                SqlCommand command = new SqlCommand(qr, con);
                //the query will return a single calculated value
                // so for this use executescalar method of sqlcommand class
                int r = Convert.ToInt32(command.ExecuteScalar());
                if (r == 1)
                {
                    result = "true";
                }
                else
                {
                    result = "false";
                }

            }
            catch (Exception ee)
            {
                result = ee.ToString();
            }
            finally
            {
                con.Close();
            }
            return result;
        }

            public DataTable GetPassengerData(string email,string password)
            {
                con.Open();
                string qr="select (Name,Address,Mobile_Number,Email_id,Gender,Date_of_Birth,Adharcard_Number,Registration_Date,Photo)from RegistrationTable where Email_id='"+email+"' and Password='"+password+"'";
            SqlCommand cmd = new SqlCommand(qr,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            con.Close();
            return ds;


            }
        
    }
}
