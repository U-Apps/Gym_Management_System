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


                _userService.Register();
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
            var existingUser = _userService.GetById(updateUserDTO.UserId);
            if (existingUser == null)
                return NotFound();

            existingUser.UserName = updateUserDTO.UserName;
            existingUser.Password = updateUserDTO.Password;
            existingUser.IsActive = updateUserDTO.IsActive;
            existingUser.PermissionsId = updateUserDTO.PermissionsId;
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
        public ActionResult<ReadUserDTO> GetById(int id)
        {
            User user = _userService.GetById(id);
            return user is null ? NotFound() : Ok(user.AsDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            User user = _userService.GetById(id);

            if (user is null)
                return NotFound();

            _userService.DeleteById(user.UserId);
            return Ok();
        }
    } 
}
