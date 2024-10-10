using Domain.Model.Base;
using System.Linq.Expressions;

namespace Domain.InterfaceRepository.Base;

public interface ICoreRepository<T> where T : Core
{
    Task Create(T entity);

    Task<IQueryable<T>> GetQueryable(Expression<Func<T, bool>>? predicate = null);

    Task<T?> GetSingleById(Guid id1, Guid? id2 = null);

    Task Update(T entity);

}
