using Microsoft.AspNetCore.Identity;

namespace Jym_Management_DataAccessLayer.Entities.Authentication;

public class AppUser : IdentityUser
{
        public int PersonId { get; set; }
        public bool IsActive { get; set; }
        public virtual TbPerson Person { get; set; } = null!;
}
