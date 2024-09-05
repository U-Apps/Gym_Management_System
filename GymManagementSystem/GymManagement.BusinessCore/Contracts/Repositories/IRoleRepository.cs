using Microsoft.AspNetCore.Identity;

namespace GymManagement.BussinessCore.Contracts.Repositories
{
    public interface IRoleRepository
    {
        void Add(IdentityRole<int> Role);
        void Delete(IdentityRole<int> Role);
        List<IdentityRole<int>> GetAll();
        IdentityRole<int> GetById(string Id);
        void Update(IdentityRole<int> Role);
    }
}