using GymManagement.BusinessCore.Models;
using System;
using System.Collections.Generic;

namespace GymManagement.DataAccess.Entities
{
    public partial class TbPerson
    {
        public TbPerson()
        {
            //TbEmployees = new HashSet<TbEmployee>();
            //TbMembers = new HashSet<TbMember>();
            //User = new HashSet<TbUser>();
        }

        public int PersonId { get; set; }
        public string? Idcard { get; set; }
        public string Name { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Email { get; set; }

        public virtual TbEmployee Employee { get; set; }
        public virtual TbMember Member { get; set; }
        public virtual AppUser? User { get; set; }
    }
}
