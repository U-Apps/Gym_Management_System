using Jym_Management_BussinessLayer.Modules;
using Jym_Management_DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_BussinessLayer.Services
{
    public class RoleService
    {
        private readonly RoleRepository _roleRepo;
        IdentityRole<int> identityRole;
        public RoleService() 
        { 
            _roleRepo= new RoleRepository();
            identityRole = new IdentityRole<int>();
        }
        public void Add(Role role)
        {
            identityRole.Name = role.RoleName;
            identityRole.NormalizedName = role.RoleName.ToUpper();
            _roleRepo.Add(identityRole);
        }
        public void Delete(int ID)
        {
            identityRole = _roleRepo.GetById(Convert.ToString(ID));
            _roleRepo.Delete(identityRole);
        }

        public void Update(Role role)
        {
            identityRole = _roleRepo.GetById(Convert.ToString(role.RoleId));
            identityRole.Name = role.RoleName;
            identityRole.NormalizedName = role.RoleName.ToUpper();
            _roleRepo.Update(identityRole);
        }

        public List<Role> GetAll()
        {
           var roles = new List<Role>();
            var dataRoles = _roleRepo.GetAll();
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
            identityRole = _roleRepo.GetById(Convert.ToString(ID));
            var role = new Role
            {
                RoleId = identityRole.Id,
                RoleName = identityRole.Name
            };
           return role;
        }
    }
}
