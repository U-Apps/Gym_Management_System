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
    [Authorize(Roles = clsSystemRoles.Admin)]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IBaseServices<Person> _personService;
        private readonly IBaseServices<JobHistory> _jobHistoryService;

        public UserController(UserService userService , IBaseServices<Person> personService, IBaseServices<JobHistory> jobHistoryService)
        {
            _userService = userService;
            _personService = personService;
            _jobHistoryService = jobHistoryService;
        }


        [HttpPost]
        [Route("[action]")]
        [AllowAnonymous]
        public ActionResult CreateUser(CreateUserDTO createUserDTO)
        {
            if (ModelState.IsValid)
            {
                if (_jobHistoryService.GetAll().Where(

                    j=>j.Employee.PersonId==createUserDTO.PersonId).FirstOrDefault()?
                    .Job.JobTitle!= "Receptionist")
                {
                    return BadRequest("this Employee is not Receptionist!!");
                }
                var user = new User();

                user.PersonId = createUserDTO.PersonId;
                user.UserName = createUserDTO.UserName;
                user.Password = createUserDTO.Password;
                user.IsActive = createUserDTO.IsActive;


                _userService.Register(user);
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPut]
        [Route("[action]")]

        public ActionResult UpdateUser(UpdateUserDTO updateUserDTO)
        {
            
            var existingUser = _userService.GetByUserName(updateUserDTO.UserName);
            if (existingUser == null)
                return NotFound();

            existingUser.UserName = updateUserDTO.UserName;
            existingUser.Password = updateUserDTO.Password;
            existingUser.IsActive = updateUserDTO.IsActive;
            _userService.Update(existingUser);
            return Ok();
        }


        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<ReadUserDTO>> Get()
        {

            var users = _userService.GetAll().Select(user => user.AsDTO(_personService.GetById(user.PersonId)));

            return Ok(users);
        }

        

        [HttpDelete]
        [Route("[action]/{Username}")]
        public ActionResult Delete(string Username)
        {
            User user = _userService.GetByUserName(Username);

            if (user is null)
                return NotFound();

            _userService.Delete(user);
            return Ok();
        }
    } 
}
