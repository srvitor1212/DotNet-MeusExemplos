using Domain.InterfaceRepository;
using Domain.Model.UmPraMuitos;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Data.Repository;

public class FabricanteRepository : BaseModelRepository<Fabricante>, IFabricanteRepository
{
    public FabricanteRepository(MeuContext context) : base(context)
    {
    }

    public Task<IQueryable<Fabricante>> GetQueryableWithIncludes(Expression<Func<Fabricante, bool>>? predicate = null)
    {
        var query = _dbSet.Include(x => x.Carros)
                          .AsNoTracking()
                          .AsQueryable()
                          .AsSplitQuery();

        if (predicate != null)
            query = query.Where(predicate);

        return Task.FromResult(query);
    }
}
