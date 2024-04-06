using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entity);
        T GetById(int id);
      IEnumerable<T> GetAll();
       T Find(Func<T, bool> predicate);
        IEnumerable<T> FindAll(Func<T,bool> predicate);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void DeleteById(int id);
        void Update(T entity);

        int SaveChanges();

        public void Dispose();

    }
}
