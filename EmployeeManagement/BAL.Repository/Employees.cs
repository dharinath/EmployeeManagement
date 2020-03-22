using EmployeeManagement.Models;

namespace EmployeeManagement.BAL.Repository
{
    public abstract class Employees
    {
        public EmployeesModel EmployeeModel { get; set; }
        public Employees(EmployeesModel employeeModel)
        {
            this.EmployeeModel = employeeModel;
        }
        public abstract double CalculateSalary();
    }
}