using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(x => x.Rua)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Numero)
                .IsRequired(false)
                .HasMaxLength(4);

            builder.Property(x => x.Complemento)
               .IsRequired(false)
               .HasMaxLength(30);

            builder.Property(x => x.Cep)
              .IsRequired(false)
              .HasMaxLength(10);

            builder.Property(x => x.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Cidade)
               .IsRequired()
               .HasMaxLength(50);

            builder.Property(x => x.Estado)
               .IsRequired()
               .HasMaxLength(30);

            builder.HasIndex(x => x.Cep);

            builder.ToTable("Enderecos");
        }
    }
}