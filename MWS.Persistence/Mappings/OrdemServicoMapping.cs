using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class OrdemServicoMapping : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.Property(x => x.Codigo)
                .IsRequired()
                .HasMaxLength(6);

            builder.Property(x => x.Observacao)
                .IsRequired(false)
                .HasColumnType("text");

            builder.HasIndex(x => x.Codigo);

            builder.ToTable("OrdensServicos");
        }
    }
}