using System.Linq.Expressions;


namespace GymManagement.BusinessCore.Contracts.Repositories
{
    public interface IBaseRepository<TEntity, TKey> where TEntity : class
    {
        TEntity? GetById(TKey id);
        Task<TEntity?> GetByIdAsync(TKey id);
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
        //int SaveChanges();
        //Task<int> SaveChangesAsync();
    }
}
