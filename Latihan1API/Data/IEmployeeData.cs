using Latihan1API.Models;
using System;
using System.Collections.Generic;

namespace Latihan1API.Data
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Employee EditEmployee(Employee employee);
    }
}
