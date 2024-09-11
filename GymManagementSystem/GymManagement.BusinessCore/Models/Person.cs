
namespace GymManagement.BusinessCore.Models
{
    public abstract class Person
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
        

        //public Person()
        //{
        //    Id = -1;
        //    FirstName = SecondName = ThirdName = LastName = "Unknown";
        //    RegisterationDate = DateTime.Now;
        //    NationalNumber = PhoneNumber = Email = Address = null;
        //    BirthDate = null;
        //}

        //public Person(int id, string firstName, string secondName,
        //    string thirdName, string lastName, string? nationalNumber,
        //    string? phoneNumber, DateTime? birthDate, string? email, string? address, DateTime registerationDate)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    SecondName = secondName;
        //    ThirdName = thirdName;
        //    LastName = lastName;
        //    NationalNumber = nationalNumber;
        //    PhoneNumber = phoneNumber;
        //    BirthDate = birthDate;
        //    Email = email;
        //    Address = address;
        //    RegisterationDate = registerationDate;
        //}
    }
}
