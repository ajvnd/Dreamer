namespace Dreamer.Persistence.Seed;

public static class DataSeed
{
    public static void Seed(DreamerContext context)
    {
        SampleSeed.Seed(context);
    }
}