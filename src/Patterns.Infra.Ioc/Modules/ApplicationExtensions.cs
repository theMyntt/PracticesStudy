using Microsoft.Extensions.DependencyInjection;
using Patterns.Application.Abstractions;
using Patterns.Application.Mappers;
using Patterns.Application.UseCases.Car;

namespace Patterns.Infra.Ioc.Modules;

internal static class ApplicationExtensions
{
    internal static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICarMapper, CarMapper>();
        services.AddScoped<ICreateCarUseCase, CreateCarUseCase>();
        
        return services;
    }
}