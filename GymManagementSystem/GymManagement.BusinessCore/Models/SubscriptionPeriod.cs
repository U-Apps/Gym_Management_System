
namespace GymManagement.BusinessCore.Models
{
    public class SubscriptionPeriod
    {
       

        public byte Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte PeriodDays { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
