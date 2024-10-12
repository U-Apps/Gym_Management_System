using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GymManagement.APIs.Authentication;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;
using GymManagement.APIs.DTOs;
using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Services;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = clsSystemRoles.Admin)]
    public class EmployeeController : ControllerBase
    {
        private readonly IBaseRepository<Employee> _employeeService;
        private readonly IBaseRepository<Person> _personService;

        public IBaseRepository<JobHistory> _HistoryService { get; }

        public EmployeeController(IBaseRepository<Employee> employeeService, 
            IBaseRepository<Person> personService,
            IBaseRepository<JobHistory> historyService)
        {
            _employeeService = employeeService;
            _personService = personService;
            _HistoryService = historyService;
        }


        [HttpPost]
        [Route("[action]")]

        public async Task<IActionResult> CreateEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            var Employee = new Employee()
            {
                FirstName = createEmployeeDTO.Name,
                NationalNumber = createEmployeeDTO.Idcard,
                PhoneNumber = createEmployeeDTO.PhoneNumber,
                Email = createEmployeeDTO.Email,
                BirthDate = createEmployeeDTO.BirthDate,
                RegisterationDate = DateTime.Now,
                Salary = createEmployeeDTO.Salary,
                JobID = createEmployeeDTO.CurrentJop

            };
            await  _employeeService.Add(Employee);
            await _employeeService.SaveChanges();
            var History = new JobHistory()
            {
                EmpoyeeId = Employee.Id,
                JobId = Employee.JobID.Value,
                StartDate = Employee.RegisterationDate
            };

            await _HistoryService.Add(History);
            
            return Ok(Employee.Id);
        }

        [HttpPut]
        [Route("[action]")]

        public async Task<ActionResult> UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            var existingEmployee = _employeeService.GetById(x=>x.Id==updateEmployeeDTO.EmployeeId,nav=>nav.CurrentJob);
            if (existingEmployee == null)
                return NotFound();


            //var existingPerson = _personService.GetById(existingEmployee.PersonId);

            existingEmployee.FirstName = updateEmployeeDTO.Name;
            existingEmployee.PhoneNumber = updateEmployeeDTO.PhoneNumber;
            existingEmployee.BirthDate = updateEmployeeDTO.BirthDate;
            existingEmployee.Email = updateEmployeeDTO.Email;
            //_personService.Update(existingPerson);

            //existingEmployee.Person = existingPerson;

            existingEmployee.RegisterationDate = updateEmployeeDTO.HireDate;
            existingEmployee.ResignationDate = updateEmployeeDTO.ResignationDate;
            existingEmployee.Salary = updateEmployeeDTO.Salary;
            existingEmployee.JobID = updateEmployeeDTO.CurrentJop;
            _employeeService.Update(existingEmployee);
            await _employeeService.SaveChanges();
            return Ok();
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<ReadEmployeeDTO>>> GetEmployees()
        {

            var employees = await _employeeService.GetAll(x=>x.CurrentJob);
             var  employeesDTO=employees.Select(employee => employee.AsDTO());

            return Ok(employeesDTO);
        }

        [HttpGet]
        [Route("[action]/{jobTitle}")]
        public async Task<ActionResult<IEnumerable<ReadEmployeeDTO>>> GetEmployeesBy(string jobTitle)
        {

            var employees = await _employeeService.GetAll();
                var employeesDTO =employees.Where(emp=>emp.CurrentJob.JobTitle==jobTitle).Select(employee => employee.AsDTO());

            return Ok(employeesDTO);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<ReadEmployeeDTO> GetById(int id)
        {
            Employee employee = _employeeService.GetById(x=>x.Id==id,includes=>includes.CurrentJob);
            return employee is null ? NotFound() : Ok(employee.AsDTO());
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Employee employee = _employeeService.GetById(x => x.Id == id, includes => includes.CurrentJob);

            if (employee is null)
                return NotFound();

            _employeeService.DeleteById(employee);
            await _employeeService.SaveChanges();
            return Ok();
        }
    }
}
