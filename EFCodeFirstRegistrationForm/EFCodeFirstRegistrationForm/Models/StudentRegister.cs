using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace EFCodeFirstRegistrationForm.Models
{
    public class StudentRegister
    {
        public int Registrationid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Emailid { get; set; }
        public string Password { get; set; }
        public string ConformPassword { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Course { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}