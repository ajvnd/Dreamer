using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dreamer.Infrastructure;

public static class ConfigureService
{
    public static IServiceCollection Config(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.Scan(f => f.FromCallingAssembly().AddClasses().AsMatchingInterface());

        return services;
    }
}