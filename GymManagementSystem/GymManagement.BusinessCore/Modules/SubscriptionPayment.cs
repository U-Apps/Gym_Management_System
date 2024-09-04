using System;
using System.Collections.Generic;

namespace GymManagement.BussinessCore.Modules
{
    public class SubscriptionPayment
    {
        public int? PaymentId { get; set; }
        public int? SubscriptionId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentAmount { get; set; }
        public short? CreatedByUserId { get; set; }

        public virtual User? CreatedByUser { get; set; }
        public virtual Subscription? Subscription { get; set; }
    }
}
