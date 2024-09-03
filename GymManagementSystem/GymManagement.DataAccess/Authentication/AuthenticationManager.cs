using Jym_Management_DataAccessLayer.Entities.Authentication;
using Jym_Management_DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Authentication
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
