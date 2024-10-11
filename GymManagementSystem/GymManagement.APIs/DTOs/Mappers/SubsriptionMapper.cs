using GymManagement.BusinessCore.Models;

namespace GymManagement.APIs.DTOs.Mappers
{
    public static class SubsriptionMapper
    {
        public static Subscription AsSubscription(this CreateSubscriptionInfo dto)
        {
            var subscription = new Subscription();

            subscription.StartDate = dto.StartDate;
            subscription.SubscriptionPeriodId = dto.SubscriptionPeriodId;
            subscription.CoachId = dto.CoachId;
            subscription.ExcerciseTypeId = dto.ExcerciseTypeId;
            subscription.PeriodId = dto.PeriodId;

            return subscription;

        }

        public static Subscription AsSubscription(this CreateSubscriptionDTO dto)
        {
            var subscription = dto.AsSubscription();
            
            subscription.MemberId = dto.MemberId;

            return subscription;
        }
    }
}
