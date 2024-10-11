using AutoMapper.Execution;
using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;

namespace GymManagement.BusinessCore.Services
{
    public class SubscriptionService(ISubscriptionRepo _subscriptionRepo
        ,ISubscriptionPeriodRepo _subscriptionPeriodRepo) : ISubscriptionService
    {
        
        public bool AddNewSubscription(Subscription subscription)
        {
            if ( subscription.ExcerciseTypeId == 0
                || subscription.PeriodId == 0
                || subscription.SubscriptionPeriodId == 0) 
            {
                return false;
            }

            // here must join the subscription with the user create it
            // not implemented yet .....

            subscription.StartDate = DateTime.Now;
            var SubscriptionPeriod = _subscriptionPeriodRepo.GetPeriodById(subscription.PeriodId);
            if (SubscriptionPeriod == null)
            {
                return false;
            }
            subscription.EndDate = subscription.StartDate.AddDays(SubscriptionPeriod.PeriodDays);
            _subscriptionRepo.AddNewSubscription(subscription);
            return true;
        }

    }
}
