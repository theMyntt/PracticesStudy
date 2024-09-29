using Microsoft.EntityFrameworkCore;
using Patterns.Infra.Data.Entities;

namespace Patterns.Infra.Data.Context;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options) { }
    
    public DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
}