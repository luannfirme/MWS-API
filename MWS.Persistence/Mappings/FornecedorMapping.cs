using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.Property(x => x.Cnpj)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(x => x.RazaoSocial)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.NomeFantasia)
               .IsRequired()
               .HasMaxLength(50);

            builder.Property(x => x.Contato)
              .IsRequired(false)
              .HasMaxLength(50);

            builder.Property(x => x.Email)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.HasIndex(x => x.Cnpj);

            builder.ToTable("Fornecedores");
        }
    }
}