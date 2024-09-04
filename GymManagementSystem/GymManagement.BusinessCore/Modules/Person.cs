using System;
using System.Collections.Generic;

namespace GymManagement.BussinessCore.Modules
{
    public class Person
    {
        
        public int PersonId { get; set; }
        public string? Idcard { get; set; }
        public string Name { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
