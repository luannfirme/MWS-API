using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class VeiculoModeloMapping : IEntityTypeConfiguration<VeiculoModelo>
    {
        public void Configure(EntityTypeBuilder<VeiculoModelo> builder)
        {
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(30);

            builder.HasIndex(x => x.Nome);

            builder.ToTable("VeiculosModelos");
        }
    }
}