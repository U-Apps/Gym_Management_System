using GymManagement.BusinessCore.Models;

namespace GymManagement.BusinessCore.DTOs.Mappers
{
    public static class SubsriptionMapper
    {
        public static Subscription AsSubscription(this CreateSubscriptionDTO dto)
        {
            var subscription = new Subscription();

            subscription.MemberId = dto.MemberId;
            subscription.StartDate = dto.StartDate;
            subscription.SubscriptionPeriodId = dto.SubscriptionPeriodId;
            subscription.CoachId = dto.CoachId;
            subscription.ExcerciseTypeId = dto.ExcerciseTypeId;
            subscription.PeriodId = dto.PeriodId;

            return subscription;

        }

        public static CreateSubscriptionDTO AsCreateSubscriptionDTO(this CreateSubscriptionInfo dto, int memberId)
        {
            return new CreateSubscriptionDTO()
            {
                MemberId = memberId,
                StartDate = dto.StartDate,
                SubscriptionPeriodId = dto.SubscriptionPeriodId,
                CoachId = dto.CoachId,
                ExcerciseTypeId = dto.ExcerciseTypeId,
                PeriodId = dto.PeriodId
            };
        }
    }
}
