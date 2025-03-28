using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;

namespace MWS.Persistence.Repositories
{
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
