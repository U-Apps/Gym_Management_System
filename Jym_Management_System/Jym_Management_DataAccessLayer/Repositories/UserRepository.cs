using Jym_Management_DataAccessLayer.Entities.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Repositories
{
    public class UserRepository
    {
        private UserManager<AppUser> _UserManager { get;}
        public UserRepository()
        {
            _UserManager = ServiceConfiguration.GetService<UserManager<AppUser>>();
        }

        public void Register(AppUser user, string password)
        {
            _UserManager.CreateAsync(user, password);
        }
        public void Delete(AppUser user)
        {
            _UserManager.DeleteAsync(user);
        }
        
        public void Update(AppUser user)
        {
            _UserManager.UpdateAsync(user);
        }

        public List<AppUser> GetAll()
        {
            return _UserManager.Users.ToList();
        }

        public AppUser GetByUserName(string userName)
        {
            return _UserManager.FindByNameAsync(userName).Result;
        }

        public void AddUserToRole(AppUser user, string role)
        {
            _UserManager.AddToRoleAsync(user, role);
        }
        
        public void AddUserToRoles(AppUser user, IEnumerable<string> roles)
        {
            _UserManager.AddToRolesAsync(user, roles);
        }

        public void RemoveUserToRole(AppUser user, string role)
        {
            _UserManager.RemoveFromRoleAsync(user, role);
        }

        public void RemoveUserToRoles(AppUser user, IEnumerable<string> roles)
        {
            _UserManager.RemoveFromRolesAsync(user, roles);
        }
    }
}
