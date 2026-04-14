using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using GymManagement.BusinessCore.Models;

namespace GymManagement.DataAccess.Repositories
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : Entity<TKey>
    {
        protected AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }


        public virtual List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking().ToList();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public virtual TEntity? GetById(TKey id, bool track = false)
        {
            IQueryable<TEntity> Query = _context.Set<TEntity>();

            if (!track)
            {
                Query.AsNoTracking();
            }

            return Query.FirstOrDefault(e => e.Id.Equals(id));
        }

        public virtual async Task<TEntity?> GetByIdAsync(TKey id, bool track = false)
        {
            IQueryable<TEntity> Query = _context.Set<TEntity>();

            if (!track)
            {
                Query.AsNoTracking();
            }

            return await Query.FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        public virtual bool IsExists(Expression<Func<TEntity, bool>> criteria)
        {
            return _context.Set<TEntity>().Any(criteria);
        }
        public virtual bool IsExists(TKey Id)
        {
            return IsExists(e => e.Id.Equals(Id));
        }

        public virtual async Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> criteria)
        {
            return await _context.Set<TEntity>().AnyAsync(criteria);
        }

        public async virtual Task<bool> IsExistsAsync(TKey Id)
        {
            return await IsExistsAsync(e => e.Id.Equals(Id));
        }

        public virtual void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
        public virtual void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }

        public virtual int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public virtual Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

    }
}
