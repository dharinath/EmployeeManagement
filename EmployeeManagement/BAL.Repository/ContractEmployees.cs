using EmployeeManagement.Models;

namespace EmployeeManagement.BAL.Repository
{
    public class ContractEmployees : Employees
    {
        public ContractEmployees(EmployeesModel employeeModel) : base(employeeModel)
        {
        }
        public override double CalculateSalary() => EmployeeModel.Salary = EmployeeModel.BasicPay * 1.5;
    }
}