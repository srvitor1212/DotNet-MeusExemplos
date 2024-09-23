using Domain;
using Domain.InterfaceRepository;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Data.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
{
    protected readonly MeuContext _context;
    protected readonly DbSet<T> _dbSet;

    public BaseRepository(MeuContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }


    public Task<IQueryable<T>> GetQueryable(Expression<Func<T, bool>>? predicate = null)
    {
        var query = _dbSet.AsNoTracking();

        if (predicate != null)
            query = query.Where(predicate);

        return Task.FromResult(query);
    }
}
