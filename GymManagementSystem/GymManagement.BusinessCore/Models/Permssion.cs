
namespace GymManagement.BussinessCore.Models
{
    public class Permssion
    {
        
        public byte Id { get; set; }
        public string? Name { get; set; }
        public byte? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<AppUser> Users { get; set; }
    }
}
