using AutoMapper.Execution;
using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;

namespace GymManagement.BusinessCore.Services
{
    public class SubscriptionService(ISubscriptionRepo _subscriptionRepo
                                    ,ISubscriptionPeriodRepo _subscriptionPeriodRepo
                                    ,IPeriodRepo _periodRepo
                                    ,IExerciseTypeRepo _exerciseTypeRepo)
                                    : ISubscriptionService
    {
        
        public bool AddNewSubscription(Subscription subscription)
        {
            var SubscriptionPeriod = _subscriptionPeriodRepo.GetPeriodById(subscription.SubscriptionPeriodId);
            if (SubscriptionPeriod is null)
                return false;

            var Period = _periodRepo.GetPeriodById(subscription.PeriodId);
            if (Period is null)
                return false;

            var exerciseType = _exerciseTypeRepo.GetTypeById(subscription.PeriodId);
            if (exerciseType is null)
                return false;



            // here must join the subscription with the user create it
            // not implemented yet .....

            subscription.StartDate = DateTime.Now;
            subscription.EndDate = subscription.StartDate.AddDays(SubscriptionPeriod.PeriodDays);
            _subscriptionRepo.AddNewSubscription(subscription);
            return true;
        }

    }
}
