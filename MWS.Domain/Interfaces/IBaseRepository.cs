using MWS.Domain.Entities;
using System.Linq.Expressions;

namespace MWS.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<List<T>> Search(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        Task<T> GetById(Guid id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
    }
}
