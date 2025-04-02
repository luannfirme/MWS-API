using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(x => x.Cpf)
                .IsRequired(false)
                .HasMaxLength(14);

            builder.Property(x => x.Rg)
                .IsRequired(false)
                .HasMaxLength(14);

            builder.Property(x => x.DataNascimento)
                .IsRequired(false)
                .HasColumnType("date"); 

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.RazaoSocial)
                .IsRequired(false)
                .HasMaxLength(100);

            builder.Property(x => x.Telefone)
                .IsRequired(false)
                .HasMaxLength(15);

            builder.HasIndex(x => x.Nome);
            builder.HasIndex(x => x.Cpf);

            builder.ToTable("Clientes");
        }
    }
}