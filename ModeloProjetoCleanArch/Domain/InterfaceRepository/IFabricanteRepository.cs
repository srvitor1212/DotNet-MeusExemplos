using Domain.Model.UmPraMuitos;
using System.Linq.Expressions;

namespace Domain.InterfaceRepository;

public interface IFabricanteRepository : IBaseRepository<Fabricante>
{
    Task<IQueryable<Fabricante>> GetQueryableWithIncludes(Expression<Func<Fabricante, bool>>? predicate = null);
}
