using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;

namespace MWS.Persistence.Repositories
{
    public class OrdemServicoExecutadoRepository : BaseRepository<OrdemServicoExecutado>, IOrdemServicoExecutadoRepository
    {
        public OrdemServicoExecutadoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
