
namespace GymManagement.BusinessCore.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string SecondName { get; set; } = null!;
        public string ThirdName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? NationalNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime RegisterationDate { get; set; }
        

        
    }
}
