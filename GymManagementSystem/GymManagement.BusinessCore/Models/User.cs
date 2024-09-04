
namespace GymManagement.BussinessCore.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonId { get; set; }
        public bool IsActive { get; set; }
        public virtual Person Person { get; set; } = null!;
    }
}
