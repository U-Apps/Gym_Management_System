using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jym_Management_BussinessLayer.Services.Base;
using System.Xml.Linq;

namespace Jym_Management_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IBaseServices<Employee> _employeeService;


        public EmployeeController(IBaseServices<Employee> employeeService)
        {
            _employeeService = employeeService;
           
        }


        [HttpPost]
        [Route("")]

        public ActionResult CreateEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            var employee = new Employee();

            employee.PersonId = createEmployeeDTO.PersonId;
            employee.ResignationDate = createEmployeeDTO.ResignationDate;
            employee.HireDate = createEmployeeDTO.HireDate;
            employee.Salary = createEmployeeDTO.Salary;
            _employeeService.Add(employee);
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public ActionResult UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            var existingEmployee = _employeeService.GetById(updateEmployeeDTO.EmployeeId);
            if (existingEmployee == null)
                return NotFound();

            existingEmployee.HireDate = updateEmployeeDTO.HireDate;
            existingEmployee.ResignationDate = updateEmployeeDTO.ResignationDate;
            existingEmployee.Salary = updateEmployeeDTO.Salary;
            existingEmployee.PersonId = updateEmployeeDTO.PersonId;
            _employeeService.Update(existingEmployee);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<ReadEmployeeDTO>> Get()
        {

            var employees = _employeeService.GetAll().Select(employee => employee.AsDTO());

            return Ok(employees);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReadEmployeeDTO> GetById(int id)
        {
            Employee employee = _employeeService.GetById(id);
            return employee is null ? NotFound() : Ok(employee.AsDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            Employee employee = _employeeService.GetById(id);

            if (employee is null)
                return NotFound();

            _employeeService.DeleteById(employee.EmployeeId);
            //_employeeService.Delete(employee);
            return Ok();
        }
    }
}
