using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Patterns.Infra.Data.Context;

namespace Patterns.Infra.Ioc.Modules;

internal static class InfrastructureExtensions
{
    private const string ConnectionString = "Server=localhost;Database=cars_db;Uid=root;Pwd=root;";

    internal static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<DatabaseContext>(options =>
        {
            options.UseMySql(
                ConnectionString, 
                ServerVersion.AutoDetect(ConnectionString), 
                mysql => mysql.MigrationsAssembly(typeof(DatabaseContext).Assembly.FullName));
        });
        
        return services;
    }
}