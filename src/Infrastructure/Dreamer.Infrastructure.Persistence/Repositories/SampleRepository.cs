using Dreamer.Domain.Entities;
using Dreamer.Domain.Repository;
using Dreamer.Infrastructure.Persistence.Context;

namespace Dreamer.Infrastructure.Persistence.Repositories;

public class SampleRepository : BaseRepository<Sample, int>, ISampleRepository
{
    public SampleRepository(DreamerContext context) : base(context)
    {
    }
}