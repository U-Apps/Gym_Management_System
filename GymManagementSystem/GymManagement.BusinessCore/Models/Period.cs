
using System.Text.Json.Serialization;

namespace GymManagement.BusinessCore.Models
{
    public class Period
    {
      

        public byte PeriodId { get; set; }
        public string PeriodName { get; set; } = null!;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        [JsonIgnore]
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
