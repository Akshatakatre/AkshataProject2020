using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace PassDLL
{
    public class Admin
    {
                public int Registrationid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Emailid { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AadharCardNumber { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string Role { get; set; }
        public string RegistrationDate { get; set; }
        public string Photo { get; set; }

        string cn;
        SqlConnection con;

        public Admin()
        {
            cn = "data source= DANNY/SQLEXPRESS;integrated security=true;database=Bus_Pass";
            con = new SqlConnection(cn);
        }


        public string AdminNewRegistration(string name, string address, string mobilenumber, string emailid, string password, string gender, DateTime dateofbirth, string adharcardnumber, string securityquestion, string securityanswer, string role, string registrationdate, string photo)
        {
            Name = name;
            Address = address;
            MobileNumber = mobilenumber;
            Emailid = emailid;
            Password = password;
            Gender = gender;
            DateOfBirth = dateofbirth;
            AadharCardNumber = adharcardnumber;
            SecurityQuestion = securityquestion;
            SecurityAnswer = securityanswer;
            Role = role;
            RegistrationDate = registrationdate;
            Photo = photo;
            string Result = "";

            try
            {
                con.Open();

                string qr = "insert into Registered_User(Name,Address,Mobile_Number,Email_Id,Password,Gender,Date_of_Birth,AdharCard_Number,Security_Question,Security_Answer,Role,Registration_Date,Photo)values('" + name + "','" + address + "','" + mobilenumber + "','" + emailid + "','" + password + "','" + gender + "','" + dateofbirth + "','" + adharcardnumber + "','" + securityquestion + "','" + securityanswer + "','" + role + "','" + registrationdate + "','" + photo + "')";
                SqlCommand cmd = new SqlCommand(qr, con);
                cmd.ExecuteNonQuery();
                //for the page with only one form
                Result = "alert('Registration successful..!');";

            }
            catch (Exception e)
            {
                Result = e.ToString();
            }
            finally
            {
                con.Close();
            }
            return Result;
        }
        public string CheckBus(string source, string destination, string busnumber)
        {
            string result = "";

            try
            {
                con.Open();
                string qr = "select count(*) from Bus_Detail where Source ='" + source + "' AND Destination = '" + destination + "' AND Bus_Number ='" + busnumber + "'";
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
        public string AddBus(string source, string destination, string bustype, string busnumber)
        {
            string Result = "";

            try
            {
                con.Open();

                string qr = "insert into Bus_Detail (Source,Destination,Bus_Type,Bus_Number)values('" + source + "','" + destination + "','" + bustype + "','" + busnumber + "')";
                SqlCommand cmd = new SqlCommand(qr, con);
                cmd.ExecuteNonQuery();
                //for the page with only one form
                Result = "alert('Bus added successfully..!');";

            }
            catch (Exception e)
            {
                Result = e.ToString();
            }
            finally
            {
                con.Close();
            }
            return Result;
        }
        public string GetBusId(string busnumber)
        {
            string id = "";
            con.Open();
            string qr = "select Bus_Id from Bus_Detail where Bus_Number ='" + busnumber + "'";
            SqlCommand command = new SqlCommand(qr, con);
            //sqldatareader - used to read set of records returned from the sql select query
            SqlDataReader dr = command.ExecuteReader();
            //read method to read records from datareader
            while (dr.Read())
            {

                id = dr["Bus_Id"].ToString();
            }
            con.Close();
            return id;
        }

        public string AddStoppage(int busid, string stoppage, string time)
        {
            string Result = "";

            try
            {
                con.Open();

                string qr = "insert into Bus_Stoppages (Bus_Id,Stoppages,Stoppage_Time)values('" + busid + "','" + stoppage + "','" + time + "')";
                SqlCommand cmd = new SqlCommand(qr, con);
                cmd.ExecuteNonQuery();
                //for the page with only one form
                Result = "alert('stoppage added..!');";

            }
            catch (Exception e)
            {
                Result = e.ToString();
            }
            finally
            {
                con.Close();
            }
            return Result;
        }
        // arraylist is collection class which can add items dynamically 
        public ArrayList GetSource()
        {
            ArrayList al = new ArrayList();
            con.Open();
            string qr = "select Source from Bus_Detail ";
            SqlCommand command = new SqlCommand(qr, con);
            //sqldatareader - used to read set of records returned from the sql select query
            SqlDataReader dr = command.ExecuteReader();
            //read method to read records from datareader
            while (dr.Read())
            {
                al.Add(dr["Source"]);
            }
            con.Close();
            return al;
        }
        public ArrayList GetDestination()
        {
            ArrayList al = new ArrayList();
            con.Open();
            string qr = "select Destination from Bus_Detail ";
            SqlCommand command = new SqlCommand(qr, con);
            //sqldatareader - used to read set of records returned from the sql select query
            SqlDataReader dr = command.ExecuteReader();
            //read method to read records from datareader
            while (dr.Read())
            {
                al.Add(dr["Destination"]);
            }
            con.Close();
            return al;
        }
        public DataTable GetdataGrid(string source, string destination)
        {
            con.Open();
            string qr = "select bd.Source,bd.Destination,bd.Bus_Type,bd.Bus_Number,bst.Stoppages,bst.Stoppage_Time FROM Bus_Detail as bd INNER JOIN Bus_Stoppages as bst  ON bd.Bus_Id = bst.Bus_Id WHERE Source ='" + source + "' AND Destination = '" + destination + "'";
            SqlCommand command = new SqlCommand(qr, con);

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }
    }

}
    
