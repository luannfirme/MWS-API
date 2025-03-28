using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;

namespace MWS.Persistence.Repositories
{
    public class VeiculoModeloRepository : BaseRepository<VeiculoModelo>, IVeiculoModeloRepository
    {
        public VeiculoModeloRepository(AppDbContext context) : base(context)
        {
        }
    }
}
