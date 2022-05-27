using Latihan1API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Latihan1API.Data
{
    public class SqlEmployeeData : IEmployeeData
    {
        private ApplicationDbContext _applicationDbContext;
        public SqlEmployeeData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            _applicationDbContext.Employees.Add(employee);
            _applicationDbContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _applicationDbContext.Employees.Remove(employee);
            _applicationDbContext.SaveChanges();
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = _applicationDbContext.Employees.Find(employee.Id);
            if(existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                _applicationDbContext.Employees.Update(existingEmployee);
                _applicationDbContext.SaveChanges();
            }
            return employee;
        }

        public Employee GetEmployee(Guid id)
        {
            var employee = _applicationDbContext.Employees.Find(id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _applicationDbContext.Employees.ToList();
        }
    }
}
