using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jym_Management_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpPost]
        [Route("")]
        public ActionResult<int> CreateEmployee(Employee employee)
        {
            _employeeService.Add(employee);
            return Ok(employee.EmployeeId);
        }

    }
}
