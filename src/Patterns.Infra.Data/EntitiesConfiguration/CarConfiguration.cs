using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Patterns.Infra.Data.Entities;

namespace Patterns.Infra.Data.EntitiesConfiguration;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("TBL_CARROS");
        
        builder.HasKey(model => model.Id);
        builder.Property(model => model.Id).HasColumnName("ID_CARRO");

        builder.Property(model => model.Corp).HasColumnName("TX_MARCA");
        builder.Property(model => model.Corp).IsRequired();
        
        builder.Property(model => model.Model).HasColumnName("TX_MODELO");
        builder.Property(model => model.Model).IsRequired();
        
        builder.Property(model => model.CreatedAt).HasColumnName("TX_CRIADO_EM");
        builder.Property(model => model.CreatedAt).IsRequired();
        
        builder.Property(model => model.UpdatedAt).HasColumnName("TX_ATUALIZADO_EM");
    }
}