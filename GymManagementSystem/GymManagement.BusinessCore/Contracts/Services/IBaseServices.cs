using System.Linq.Expressions;

namespace GymManagement.BussinessCore.Contracts.Services
{
    public interface IBaseServices<T> where T : class
    {

        int Add(T module);
        void AddRange(IEnumerable<T> module);
        T GetById(int id);
        IEnumerable<T>GetAll();
        T Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll(Func<T, bool> predicate);
        void Delete(T module);
        void DeleteRange(IEnumerable<T> modules);
        void DeleteById(int id);
        void Update(T module);

    }

}
