using EmployeeManagement.BAL.Repository;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.Controllers
{
    [RoutePrefix("api/employeemanagements")]
    public class EmployeeManagementController : ApiController
    {
        //Remote Comment
        private readonly IEmployeeManagementService employeeService;
        public EmployeeManagementController()
        {
            this.employeeService = new EmployeeManagementService();
        }

        //GET: api/employeemanagement/employees/5
        [Route("employees/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var employeeDetail = employeeService.GetEmployeeDetails(id);

                if(employeeDetail == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, string.Concat(id," Employee not Found."));
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, employeeDetail);
                }
                
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        //POST: api/employeemanagement/employees
        [HttpPost]
        [Route("employees")]
        public HttpResponseMessage AddEmployee([FromBody] Employees employee)
        {
            try
            {
                int employeeID = employeeService.AddEmployeeDetails(employee);
                return Request.CreateResponse(HttpStatusCode.Created, employeeID);
            }
            catch(Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Unable to Create new Employee. Please try after sometime.");
            }
        }

        //PUT: api/employeemanagement/employees
        [HttpPut]
        [Route("employees")]
        public HttpResponseMessage UpdateEmployee([FromBody]Employees employee)
        {
            try
            {
                bool IsUpdateSuccessful = employeeService.UpdateEmployeeDetails(employee);

                if (IsUpdateSuccessful)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Unable to update the Employee. Please try after sometime.");
            }
        }

        //GET: api/employeemanagement/employees/5
        [HttpDelete]
        [Route("employees/{id}")]
        public HttpResponseMessage DeleteEmployee(int employeeid)
        {
            try
            {
                bool IsDeletedSuccessful = employeeService.DeleteEmployeeDetails(employeeid);

                if (IsDeletedSuccessful)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Unable to delete the Employee. Please try after sometime.");
            }
        }
    }
}
