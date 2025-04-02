using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class FuncionarioCargoMapping : IEntityTypeConfiguration<FuncionarioCargo>
    {
        public void Configure(EntityTypeBuilder<FuncionarioCargo> builder)
        {
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(30);

            builder.HasIndex(x => x.Nome);

            builder.ToTable("FuncionariosCargos");
        }
    }
}