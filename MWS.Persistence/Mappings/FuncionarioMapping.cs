using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWS.Domain.Entities;

namespace MWS.Persistence.Mappings
{
    public sealed class FuncionarioMapping : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Telefone)
               .IsRequired(false)
               .HasMaxLength(15);

            builder.HasIndex(x => x.Nome);
            builder.HasIndex(x => x.Cpf);

            builder.ToTable("Funcionarios");
        }
    }
}