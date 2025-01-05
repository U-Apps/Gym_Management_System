using AutoMapper.Execution;
using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.DTOs;
using GymManagement.BusinessCore.DTOs.Mappers;
using GymManagement.BusinessCore.Models;

namespace GymManagement.BusinessCore.Services
{
    public class SubscriptionService(ISubscriptionRepo _subscriptionRepo
                                    , IBaseRepository<SubscriptionPeriod, byte> _subscriptionPeriodRepo
                                    ,IBaseRepository<Period, byte> _periodRepo
                                    ,IBaseRepository<ExerciseType, byte> _exerciseTypeRepo)
                                    : ISubscriptionService
    {
        
        public bool AddNewSubscription(CreateSubscriptionDTO info)
        {
            var SubscriptionPeriod = _subscriptionPeriodRepo.GetById(info.SubscriptionPeriodId);
            if (SubscriptionPeriod is null)
                return false;

            var Period = _periodRepo.GetById(info.PeriodId);
            if (Period is null)
                return false;

            var exerciseType = _exerciseTypeRepo.GetById(info.ExcerciseTypeId);
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
