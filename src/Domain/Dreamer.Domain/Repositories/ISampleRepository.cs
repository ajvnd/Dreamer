using Dreamer.Domain.Entities;
using Dreamer.Domain.Repositories;

namespace Dreamer.Domain.Repository;

public interface ISampleRepository : IBaseRepository<Sample, int>
{
}