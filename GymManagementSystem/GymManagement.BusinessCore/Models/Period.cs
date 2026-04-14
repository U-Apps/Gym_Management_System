
using System.Text.Json.Serialization;

namespace GymManagement.BusinessCore.Models
{
    public class Period : Entity<byte>
    {
        public string PeriodName { get; set; } = null!;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        [JsonIgnore]
        public virtual ICollection<Subscription> Subscriptions { get; set; }

        public Period(byte id, string periodName, TimeSpan startTime, TimeSpan endTime) : base(id)
        {
            PeriodName = periodName;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
