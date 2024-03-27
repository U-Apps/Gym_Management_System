using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Repositories
{
    internal interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Find(Func<T, bool> predicate);
        IEnumerable<T> FindAll(Func<T,bool> predicate);
        void Delete(T entity);
        void DeleteAll();
        void DeleteById(int id);
        void Update(T entity);

    }
}
