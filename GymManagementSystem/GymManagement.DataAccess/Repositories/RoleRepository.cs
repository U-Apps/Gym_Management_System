using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.DataAccess.DependencyInjection;
using Microsoft.AspNetCore.Identity;

namespace GymManagement.DataAccess.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<IdentityRole<int>> _RoleManager;
        public RoleRepository(RoleManager<IdentityRole<int>> roleManager)
        {
            _RoleManager = roleManager;
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
