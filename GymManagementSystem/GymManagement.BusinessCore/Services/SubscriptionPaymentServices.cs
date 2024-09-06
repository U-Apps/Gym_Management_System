using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class SubscriptionPaymentServices : IBaseServices<SubscriptionPayment>
    {
        protected readonly IBaseRepository<SubscriptionPayment> _Repository;
        public SubscriptionPaymentServices(IBaseRepository<SubscriptionPayment> repository)
        {
            _Repository = repository;
        }

        public int Add(SubscriptionPayment model)
        {
            model.PaymentDate = DateTime.Now;
            _Repository.Add(model);
            return model.PaymentId??0;
        }

        public void AddRange(IEnumerable<SubscriptionPayment> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(SubscriptionPayment model)
        {
            _Repository.Delete(model);
        }

        public void DeleteById(int id)
        {
           _Repository.DeleteById(c => c.PaymentId == id);            
        }

        public void DeleteRange(IEnumerable<SubscriptionPayment> model)
        {
            _Repository.DeleteRange(model);
        }

        public SubscriptionPayment Find(Expression<Func<SubscriptionPayment, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<SubscriptionPayment> FindAll(Func<SubscriptionPayment, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<SubscriptionPayment> GetAll()
        {
            return _Repository.GetAll(
                    sp=>sp.CreatedByUser,
                    sp=>sp.CreatedByUser.Person,
                    sp =>sp.Subscription,
                    sp => sp.Subscription.Coach,
                    sp => sp.Subscription.Coach.Job,
                    sp => sp.Subscription.CreatedByReceptionist,
                    sp => sp.Subscription.CreatedByReceptionist.Job,
                    sp => sp.Subscription.ExcerciseType,
                    sp => sp.Subscription.Member,
                    sp => sp.Subscription.Member.Person,
                    sp => sp.Subscription.Period,
                    sp => sp.Subscription.SubscriptionPeriod
                );
        }

        public SubscriptionPayment GetById(int id)
        {
            return _Repository.GetById(
                    c => c.PaymentId == id,
                    sp => sp.CreatedByUser,
                    sp => sp.CreatedByUser.Person,
                    sp => sp.Subscription,
                    sp => sp.Subscription.Coach,
                    sp => sp.Subscription.Coach.Job,
                    sp => sp.Subscription.CreatedByReceptionist,
                    sp => sp.Subscription.CreatedByReceptionist.Job,
                    sp => sp.Subscription.ExcerciseType,
                    sp => sp.Subscription.Member,
                    sp => sp.Subscription.Member.Person,
                    sp => sp.Subscription.Period,
                    sp => sp.Subscription.SubscriptionPeriod
                    );
        }

        public void Update(SubscriptionPayment model)
        {
            _Repository.Update(model);            
        }
    }
}
