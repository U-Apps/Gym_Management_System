using GymManagement.BusinessCore.Models;
using Microsoft.AspNetCore.Identity;

namespace GymManagement.DataAccess.Authentication
{
    public class AuthenticationManager
    {
        private readonly UserManager<AppUser> _UserManager;

        public AuthenticationManager(UserManager<AppUser> userManager)
        {
            _UserManager = userManager;
        }

        public bool Login(string UserName, string Password)
        {
            var User = _UserManager.FindByNameAsync(UserName).Result;
            return User == null ? false : _UserManager.CheckPasswordAsync(User, Password).Result ? true : false;
        }
    }
}
