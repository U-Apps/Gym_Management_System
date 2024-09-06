using GymManagement.BussinessCore.Contracts.Repositories;
using GymManagement.BussinessCore.Contracts.Services;
using GymManagement.BussinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class PeriodService : IBaseServices<Period>
    {
        protected readonly IBaseRepository<Period> _Repository;
        public PeriodService(IBaseRepository<Period> repository)
        {
            _Repository = repository;
        }

        public int Add(Period model)
        {
            _Repository.Add(model);
            return model.PeriodId;
        }

        public void AddRange(IEnumerable<Period> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(Period model)
        {
            _Repository.Delete(model);
        }

        public void DeleteById(int id)
        {
            _Repository.DeleteById(c => c.PeriodId == id);            
        }

        public void DeleteRange(IEnumerable<Period> model)
        {
            _Repository.DeleteRange(model);            
        }

        public Period Find(Expression<Func<Period, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<Period> FindAll(Func<Period, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<Period> GetAll()
        {
            return _Repository.GetAll();
        }

        public Period GetById(int id)
        {
            return _Repository.GetById(c => c.PeriodId == id);
        }

        public void Update(Period model)
        {
           _Repository.Update(model);
        }
    }
}
