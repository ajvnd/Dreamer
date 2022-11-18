
using Dreamer.Domain.Entities;

namespace Dreamer.Domain.Repositories;

public interface IBaseRepository<TEntity, in TKey> where TEntity : BaseEntity<TKey>
{
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(TKey id);
    Task AddAsync(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
}