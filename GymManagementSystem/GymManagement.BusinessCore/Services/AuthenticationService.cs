

using GymManagement.BussinessCore.Models;
using Microsoft.AspNetCore.Identity;

namespace GymManagement.BusinessCore.Services
{
    public class AuthenticationService
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthenticationService(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
        }


        public bool Login(string UserName, string Password)
        {
            var User = _userManager.FindByNameAsync(UserName).Result;
            return User == null ? false : _userManager.CheckPasswordAsync(User, Password).Result ? true : false;
        }
    }
}
