using Dreamer.Domain.Entity;
using Dreamer.Domain.Repository;
using Dreamer.Infrastructure.Persistence.Context;

namespace Dreamer.Infrastructure.Persistence.Repository;

public class SampleRepository : BaseRepository<Sample, int>, ISampleRepository
{
    public SampleRepository(DreamerContext context) : base(context)
    {
    }
}