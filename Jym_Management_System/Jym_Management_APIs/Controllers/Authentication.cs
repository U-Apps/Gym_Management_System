using Jym_Management_APIs.Authentication;
using Jym_Management_APIs.DTO_modules;
using Microsoft.AspNetCore.Mvc;

namespace Jym_Management_APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Authentication : ControllerBase
    {
        private LoginManager _LoginManager { get; }
        public Authentication(LoginManager loginManager)
        {
            _LoginManager = loginManager;
        }


        [HttpPost]
        [Route("")]
        public ActionResult<LoginResponseDto> Login(LoginDto Credentials)
        {
            return _LoginManager.Login(Credentials);
        }

        
    }
}
