using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cormant.Services;

namespace Cormant.Web.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GetEmployees()
        {
            var employeeService = new EmployeeService();

            return employeeService.GetEmployees();
        }

        public IHttpActionResult GetEmployee(int id)
        {

            return NotFound();
        }
    }
}
