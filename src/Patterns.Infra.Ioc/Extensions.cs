using Microsoft.Extensions.DependencyInjection;
using Patterns.Infra.Ioc.Modules;

namespace Patterns.Infra.Ioc;

public static class Extensions
{
    public static IServiceCollection AddExtensions(this IServiceCollection services)
    {
        services.AddInfrastructure();
        services.AddApplication();
        
        return services;
    }
}