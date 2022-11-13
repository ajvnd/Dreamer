using Dreamer.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dreamer.Persistence;

public class DreamerContext : DbContext
{
    public Sample Sample { get; set; }
}