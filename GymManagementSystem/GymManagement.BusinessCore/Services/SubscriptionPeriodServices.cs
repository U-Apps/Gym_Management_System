using GymManagement.BussinessCore.Contracts.Repositories;
using GymManagement.BussinessCore.Contracts.Services;
using GymManagement.BussinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BussinessCore.Services
{
    public class SubscriptionPeriodServices : IBaseServices<SubscriptionPeriod>
    {
        protected readonly IBaseRepository<SubscriptionPeriod> _Repository;
        public SubscriptionPeriodServices(IBaseRepository<SubscriptionPeriod> repository)
        {
            _Repository = repository;
        }

        public int Add(SubscriptionPeriod model)
        {
            _Repository.Add(model);
            return model.Id;
        }

        public void AddRange(IEnumerable<SubscriptionPeriod> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(SubscriptionPeriod model)
        {
            _Repository.Delete(model);
        }

        public void DeleteById(int id)
        {
           _Repository.DeleteById(c => c.Id == id);            
        }

        public void DeleteRange(IEnumerable<SubscriptionPeriod> model)
        {
           _Repository.DeleteRange(model);            
        }

        public SubscriptionPeriod Find(Expression<Func<SubscriptionPeriod, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<SubscriptionPeriod> FindAll(Func<SubscriptionPeriod, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<SubscriptionPeriod> GetAll()
        {
            return _Repository.GetAll();
        }

        public SubscriptionPeriod GetById(int id)
        {
            return _Repository.GetById(c => c.Id == id);
        }

        public void Update(SubscriptionPeriod model)
        {
           _Repository.Update(model);           
        }
    }
}
