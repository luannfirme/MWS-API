using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class ServicoMapping : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.Property(x => x.Codigo)
                .IsRequired()
                .HasMaxLength(6);

            builder.Property(x => x.Descricao)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.HasIndex(x => x.Codigo);

            builder.ToTable("Servicos");
        }
    }
}