using AutoMapper.Execution;
using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.DTOs;
using GymManagement.BusinessCore.DTOs.Mappers;
using GymManagement.BusinessCore.Models;

namespace GymManagement.BusinessCore.Services
{
    public class SubscriptionService(ISubscriptionRepo _subscriptionRepo
                                    ,ISubscriptionPeriodRepo _subscriptionPeriodRepo
                                    ,IPeriodRepo _periodRepo
                                    ,IExerciseTypeRepo _exerciseTypeRepo)
                                    : ISubscriptionService
    {
        
        public bool AddNewSubscription(CreateSubscriptionDTO info)
        {
            var SubscriptionPeriod = _subscriptionPeriodRepo.GetPeriodById(info.SubscriptionPeriodId);
            if (SubscriptionPeriod is null)
                return false;

            var Period = _periodRepo.GetPeriodById(info.PeriodId);
            if (Period is null)
                return false;

            var exerciseType = _exerciseTypeRepo.GetTypeById(info.PeriodId);
            if (exerciseType is null)
                return false;

            var subscription = info.AsSubscription();

            // here must join the subscription with the user create it
            // not implemented yet .....

            subscription.EndDate = subscription.StartDate.AddDays(SubscriptionPeriod.PeriodDays);
            _subscriptionRepo.AddNewSubscription(subscription);
            return true;
        }

    }
}
