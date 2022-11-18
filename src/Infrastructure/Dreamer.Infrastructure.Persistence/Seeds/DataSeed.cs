using Dreamer.Infrastructure.Persistence.Context;

namespace Dreamer.Infrastructure.Persistence.Seeds;

public static class DataSeed
{
    public static void Seed(DreamerContext context)
    {
        SampleSeed.Seed(context);
    }
}