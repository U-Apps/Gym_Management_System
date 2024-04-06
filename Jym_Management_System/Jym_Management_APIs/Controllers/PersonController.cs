using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using Jym_Management_BussinessLayer.Services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jym_Management_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
       readonly IBaseServices<Person> _personService;

        public PersonController(IBaseServices<Person> personService)
        {
            _personService = personService;
        }

     
        [HttpPost]
        [Route("")]
        public ActionResult CreateEmployee(CreatePersonDTO employee)
        {
            var emp = new Person
            {
             Idcard = employee.Idcard,
             Email = employee.Email,
             PhoneNumber = employee.PhoneNumber,
             BirthDate = employee.BirthDate,
             Name = employee.Name,
            };


            _personService.Add(emp);
            return Ok();
        }
        [HttpPut]
        [Route("")]
        public ActionResult UpdateEmployee(UpdatePersonDTO person)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            var existingPerson = _personService.GetById(person.PersonId);
            if (existingPerson == null)
                return NotFound();

            existingPerson.Name = person.Name ;
            existingPerson.PhoneNumber = person.PhoneNumber;
            existingPerson.BirthDate = person.BirthDate;
            existingPerson.Email = person.Email;
            _personService.Update(existingPerson);
            return Ok();
        }


    }
}
