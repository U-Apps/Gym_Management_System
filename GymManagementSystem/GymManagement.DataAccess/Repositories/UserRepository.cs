using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Models;
using Microsoft.AspNetCore.Identity;

namespace GymManagement.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<AppUser> _UserManager;
        public UserRepository(UserManager<AppUser> userManager)
        {
            _UserManager = userManager;
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

        public IEnumerable<string> GetUserRoles(string UserName)
        {
            return _UserManager.GetRolesAsync(GetByUserName(UserName)).Result;
        }
    }
}
