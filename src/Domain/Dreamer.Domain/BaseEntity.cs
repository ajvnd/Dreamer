namespace Dreamer.Domain;

public abstract class BaseEntity<TKEY>
{
    public TKEY Id { get; set; }
}