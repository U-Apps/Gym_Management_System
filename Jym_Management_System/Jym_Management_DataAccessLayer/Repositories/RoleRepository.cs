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
    public class RoleRepository
    {
        private RoleManager<IdentityRole<int>> _RoleManager { get;}
        public RoleRepository()
        {
            _RoleManager = ServiceConfiguration.GetService<RoleManager<IdentityRole<int>>>();
        }

        public void Add(IdentityRole<int> Role)
        {
            _RoleManager.CreateAsync(Role);
        }
        public void Delete(IdentityRole<int> Role)
        {
            _RoleManager.DeleteAsync(Role);
        }
        
        public void Update(IdentityRole<int> Role)
        {
            _RoleManager.UpdateAsync(Role);
        }

        public List<IdentityRole<int>> GetAll()
        {
            return _RoleManager.Roles.ToList();
        }

        public IdentityRole<int> GetById(string Id)
        {
            return _RoleManager.FindByIdAsync(Id).Result;
        }

        
    }
}
