using Dreamer.Domain;
using Dreamer.Domain.Repository;

namespace Dreamer.Persistence.Repository;

public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
{
}