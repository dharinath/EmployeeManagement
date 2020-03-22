using EmployeeManagement.Models;

namespace EmployeeManagement.BAL.Repository
{
    public class PermanentEmployees : Employees
    {
        public PermanentEmployees(EmployeesModel employeesModel) : base(employeesModel)
        {
        }
        public override double CalculateSalary() => EmployeeModel.Salary = EmployeeModel.BasicPay * 2.0;
    }
}