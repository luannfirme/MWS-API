using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.Property(x => x.Placa)
                .IsRequired()
                .HasMaxLength(10);

            builder.HasIndex(x => x.Placa);

            builder.ToTable("Veiculos");
        }
    }
}