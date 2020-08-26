using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpDll
{
    public class Registration
    {
        public int Registrationid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Emailid { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public int AdharcardNumber { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string RegistrationDate { get; set; }
        public string Photo { get; set; }

        string cn;
        SqlConnection con;

        public Registration()
        {
            cn = "data source= DANNY;integrated security=true;database=BUSPASSSYSTEMDatabase";
            
            con = new SqlConnection(cn);
        }

        public string CheckEmailid(string email)
        {
            string result = "";

            try
            {
                con.Open();
                string qr = "select count(*) from RegistrationTable where Email_Id ='" + email + "'";
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

                /*SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        result = "exist";
                        break;
                        // MessageBox.Show("EmailId = " + dr[5].ToString() + " Already exist");
                        //txtEmail.Clear();

                    }
                    else if (dr.HasRows == false)
                    {
                        result = "not exist";
                    }
                }*/

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



        //method to save the registration details
        public string NewRegistration(string name,string address,string mobilenumber,string emailid,string password,string gender,DateTime dateofbirth,int adharcardnumber,string securityquestion,string securityanswer,string registrationdate,string photo)
        {
            Name = name;
            Address = address;
            MobileNumber = mobilenumber;
            Emailid = emailid;
            Password = password;
            Gender = gender;
            DateofBirth = dateofbirth;
            AdharcardNumber = adharcardnumber;
            SecurityQuestion = securityquestion;
            SecurityAnswer = securityanswer;
            RegistrationDate = registrationdate;
            Photo = photo;
            string Result = "";

            try
            {
                con.Open();

                string qr = "insert into RegistrationTable(Name,Address,Mobile_Number,Email_Id,Password,Gender,Date_of_Birth,AdharCard_Number,Security_Question,Security_Answer,Registration_Date,Photo)values('" + name + "','" + address + "','" + mobilenumber + "','" + emailid + "','" + password + "','" + gender + "','" + dateofbirth + "','" + adharcardnumber + "','" + securityquestion + "','" + securityanswer + "','" + registrationdate + "','" + photo + "')";
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



    }
}
