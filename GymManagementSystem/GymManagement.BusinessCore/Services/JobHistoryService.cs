using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class JobHistoryService : IBaseServices<JobHistory>
    {
        protected readonly IBaseRepository<JobHistory> _Repository;
        public JobHistoryService(IBaseRepository<JobHistory> repository)
        {
            _Repository = repository;
        }
        public int Add(JobHistory model)
        {
            _Repository.Add(model);
            return model.Id;
        }

        public void AddRange(IEnumerable<JobHistory> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(JobHistory model)
        {
            _Repository.Delete(model);
        }

        public void DeleteById(int id)
        {
            _Repository.DeleteById(c=>c.Id==id);
        }

        public void DeleteRange(IEnumerable<JobHistory> model)
        {
            _Repository.DeleteRange(model);
        }

        public JobHistory Find(Expression<Func<JobHistory, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<JobHistory> FindAll(Func<JobHistory, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<JobHistory> GetAll()
        {
            return _Repository.GetAll(jH => jH.Job, jH => jH.Employee/*, jH => jH.Employee.Person*/);
        }

        public JobHistory GetById(int id)
        {
            return _Repository.GetById(c=>c.Id==id, jH => jH.Job,jH=>jH.Employee/*,jH=>jH.Employee.Person*/);
        }

        public void Update(JobHistory module)
        {
            _Repository.Update(module);
        }
    }
}
