
namespace GymManagement.BussinessCore.Models
{
    public class SubscriptionPeriod
    {
       

        public byte Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
