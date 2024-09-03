using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbMember
    {
        public TbMember()
        {
            TbSubscriptions = new HashSet<TbSubscription>();
        }

        public int MemberId { get; set; }
        public int PersonId { get; set; }
        public decimal? MemberWeight { get; set; }
        public bool? IsActive { get; set; }

        public virtual TbPerson Person { get; set; } = null!;
        public virtual ICollection<TbSubscription> TbSubscriptions { get; set; }
    }
}
