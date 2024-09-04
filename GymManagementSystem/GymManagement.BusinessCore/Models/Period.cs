
namespace GymManagement.BussinessCore.Models
{
    public class Period
    {
      

        public byte PeriodId { get; set; }
        public string PeriodName { get; set; } = null!;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
