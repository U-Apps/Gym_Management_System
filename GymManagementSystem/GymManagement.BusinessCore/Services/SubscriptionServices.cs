using GymManagement.BussinessCore.Contracts.Repositories;
using GymManagement.BussinessCore.Contracts.Services;
using GymManagement.BussinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class SubscriptionServices : IBaseServices<Subscription>
    {
        protected readonly IBaseRepository<Subscription> _Repository;
        public SubscriptionServices(IBaseRepository<Subscription> repository)
        {
            _Repository = repository;
        }
        public int Add(Subscription model)
        {
            _Repository.Add(model);
            return model.SubscriptionId; 
        }

        public void AddRange(IEnumerable<Subscription> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(Subscription model)
        {
           _Repository.Delete(model);
        }

        public void DeleteById(int id)
        {
           _Repository.DeleteById(c => c.SubscriptionId == id);            
        }

        public void DeleteRange(IEnumerable<Subscription> model)
        {
           _Repository.DeleteRange(model);
        }

        public Subscription Find(Expression<Func<Subscription, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<Subscription> FindAll(Func<Subscription, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<Subscription> GetAll()
        {
            return _Repository.GetAll(
                    s=>s.Coach,
                    s=>s.Coach.Job,
                    s=>s.CreatedByReceptionist,
                    s => s.CreatedByReceptionist.Job,
                    s =>s.ExcerciseType,
                    s=>s.Member,
                    s=>s.Member.Person,
                    s =>s.Period,
                    s=>s.SubscriptionPeriod
                );
        }

        public Subscription GetById(int id)
        {
            return _Repository.GetById(
                    c=>c.SubscriptionId==id,
                    s => s.Coach,
                    s=>s.Coach.Employee,
                    s=>s.Coach.Employee.Person,
                    s => s.Coach.Job,
                    s => s.CreatedByReceptionist,
                    s => s.CreatedByReceptionist.Job,
                    s => s.ExcerciseType,
                    s => s.Member,
                    s => s.Member.Person,
                    s => s.Period,
                    s => s.SubscriptionPeriod
                );
        }

        public void Update(Subscription model)
        {
           _Repository.Update(model);
        }
    }
}
