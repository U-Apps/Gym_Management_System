using System;
using System.Collections.Generic;

namespace GymManagement.DataAccess.Entities
{
    public partial class TbSubsciptionPeriod
    {
        public TbSubsciptionPeriod()
        {
            TbSubscriptions = new HashSet<TbSubscription>();
        }

        public byte Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<TbSubscription> TbSubscriptions { get; set; }
    }
}
