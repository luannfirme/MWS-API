using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;

namespace MWS.Persistence.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
