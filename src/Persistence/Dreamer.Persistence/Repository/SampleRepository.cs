using Dreamer.Domain.Entity;
using Dreamer.Domain.Repository;

namespace Dreamer.Persistence.Repository;

public class SampleRepository : BaseRepository<Sample, int>, ISampleRepository
{
    public SampleRepository(DreamerContext context) : base(context)
    {
    }
}