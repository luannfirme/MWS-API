﻿using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;

namespace MWS.Persistence.Repositories
{
    public class ServicoRepository : BaseRepository<Servico>, IServicoRepository
    {
        public ServicoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
