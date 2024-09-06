
using Microsoft.AspNetCore.Identity;

namespace GymManagement.BusinessCore.Models
{
    public class AppUser : IdentityUser<int>
    {
        public int PersonId { get; set; }
        public bool IsActive { get; set; }
        public virtual Person Person { get; set; } = null!;
    }
}
