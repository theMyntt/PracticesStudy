using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Patterns.Infra.Data.Entities;

namespace Patterns.Infra.Data.EntitiesConfiguration;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(model => model.Id);

        builder.Property(model => model.Corp).IsRequired();
        builder.Property(model => model.Model).IsRequired();
        builder.Property(model => model.CreatedAt).IsRequired();
    }
}