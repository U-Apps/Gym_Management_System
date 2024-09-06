using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GymManagement.APIs.Authentication;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;
using GymManagement.APIs.DTOs;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = clsSystemRoles.Admin)]
    public class EmployeeController : ControllerBase
    {
        private readonly IBaseServices<Employee> _employeeService;
        private readonly IBaseServices<Person> _personService;

        public IBaseServices<JobHistory> _HistoryService { get; }

        public EmployeeController(IBaseServices<Employee> employeeService, 
            IBaseServices<Person> personService,
            IBaseServices<JobHistory> historyService)
        {
            _employeeService = employeeService;
            _personService = personService;
            _HistoryService = historyService;
        }


        [HttpPost]
        [Route("[action]")]

        public ActionResult CreateEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            var person = new Person()
            {
                Name = createEmployeeDTO.Name,
                Idcard = createEmployeeDTO.Idcard,
                PhoneNumber = createEmployeeDTO.PhoneNumber,
                Email = createEmployeeDTO.Email,
                BirthDate = createEmployeeDTO.BirthDate
            };

            var employee = new Employee();

            employee.PersonId = _personService.Add(person);
            //employee.ResignationDate = createEmployeeDTO.ResignationDate;
            employee.HireDate = createEmployeeDTO.HireDate;
            employee.Salary = createEmployeeDTO.Salary;
            employee.JobID = createEmployeeDTO.CurrentJop;

            var History = new JobHistory()
            {
                EmpoyeeId = _employeeService.Add(employee),
                JobId = employee.JobID.Value,
                StartDate = employee.HireDate
            };

            _HistoryService.Add(History);
            
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]

        public ActionResult UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            var existingEmployee = _employeeService.GetById(updateEmployeeDTO.EmployeeId);
            if (existingEmployee == null)
                return NotFound();


            var existingPerson = _personService.GetById(existingEmployee.PersonId);

            existingPerson.Name = updateEmployeeDTO.Name;
            existingPerson.PhoneNumber = updateEmployeeDTO.PhoneNumber;
            existingPerson.BirthDate = updateEmployeeDTO.BirthDate;
            existingPerson.Email = updateEmployeeDTO.Email;
            _personService.Update(existingPerson);

            existingEmployee.Person = existingPerson;

            existingEmployee.HireDate = updateEmployeeDTO.HireDate;
            existingEmployee.ResignationDate = updateEmployeeDTO.ResignationDate;
            existingEmployee.Salary = updateEmployeeDTO.Salary;
            existingEmployee.JobID = updateEmployeeDTO.CurrentJop;
            _employeeService.Update(existingEmployee);
            return Ok();
        }


        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<ReadEmployeeDTO>> GetEmployees()
        {

            var employees = _employeeService.GetAll().Select(employee => employee.AsDTO());

            return Ok(employees);
        }

        [HttpGet]
        [Route("[action]/{jobTitle}")]
        public ActionResult<IEnumerable<ReadEmployeeDTO>> GetEmployeesBy(string jobTitle)
        {

            var employees = _employeeService.GetAll().Where(emp=>emp.CurrentJob.JobTitle==jobTitle).Select(employee => employee.AsDTO());

            return Ok(employees);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<ReadEmployeeDTO> GetById(int id)
        {
            Employee employee = _employeeService.GetById(id);
            return employee is null ? NotFound() : Ok(employee.AsDTO());
        }

        [HttpDelete]
        [Route("[action]/{id}")]
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
