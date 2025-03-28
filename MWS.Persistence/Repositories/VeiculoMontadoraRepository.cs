using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;

namespace MWS.Persistence.Repositories
{
    public class VeiculoMontadoraRepository : BaseRepository<VeiculoMontadora>, IVeiculoMontadoraRepository
    {
        public VeiculoMontadoraRepository(AppDbContext context) : base(context)
        {
        }
    }
}
