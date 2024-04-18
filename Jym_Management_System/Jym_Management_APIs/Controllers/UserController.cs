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
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;


        public UserController(UserService userService)
        {
            _userService = userService;

        }


        [HttpPost]
        [Route("")]

        public ActionResult CreateUser(CreateUserDTO createUserDTO)
        {
            if (ModelState.IsValid)
            {
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
        [Route("")]

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
        [Route("")]
        public ActionResult<IEnumerable<ReadUserDTO>> Get()
        {

            var users = _userService.GetAll().Select(user => user.AsDTO());

            return Ok(users);
        }

        [HttpGet]
        [Route("{id}")]
        

        [HttpDelete]
        [Route("{id}")]
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
