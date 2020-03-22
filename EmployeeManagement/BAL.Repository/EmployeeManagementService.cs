using EmployeeManagement.DB.Repository;
using System;
using System.Linq;

namespace EmployeeManagement.BAL.Repository
{
    public class EmployeeManagementService : IEmployeeManagementService
    {
        private EmployeesRepository employeesrepository { get; set; }

         public EmployeeManagementService()
        {
            this.employeesrepository = new EmployeesRepository();
        }

        public Employees GetEmployeeDetails(int employeeId)
        {
            try
            {
                var employee = employeesrepository.GetEmployees().Where(x => x.EmployeeModel.ID == employeeId).FirstOrDefault();
                SalaryCalculator salaryCalculator = new SalaryCalculator(employee);
                salaryCalculator.CalculateSalaryForEmployees();
                return employee;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteEmployeeDetails(int employeeId)
        {
            return employeesrepository.DeleteEmployee(employeeId);
        }

        public int AddEmployeeDetails(Employees newemployee)
        {
           return employeesrepository.AddEmployee(newemployee);
        }

        public bool UpdateEmployeeDetails(Employees employee)
        {
            return employeesrepository.UpdateEmployee(employee);
        }
    }
}