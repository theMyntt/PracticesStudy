using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Patterns.Infra.Ioc.Modules;

namespace Patterns.Infra.Ioc;

public static class Extensions
{
    public static IServiceCollection AddExtensions(this IServiceCollection services)
    {
        services.AddInfrastructure();
        
        return services;
    }
}