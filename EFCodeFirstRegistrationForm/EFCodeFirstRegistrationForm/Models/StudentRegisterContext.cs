using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;

namespace EFCodeFirstRegistrationForm.Models
{
    public class StudentRegisterContext:DbContext
    {
        public StudentRegisterContext():base("StudentRegisterDatabase")
        {

        }
        public DbSet<StudentRegister> StudentRegisters { get; set; }
    }
}