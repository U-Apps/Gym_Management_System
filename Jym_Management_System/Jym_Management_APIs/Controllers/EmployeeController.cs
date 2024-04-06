using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.AutoMapper;
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
        public ActionResult CreateEmployee(CreateEmployeeDTO employee)
        {
            var emp = new Employee
            {
                PersonId = employee.PersonId,
                HireDate = employee.HireDate,
                ResignationDate = employee.ResignationDate,
                Salary = employee.Salary,
               
            };


            _employeeService.Add(emp);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public ActionResult UpdateEmployee(UpdateEmployeeDTO employee)
        {
            if(!ModelState.IsValid) {return BadRequest(); }
            var existingEmployee = _employeeService.GetById(employee.Id);
            if (existingEmployee == null)
                return NotFound();

            existingEmployee.HireDate = employee.HireDate;
            existingEmployee.ResignationDate = employee.ResignationDate;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.PersonId = employee.PersonId;
            _employeeService.Update(existingEmployee);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<ReadEmployeeDTO>> Get()
        {
            IEnumerable<Employee> employees = _employeeService.GetAll();
            var result = employees.Select(x => new ReadEmployeeDTO
            {
                Id = x.EmployeeId,
                PersonId = x.PersonId,
                HireDate = x.HireDate,
                ResignationDate = x.ResignationDate,
                Salary = x.Salary,
                person = new ReadPersonDTO
                {
                    PersonId = x.PersonId,
                    Idcard = x.Person.Idcard,
                    Name = x.Person.Name,
                    PhoneNumber = x.Person.PhoneNumber,
                    BirthDate = x.Person.BirthDate,
                    Email = x.Person.Email,
                }
                         
            }); 
            


            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Employee> GetById(int id)
        {
            Employee employee = _employeeService.GetById(id);
            return employee is null ? NotFound() : Ok(employee);
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
