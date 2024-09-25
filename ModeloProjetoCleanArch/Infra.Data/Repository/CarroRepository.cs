using Domain.InterfaceRepository;
using Domain.Model.UmPraUm;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Data.Repository;

public class CarroRepository : BaseRepository<Carro>, ICarroRepository
{
    public CarroRepository(MeuContext context) : base(context)
    {
    }

    public Task<IQueryable<Carro>> GetCarrosWithIncludes(Expression<Func<Carro, bool>>? predicate = null)
    {
        var query = _dbSet.Include(x => x.Chassi)
                          .AsNoTracking()
                          .AsQueryable()
                          .AsSplitQuery();

        if (predicate != null)
            query = query.Where(predicate);

        return Task.FromResult(query);
    }
}
