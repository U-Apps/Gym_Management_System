using GymManagement.BusinessCore.Models;

namespace GymManagement.BusinessCore.Contracts.Services
{
    public interface IRoleService
    {
        void Add(Role role);
        void Delete(int ID);
        List<Role> GetAll();
        Role GetById(int ID);
        void Update(Role role);
    }
}
