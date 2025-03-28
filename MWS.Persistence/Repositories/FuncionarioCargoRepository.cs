using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;

namespace MWS.Persistence.Repositories
{
    public class FuncionarioCargoRepository : BaseRepository<FuncionarioCargo>, IFuncionarioCargoRepository
    {
        public FuncionarioCargoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
