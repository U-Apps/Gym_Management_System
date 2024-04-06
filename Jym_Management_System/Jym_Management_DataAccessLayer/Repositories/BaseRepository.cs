using Jym_Management_DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Repositories
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

        public void DeleteById(int id)
        {
            _context.Set<T>().Remove(GetById(id));
        }

        public T Find(Func<T, bool> predicate)
        {
           return _context.Set<T>().Find(predicate);
        }

        public IEnumerable<T> FindAll(Func<T, bool> predicate)
        {
           return _context.Set<T>().Where(predicate);

        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
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
