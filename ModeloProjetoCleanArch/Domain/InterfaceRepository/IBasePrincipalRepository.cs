using Domain.Model;
using System.Linq.Expressions;

namespace Domain.InterfaceRepository;

 public interface IBasePrincipalRepository<T> where T : BasePrincipal
{
    Task<IQueryable<T>> GetQueryable(Expression<Func<T, bool>>? predicate = null);

    Task Create(T entity);

}
