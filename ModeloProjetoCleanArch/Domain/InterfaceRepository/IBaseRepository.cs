using System.Linq.Expressions;

namespace Domain.InterfaceRepository;

public interface IBaseRepository<T> where T : BaseModel
{
    Task<IQueryable<T>> GetQueryable(Expression<Func<T, bool>>? predicate = null);
}
