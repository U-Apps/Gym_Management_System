using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GymManagement.DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            
        }
        public async Task AddRange(IEnumerable<T> entities)
        {
          await _context.Set<T>().AddRangeAsync(entities);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
           
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);

        }

        public void DeleteById(T element)
        {
            _context.Set<T>().Remove(element);
        }

        public async Task<T> Find(Expression<Func<T, bool>> predicate)
        {
           return await _context.Set<T>().FindAsync(predicate);
        }

        public IEnumerable<T> FindAll(Func<T, bool> predicate)
        {
           return _context.Set<T>().Where(predicate);

        }

        public virtual async Task <IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new AppDbContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = await dbQuery
                    .AsNoTracking()
                    .ToListAsync<T>();
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

                item =  dbQuery
                    .AsNoTracking()
                    .FirstOrDefault<T>(where); 
            }
            return item;
        }

        public void Update(T entity)
        {
            _context.Update(entity);
         
            
        }

        public async Task<int> SaveChanges()
        {
           return await _context.SaveChangesAsync();
        }

        public async Task Dispose()
        {
          await _context.DisposeAsync();
        }
    }
}
