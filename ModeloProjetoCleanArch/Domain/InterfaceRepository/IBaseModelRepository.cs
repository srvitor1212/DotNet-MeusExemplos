using System.Linq.Expressions;
using Domain.Model;

namespace Domain.InterfaceRepository;

public interface IBaseModelRepository<T> where T : BaseModel
{
    Task<IQueryable<T>> GetQueryable(Expression<Func<T, bool>>? predicate = null);

    Task Create(T entity);

    Task<T?> GetSingleById(Guid id);
}
