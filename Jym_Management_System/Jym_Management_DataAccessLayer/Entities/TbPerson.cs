using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbPerson
    {
        public TbPerson()
        {
            TbEmployees = new HashSet<TbEmployee>();
            TbMembers = new HashSet<TbMember>();
            TbUsers = new HashSet<TbUser>();
        }

        public int PersonId { get; set; }
        public string? Idcard { get; set; }
        public string Name { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
        public virtual ICollection<TbMember> TbMembers { get; set; }
        public virtual ICollection<TbUser> TbUsers { get; set; }
    }
}
