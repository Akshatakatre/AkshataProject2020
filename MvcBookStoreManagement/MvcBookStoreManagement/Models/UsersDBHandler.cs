using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MvcBookStoreManagement.Models
{
    public class UsersDBHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["BookStoreConString"].ToString();
            con = new SqlConnection(constring);
        }


    }
}