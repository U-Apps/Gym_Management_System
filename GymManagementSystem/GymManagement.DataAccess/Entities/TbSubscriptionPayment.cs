using GymManagement.DataAccess.Entities.Authentication;

namespace GymManagement.DataAccess.Entities
{
    public partial class TbSubscriptionPayment
    {
        public int? PaymentId { get; set; }
        public int? SubscriptionId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentAmount { get; set; }
        public int? CreatedByUserId { get; set; }

        public virtual AppUser? CreatedByUser { get; set; }
        public virtual TbSubscription? Subscription { get; set; }
    }
}
