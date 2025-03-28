using Microsoft.EntityFrameworkCore;
using MWS.Domain.Entities;

namespace MWS.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecoes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioCargo> FuncionariosCargos { get; set; }
        public DbSet<OrdemServico> OrdensServicos { get; set; }
        public DbSet<OrdemServicoExecutado> OrdensServicosExecutados { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<VeiculoModelo> VeiculosModelos { get; set; }
        public DbSet<VeiculoMontadora> VeiculosMontadoras { get; set; }
    }
}
