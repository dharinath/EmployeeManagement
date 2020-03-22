using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.BAL.Repository
{

    public class SalaryCalculator
    {
        private readonly Employees employees;
        public SalaryCalculator(Employees employees)
        {
            this.employees = employees;
        }

        public void CalculateSalaryForEmployees()
        {
            employees.CalculateSalary();
        }
    }



    
}