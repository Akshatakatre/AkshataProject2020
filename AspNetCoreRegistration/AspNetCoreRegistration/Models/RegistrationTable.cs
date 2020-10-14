using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreRegistration.Models
{
    public class RegistrationTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile_Number { get; set; }
        public string Email_id { get; set; }
        public string Password { get; set; }
        public string Conform_Password { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime Date_of_Birth { get; set; }
        



    }
}
