using EmployeeManagement.BAL.Repository;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.DB.Repository
{
    public interface IEmployeeRepository
    {
        List<Employees> GetEmployees();
        int AddEmployee(Employees employee);
        bool UpdateEmployee(Employees employee);
        bool DeleteEmployee(int employeeID);

    }
}