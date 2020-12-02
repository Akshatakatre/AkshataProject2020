using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsumingRestAPI.Models.Repository;

namespace ConsumingRestAPI.Models.DataManager
{
    public class EmployeeManager : IDataRepository<Empolyee>
    {
        readonly EmployeeContext _employeeContext;
        private EmployeeContext empolyee;

        public EmployeeManager(EmployeeContext context)
        {
            _employeeContext = context;
        }
        public IEnumerable<Empolyee> GetAll()
        {
            return _employeeContext.Employee.ToList();
        }
        public Empolyee Get(long id)
        {
            return _employeeContext.Employee
                  .FirstOrDefault(e => e.EmployeeId == id);
        }
        public void Add(Empolyee entity)
        {
            _employeeContext.Employee.Add(entity);
            _employeeContext.SaveChanges();
        }
        public void Update(Empolyee employee, Empolyee entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Email = entity.Email;
            employee.DateOfBirth = entity.DateOfBirth;
            employee.PhoneNumber = entity.PhoneNumber;
            _employeeContext.SaveChanges();
        }
        public void Delete(Empolyee employee)
        {
            _employeeContext.Employees.Remove(empolyee);
            _employeeContext.SaveChanges();
        }



       
    }
}
