using Domain.InterfaceRepository.Base;
using Domain.Model.UmPraUm;
using System.Linq.Expressions;

namespace Domain.InterfaceRepository;

public interface ICarroRepository : IBaseModelRepository<Carro>
{
    Task<IQueryable<Carro>> GetCarrosWithIncludes(Expression<Func<Carro, bool>>? predicate = null);
}
