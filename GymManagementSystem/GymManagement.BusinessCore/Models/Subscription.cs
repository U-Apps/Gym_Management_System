
namespace GymManagement.BusinessCore.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public int MemberId { get; set; }
        public int CoachId { get; set; }
        public int CreatedByReceptionistId { get; set; }
        public byte ExcerciseTypeId { get; set; }
        public byte PeriodId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte SubscriptionPeriodId { get; set; }

        public virtual JobHistory Coach { get; set; } = null!;
        public virtual JobHistory CreatedByReceptionist { get; set; } = null!;
        public virtual ExerciseType ExcerciseType { get; set; } = null!;
        public virtual Member Member { get; set; } = null!;
        public virtual Period Period { get; set; } = null!;
        public virtual SubscriptionPeriod SubscriptionPeriod { get; set; } = null!;
    }
}
