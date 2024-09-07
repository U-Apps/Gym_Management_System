using GymManagement.APIs.Authentication;
using GymManagement.APIs.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.APIs.Controllers
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
