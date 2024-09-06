using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class JobService : IBaseServices<Job>
    {
        protected readonly IBaseRepository<Job> _Repository;
        public JobService(IBaseRepository<Job> repository)
        {
            _Repository = repository;
        }

        public int Add(Job model)
        {
            _Repository.Add(model);
            return model.JobId;
        }

        public void AddRange(IEnumerable<Job> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(Job model)
        {
            _Repository.Delete(model);
        }
        public void DeleteById(int id)
        {
            _Repository.DeleteById(c=>c.JobId==id);
        }

        public void DeleteRange(IEnumerable<Job> model)
        {
            _Repository.DeleteRange(model);
        }

        public Job Find(Expression<Func<Job, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<Job> FindAll(Func<Job, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<Job> GetAll()
        {
            return _Repository.GetAll();
        }

        public Job GetById(int id)
        {
            return _Repository.GetById(c => c.JobId == id);

        }

        public void Update(Job model)
        {
           _Repository.Update(model);            
        }
    }

}
