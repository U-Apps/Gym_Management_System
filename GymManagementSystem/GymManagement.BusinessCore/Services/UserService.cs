using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BussinessCore.Models;

namespace GymManagement.BusinessCore.Services
{
    public class UserService
    {
        private readonly IUserRepository _UserRepository;

        public UserService(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public void Register(AppUser _UserModule, string password)
        {
            _UserRepository.Register(_UserModule, password);
        }
        public void Delete(AppUser _UserModule)
        {
            _UserRepository.Delete(_UserModule);
        }

        public void Update(AppUser _UserModule)
        {
            _UserRepository.Update(_UserModule);

        }

        public List<AppUser> GetAll()
        {
            return _UserRepository.GetAll();
        }

        public AppUser GetByUserName(string Username)
        {
            return _UserRepository.GetByUserName(Username);
        }

        public void AddUserToRole(AppUser _UserModule, string role)
        {
            _UserRepository.AddUserToRole(_UserModule, role);
        }

        public void AddUserToRoles(AppUser _UserModule, IEnumerable<string> roles)
        {
            _UserRepository.AddUserToRoles(_UserModule, roles);
        }
        public void RemoveUserToRole(AppUser _UserModule, string role)
        {
            _UserRepository.RemoveUserToRole(_UserModule, role);
        }

        public void RemoveUserToRoles(AppUser _UserModule, IEnumerable<string> roles)
        {
            _UserRepository.RemoveUserToRoles(_UserModule, roles);
        }

        public IEnumerable<string> GetUserRoles (string UserName)
        {
            return _UserRepository.GetUserRoles(UserName);
        }
    }
}

             
