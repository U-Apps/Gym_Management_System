using Microsoft.AspNetCore.Identity;

namespace GymManagement.DataAccess.Entities.Authentication;

public class AppUser : IdentityUser<int>
{
        public int PersonId { get; set; }
        public bool IsActive { get; set; }
        public virtual TbPerson Person { get; set; } = null!;
}
