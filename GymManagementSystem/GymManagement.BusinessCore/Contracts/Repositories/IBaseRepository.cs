using System.Linq.Expressions;


namespace GymManagement.BussinessCore.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entity);
        T GetById(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        T Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll(Func<T, bool> predicate);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void DeleteById(Func<T, bool> where);
        void Update(T entity);

        int SaveChanges();

        public void Dispose();

    }
}
