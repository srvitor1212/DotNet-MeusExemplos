using Domain.InterfaceRepository;
using Domain.Model;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Data.Repository.Base;

public abstract class BasePrincipalRepository<T> : 
                        IBasePrincipalRepository<T> where T : BasePrincipal
{

    protected readonly MeuContext _context;
    protected readonly DbSet<T> _dbSet;

    protected BasePrincipalRepository(MeuContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public Task Create(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
        return Task.CompletedTask;
    }

    public Task<IQueryable<T>> GetQueryable(Expression<Func<T, bool>>? predicate = null)
    {
        var query = _dbSet.AsNoTracking();

        if (predicate != null)
            query = query.Where(predicate);

        return Task.FromResult(query);
    }


}
