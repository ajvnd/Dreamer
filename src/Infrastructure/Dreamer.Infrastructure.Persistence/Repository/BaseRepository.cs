using Dreamer.Domain.Entity;
using Dreamer.Domain.Repository;
using Dreamer.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Dreamer.Infrastructure.Persistence.Repository;

public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
{
    private readonly DbSet<TEntity> _entities;

    protected BaseRepository(DreamerContext context)
    {
        _entities = context.Set<TEntity>();
    }

    public virtual async Task<List<TEntity>> GetAllAsync()
    {
        return await _entities.ToListAsync();
    }

    public virtual async Task<TEntity> GetByIdAsync(TKey id)
    {
        return await _entities.FindAsync(id);
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await _entities.AddAsync(entity);
    }

    public virtual void Update(TEntity entity)
    {
        _entities.Update(entity);
    }

    public virtual void Remove(TEntity entity)
    {
        _entities.Remove(entity);
    }
}