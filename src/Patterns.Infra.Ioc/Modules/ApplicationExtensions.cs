using Microsoft.Extensions.DependencyInjection;
using Patterns.Application.Abstractions;
using Patterns.Application.Mappers;

namespace Patterns.Infra.Ioc.Modules;

internal static class ApplicationExtensions
{
    internal static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICarMapper, CarMapper>();
        
        return services;
    }
}