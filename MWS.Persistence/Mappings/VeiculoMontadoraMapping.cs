using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class VeiculoMontadoraMapping : IEntityTypeConfiguration<VeiculoMontadora>
    {
        public void Configure(EntityTypeBuilder<VeiculoMontadora> builder)
        {
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(30);

            builder.HasIndex(x => x.Nome);

            builder.ToTable("VeiculosMontadoras");
        }
    }
}