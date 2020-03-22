using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BAL.Repository
{
    public interface IEmployeeManagementService
    {
        Employees GetEmployeeDetails(int employeeId);
        int AddEmployeeDetails(Employees newemployee);
        bool UpdateEmployeeDetails(Employees employee);
        bool DeleteEmployeeDetails(int employeeId);
    }
}
