using Domain.Model.Base;
using System.Linq.Expressions;

namespace Domain.InterfaceRepository.Base;

public interface ICoreRepository<T> where T : Core
{
    Task<IQueryable<T>> GetQueryable(Expression<Func<T, bool>>? predicate = null);

    Task Create(T entity);

}
