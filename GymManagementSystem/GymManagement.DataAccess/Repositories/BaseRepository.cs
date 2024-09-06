using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GymManagement.DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            
        }
        public void AddRange(IEnumerable<T> entities)
        {
           _context.AddRange(entities);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
           
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);

        }

        public void DeleteById(Func<T, bool> where)
        {
            _context.Set<T>().Remove(GetById(where));
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
           return _context.Set<T>().Find(predicate);
        }

        public IEnumerable<T> FindAll(Func<T, bool> predicate)
        {
           return _context.Set<T>().Where(predicate);

        }

        public virtual IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new AppDbContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .ToList<T>();
            }
            return list; 
            
        }

        public T GetById(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            T item;
            using (var context = new AppDbContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                item = dbQuery
                    .AsNoTracking()
                    .FirstOrDefault(where); 
            }
            return item;
        }

        public void Update(T entity)
        {
            _context.Update(entity);
         
            
        }

        public int SaveChanges()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
          _context.Dispose();
        }
    }
}
