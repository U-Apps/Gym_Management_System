using GymManagement.BusinessCore.Models;

namespace GymManagement.BusinessCore.Contracts.Repositories
{
    public interface IUserRepository
    {
        void AddUserToRole(AppUser user, string role);
        void AddUserToRoles(AppUser user, IEnumerable<string> roles);
        void Delete(AppUser user);
        List<AppUser> GetAll();
        AppUser GetByUserName(string userName);
        IEnumerable<string> GetUserRoles(string UserName);
        void Register(AppUser user, string password);
        void RemoveUserToRole(AppUser user, string role);
        void RemoveUserToRoles(AppUser user, IEnumerable<string> roles);
        void Update(AppUser user);
    }
}
