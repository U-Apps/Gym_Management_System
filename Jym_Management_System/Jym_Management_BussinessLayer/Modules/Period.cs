using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbPeriod
    {
        public TbPeriod()
        {
            TbSubscriptions = new HashSet<Subscription>();
        }

        public byte PeriodId { get; set; }
        public string PeriodName { get; set; } = null!;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public virtual ICollection<Subscription> TbSubscriptions { get; set; }
    }
}
