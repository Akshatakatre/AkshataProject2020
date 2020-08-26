using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DigitalPass1
{
    public partial class Admin : System.Web.UI.Page
    {

        string Name;
        string Address;
        string MobileNumber;
        string Emailid;
        string Password;
        string Gender;
        DateTime DateofBirth;
        int AdharcardNumber;
        string SecurityQuestion;
        string SecurityAnswer;
        string Role;
        string RegistrationDate;
        string Photo;
        string res1;
        public string AdminNewRegistration(string name,string address,string mobilenumber,string emailid, string password,string gender,DateTime dateofbirth,int adharcardnumber,string securityquestion,string securityanswer,string role,string registrationdate,string photo)
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
            Role = role;
            RegistrationDate = registrationdate;
            Photo = photo;
            return res1;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}