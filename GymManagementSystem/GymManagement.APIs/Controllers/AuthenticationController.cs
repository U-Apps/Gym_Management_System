using Jym_Management_APIs.Authentication;
using Jym_Management_APIs.DTO_modules;
using Microsoft.AspNetCore.Mvc;

namespace Jym_Management_APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private LoginManager _LoginManager { get; }
        public AuthenticationController(LoginManager loginManager)
        {
            _LoginManager = loginManager;
        }


        [HttpPost]
        [Route("Login")]
        public ActionResult<LoginResponseDto> Login(LoginDto Credentials)
        {
            return _LoginManager.Login(Credentials);
        }

        
    }
}
