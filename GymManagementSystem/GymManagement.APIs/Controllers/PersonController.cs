using GymManagement.APIs.DTOs;
using GymManagement.BusinessCore.Models;
using Microsoft.AspNetCore.Mvc;
using GymManagement.BusinessCore.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using GymManagement.APIs.Authentication;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = (clsSystemRoles.User + "," + clsSystemRoles.Admin))]
    public class PersonController : ControllerBase
    {
       readonly IBaseServices<Person> _personService;

        public PersonController(IBaseServices<Person> personService)
        {
            _personService = personService;
        }

     
        [HttpPost]
        [Route("[action]")]
        public ActionResult CreatePerson(CreatePersonDTO person)
        {
            //var emp = new Person
            //{
            // NationalNumber = person.Idcard,
            // Email = person.Email,
            // PhoneNumber = person.PhoneNumber,
            // BirthDate = person.BirthDate,
            // Name = person.Name,
            //};


            //_personService.Add(emp);
            return Ok();
        }
        [HttpPut]
        [Route("[action]")]
        public ActionResult UpdatePerson(UpdatePersonDTO person)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            var existingPerson = _personService.GetById(person.PersonId);
            if (existingPerson == null)
                return NotFound();

            //existingPerson.Name = person.Name ;
            existingPerson.PhoneNumber = person.PhoneNumber;
            existingPerson.BirthDate = person.BirthDate;
            existingPerson.Email = person.Email;
            _personService.Update(existingPerson);
            return Ok();
        }
        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<Person>> Get()
        {
            IEnumerable<Person> persons = _personService.GetAll();
            return Ok(persons);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<Person> GetById(int id)
        {
           Person person = _personService.GetById(id);
            return person is null ? NotFound() : Ok(person);
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public ActionResult Delete(int id)
        {
            Person person = _personService.GetById(id);

            if (person is null)
                return NotFound();

            _personService.DeleteById(person.Id);
            //_employeeService.Delete(employee);
            return Ok();
        }


    }
}
