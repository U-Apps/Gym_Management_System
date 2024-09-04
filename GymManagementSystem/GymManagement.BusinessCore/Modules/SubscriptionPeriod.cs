using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Modules
{
    public class SubscriptionPeriod
    {
       

        public byte Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
