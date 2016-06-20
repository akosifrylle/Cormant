using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cormant.Services;

namespace Cormant.Web.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            var employeeService = new EmployeeService();

            return employeeService.GetEmployees();
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var employee = _employeeService.GetEmployee(id);

            if (employee != null)
                return Ok(employee);

            return NotFound();
        }

        //[Route("{email},{password}")]
        [Route("email={email},password={password}/")]
        [HttpGet]
        public IHttpActionResult Login(string email, string password)
        {
            var employeeService = new EmployeeService();

            var employee = employeeService.Login(email, password);

            if (employee != null)
                return Ok(employee);

            return NotFound();
        }
    }
}
