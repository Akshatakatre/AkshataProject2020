using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationFormMvcEF.Models
{
    public class RegistrationClass
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Emailid { get; set; }
        public string Password { get; set; }
        public string ConnformPassword { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public courses Course { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    public enum courses
    {
        CProgramming,CPlusPlus,DotNet,Java,Python
    }

}