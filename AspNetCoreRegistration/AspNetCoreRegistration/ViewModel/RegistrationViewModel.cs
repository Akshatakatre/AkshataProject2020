using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AspNetCoreRegistration.Models;
using Dapper;
using AspNetCoreRegistration.Helpers;



namespace AspNetCoreRegistration.ViewModel
{
    public class RegistrationViewModel
    {
        public List<RegistrationTable> TodoItems { get; set; }

        public RegistrationTable EditableItem { get; set; }

        public RegistrationViewModel()
        {
            using (var db = DbHelpers.GetConnection())
            {
                this.EditableItem = new RegistrationTable();
                this.TodoItems = db.Query<RegistrationTable>("SELECT * FROM RegistrationTable ORDER BY AddDate DESC").ToList();
            }
        }

    }
}
