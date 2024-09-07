using GymManagement.BusinessCore.Models;
using GymManagement.DataAccess.DependencyInjection;
using Microsoft.AspNetCore.Identity;

namespace GymManagement.DataAccess.Authentication
{
    public class AuthenticationManager
    {
        private UserManager<AppUser> _UserManager { get; }

        public AuthenticationManager()
        {
            _UserManager = ServiceConfiguration.GetService<UserManager<AppUser>>();
        }

        public bool Login(string UserName, string Password)
        {
            var User = _UserManager.FindByNameAsync(UserName).Result;
            return User == null ? false : _UserManager.CheckPasswordAsync(User, Password).Result ? true : false;
        }
    }
}
