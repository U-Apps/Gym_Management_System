﻿using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Modules
{
    public class Member
    {
       

        public int MemberId { get; set; }
        public int PersonId { get; set; }
        public decimal? MemberWeight { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; } = null!;
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
