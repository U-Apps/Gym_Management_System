using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Modules 
{
    public class JobHistory
    {
      

        public int Id { get; set; }
        public byte JobId { get; set; }
        public int EmpoyeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Employee Employee { get; set; }
        public virtual Job Job { get; set; } = null!;
        public virtual ICollection<Subscription> SubscriptionCoaches { get; set; }
        public virtual ICollection<Subscription> SubscriptionCreatedByReceptionists { get; set; }
    }
}
