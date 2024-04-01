using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbJobHistory
    {
        public TbJobHistory()
        {
            TbSubscriptionCoaches = new HashSet<TbSubscription>();
            TbSubscriptionCreatedByReceptionists = new HashSet<TbSubscription>();
        }

        public int Id { get; set; }
        public byte JobId { get; set; }
        public int EmpoyeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Job Job { get; set; } = null!;
        public virtual ICollection<TbSubscription> TbSubscriptionCoaches { get; set; }
        public virtual ICollection<TbSubscription> TbSubscriptionCreatedByReceptionists { get; set; }
    }
}
