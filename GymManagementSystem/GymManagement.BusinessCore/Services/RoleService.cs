using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BussinessCore.Contracts.Repositories;
using GymManagement.BussinessCore.Models;
using Microsoft.AspNetCore.Identity;

namespace GymManagement.BusinessCore.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _Repository;
        IdentityRole<int> identityRole;

        public RoleService(IRoleRepository repository)
        {
            _Repository = repository;
            identityRole = new IdentityRole<int>();
        }

        public void Add(Role role)
        {
            identityRole.Name = role.RoleName;
            identityRole.NormalizedName = role.RoleName.ToUpper();
            _Repository.Add(identityRole);
        }
        public void Delete(int ID)
        {
            identityRole = _Repository.GetById(Convert.ToString(ID));
            _Repository.Delete(identityRole);
        }

        public void Update(Role role)
        {
            identityRole = _Repository.GetById(Convert.ToString(role.RoleId));
            identityRole.Name = role.RoleName;
            identityRole.NormalizedName = role.RoleName.ToUpper();
            _Repository.Update(identityRole);
        }

        public List<Role> GetAll()
        {
            var roles = new List<Role>();
            var dataRoles = _Repository.GetAll();
            foreach (var dataRole in dataRoles)
            {
                var Role = new Role
                {
                    RoleId = dataRole.Id,
                    RoleName = dataRole.Name
                };
                roles.Add(Role);
            }
            return roles;
        }

        public Role GetById(int ID)
        {
            identityRole = _Repository.GetById(Convert.ToString(ID));
            var role = new Role
            {
                RoleId = identityRole.Id,
                RoleName = identityRole.Name
            };
            return role;
        }
    }
}
