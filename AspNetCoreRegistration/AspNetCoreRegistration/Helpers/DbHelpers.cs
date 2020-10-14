using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AspNetCoreRegistration.Helpers
{
    public class DbHelpers
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MachineTest;");
        }

    }
}
