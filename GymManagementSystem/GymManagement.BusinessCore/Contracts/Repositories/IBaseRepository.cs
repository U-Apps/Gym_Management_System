using GymManagement.BusinessCore.Models;
using System.Linq.Expressions;


namespace GymManagement.BusinessCore.Contracts.Repositories
{
    public interface IBaseRepository<TEntity, TKey> where TEntity : Entity<TKey>
    {
        TEntity? GetById(TKey id, bool track = false);
        Task<TEntity?> GetByIdAsync(TKey id, bool track = false);
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        bool IsExists(Expression<Func<TEntity, bool>> criteria);
        bool IsExists(TKey Id);
        Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> criteria);
        void Delete(TEntity entity);
        void Add(TEntity entity);
        void Update(TEntity entity);
        int SaveChanges();
        Task SaveChangesAsync();
    }
}
