namespace Dreamer.Domain.Entity;

public abstract class BaseEntity<TKey>
{
    public TKey Id { get; set; }
}