using GymManagement.BussinessCore.Contracts.Repositories;
using GymManagement.BussinessCore.Contracts.Services;
using GymManagement.BussinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class ExerciseTypeService : IBaseServices<ExerciseType>
    {
        protected readonly IBaseRepository<ExerciseType> _Repository;
        public ExerciseTypeService(IBaseRepository<ExerciseType> repository)
        {
            _Repository = repository;
        }
        public int Add(ExerciseType model)
        {
            _Repository.Add(model);
            return model.ExerciseTypeId;
        }

        public void AddRange(IEnumerable<ExerciseType> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(ExerciseType model)
        {
            _Repository.Delete(model);
        }

        public void DeleteById(int id)
        {
            _Repository.DeleteById(c=>c.ExerciseTypeId==id);
        }

        public void DeleteRange(IEnumerable<ExerciseType> model)
        {
            _Repository.DeleteRange(model);
        }

        public ExerciseType Find(Expression<Func<ExerciseType, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<ExerciseType> FindAll(Func<ExerciseType, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<ExerciseType> GetAll()
        {
            return _Repository.GetAll();
        }

        public ExerciseType GetById(int id)
        {
            return _Repository.GetById(c=>c.ExerciseTypeId==id);
        }

        public void Update(ExerciseType model)
        {
            _Repository.Update(model);
        }
    }
}
