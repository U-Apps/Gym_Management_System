
namespace GymManagement.BussinessCore.Models
{
    public class Person
    {
        
        public int PersonId { get; set; }
        public string? Idcard { get; set; }
        public string Name { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Email { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Member Member { get; set; }
        public virtual AppUser? User { get; set; }
    }
}
