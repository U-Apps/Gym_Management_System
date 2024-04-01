using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbSubsciptionPeriod
    {
        public TbSubsciptionPeriod()
        {
            TbSubscriptions = new HashSet<Subscription>();
        }

        public byte Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Subscription> TbSubscriptions { get; set; }
    }
}
