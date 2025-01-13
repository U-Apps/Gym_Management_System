
using System.Text.Json.Serialization;

namespace GymManagement.BusinessCore.Models
{
    public class SubscriptionPeriod : Entity<byte>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte PeriodDays { get; set; }

        [JsonIgnore]
        public virtual ICollection<Subscription> Subscriptions { get; set; }

        public SubscriptionPeriod(byte id, string name, decimal price, byte periodDays) : base(id)
        {
            Name = name;
            Price = price;
            PeriodDays = periodDays;
        }
    }
}
