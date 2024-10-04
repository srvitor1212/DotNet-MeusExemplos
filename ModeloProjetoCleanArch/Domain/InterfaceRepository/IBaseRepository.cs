using System.Linq.Expressions;

namespace Domain.InterfaceRepository;

public interface IBaseRepository<T> where T : BaseModel
{
    Task<IQueryable<T>> GetQueryable(Expression<Func<T, bool>>? predicate = null);

    Task Create(T entity);

    Task<T?> GetSingleById(Guid id);
}
