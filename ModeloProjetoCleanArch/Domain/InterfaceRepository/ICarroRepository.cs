using Domain.Model.UmPraUm;
using System.Linq.Expressions;

namespace Domain.InterfaceRepository;

public interface ICarroRepository : IBaseRepository<Carro>
{
    Task<IQueryable<Carro>> GetCarrosWithIncludes(Expression<Func<Carro, bool>>? predicate = null);
}
