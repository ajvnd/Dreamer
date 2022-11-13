using Dreamer.Domain.Entity;

namespace Dreamer.Domain.Repository;

public interface IBaseRepository<TEntity, in TKey> where TEntity : BaseEntity<TKey>
{
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(TKey id);
    Task AddAsync(TEntity entity);
    void Edit(TEntity entity);
    void Delete(TEntity entity);
}