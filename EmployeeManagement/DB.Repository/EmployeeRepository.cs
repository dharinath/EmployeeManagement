using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeManagement.DB;
using EmployeeManagement.Models;
using EmployeeManagement.BAL.Repository;

namespace EmployeeManagement.DB.Repository
{
    public class EmployeesRepository : IEmployeeRepository
    {
        List<BAL.Repository.Employees> employeelst = new List<BAL.Repository.Employees>() {
             new PermanentEmployees (new EmployeesModel() { ID =1, Name="Harinath", Age=37, Designation="Manager", BasicPay=2000}),
             new PermanentEmployees (new EmployeesModel() { ID =2, Name="Satheesh", Age=37, Designation="Manager", BasicPay=2000, EmployeeType ="Permanent"}),
             new PermanentEmployees (new EmployeesModel() { ID =3, Name="Syed", Age=37, Designation="HR", BasicPay=2000, EmployeeType ="Contractor"}),
             new ContractEmployees(new EmployeesModel() { ID =4, Name="Hamea", Age=37, Designation="Co-ordinator", BasicPay=2000, EmployeeType ="Permanent"}),
             new ContractEmployees(new EmployeesModel() { ID =5, Name="Hari", Age=37, Designation="Developer", BasicPay=2000, EmployeeType ="Permanent"}),
          };

        public List<BAL.Repository.Employees> GetEmployees()
        {
            try
            {
                return employeelst;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int AddEmployee(Employees employee)
        {
            try
            {
                employeelst.Add(employee);
                return employeelst.Count;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool UpdateEmployee(Employees employee)
        {
            throw new NotImplementedException();
        }
        public bool DeleteEmployee(int employeeID)
        {
            throw new NotImplementedException();
        }

    }
}