using System.Linq.Expressions;


namespace GymManagement.BusinessCore.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entity);
        T GetById(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
       Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        Task<T> Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll(Func<T, bool> predicate);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void DeleteById(T element);
        void Update(T entity);

        Task<int> SaveChanges();

        public Task Dispose();

    }
}
