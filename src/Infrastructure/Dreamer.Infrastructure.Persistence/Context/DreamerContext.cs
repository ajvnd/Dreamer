using Dreamer.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dreamer.Infrastructure.Persistence.Context;

public class DreamerContext : DbContext
{
    public virtual DbSet<Sample> Samples { get; set; }
}