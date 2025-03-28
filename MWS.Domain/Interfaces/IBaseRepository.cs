using MWS.Domain.Entities;
using System.Linq.Expressions;

namespace MWS.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Incluir(T entity);
        void Excluir(T entity);
        void Editar(T entity);
        Task<List<T>> Buscar(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        Task<T> ObterPorId(Guid id, CancellationToken cancellationToken);
        Task<List<T>> ObterTodos(CancellationToken cancellationToken);
    }
}
