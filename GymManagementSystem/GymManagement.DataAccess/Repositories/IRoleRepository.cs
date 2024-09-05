using Microsoft.AspNetCore.Identity;

namespace Jym_Management_DataAccessLayer.Repositories
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