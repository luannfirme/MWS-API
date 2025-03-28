﻿using Microsoft.EntityFrameworkCore;
using MWS.Domain.Entities;
using MWS.Domain.Interfaces;
using MWS.Persistence.Context;
using System.Linq.Expressions;

namespace MWS.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> Buscar(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().AsNoTracking().Where(predicate).ToListAsync(cancellationToken);
        }

        public void Editar(T entity)
        {
            _context.Update(entity);
        }

        public void Excluir(T entity)
        {
            _context.Remove(entity);
        }

        public void Incluir(T entity)
        {
            _context.Add(entity);
        }

        public async Task<T> ObterPorId(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(t => t.Id == id, cancellationToken);
        }

        public async Task<List<T>> ObterTodos(CancellationToken cancellationToken)
        {
            return await _context.Set<T>().ToListAsync(cancellationToken);
        }
    }
}
