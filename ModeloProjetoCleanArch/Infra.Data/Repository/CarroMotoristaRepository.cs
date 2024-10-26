using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;
using Infra.Data.Context;
using Infra.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Data.Repository;

public class CarroMotoristaRepository : CoreRepository<CarroMotorista>, ICarroMotoristaRepository
{
    public CarroMotoristaRepository(MeuContext context) : base(context)
    {
    }

    public Task<IQueryable<CarroMotorista>> GetQueryableWithIncludes(Expression<Func<CarroMotorista, bool>>? predicate = null)
    {
        var query = _dbSet.Include(x => x.Carro)
            .Include(x => x.Motorista)
            .AsNoTracking();

        if (predicate != null)
            query = query.Where(predicate);

        return Task.FromResult(query);
    }
}
