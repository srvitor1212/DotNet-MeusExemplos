using Domain.InterfaceRepository.Base;
using Domain.Model.MuitosPraMuitos;
using System.Linq.Expressions;

namespace Domain.InterfaceRepository;

public interface ICarroMotoristaRepository : ICoreRepository<CarroMotorista>
{
    Task<IQueryable<CarroMotorista>> GetQueryableWithIncludes(Expression<Func<CarroMotorista, bool>>? predicate = null);
}
