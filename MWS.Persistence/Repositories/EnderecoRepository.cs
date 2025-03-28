using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;

namespace MWS.Persistence.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
