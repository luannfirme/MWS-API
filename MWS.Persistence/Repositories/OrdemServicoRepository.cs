using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;

namespace MWS.Persistence.Repositories
{
    public class OrdemServicoRepository : BaseRepository<OrdemServico>, IOrdemServicoRepository
    {
        public OrdemServicoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
