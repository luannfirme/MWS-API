using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;
using MWS.Persistence.Repositories;

namespace MWS.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurarPersistencias(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MySql");
            services.AddDbContext<AppDbContext>(opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFuncionarioCargoRepository, FuncionarioCargoRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IOrdemServicoExecutadoRepository, OrdemServicoExecutadoRepository>();
            services.AddScoped<IOrdemServicoRepository, OrdemServicoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IServicoRepository, ServicoRepository>();
            services.AddScoped<IVeiculoModeloRepository, VeiculoModeloRepository>();
            services.AddScoped<IVeiculoMontadoraRepository, VeiculoMontadoraRepository>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
        }
    }
}
