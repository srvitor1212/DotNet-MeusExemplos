using Domain.InterfaceRepository.Base;
using Domain.Model.Base;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Data.Repository.Base;

public abstract class CoreRepository<T> : ICoreRepository<T> where T : Core
{

    protected readonly MeuContext _context;
    protected readonly DbSet<T> _dbSet;

    protected CoreRepository(MeuContext context)
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

    public Task<T?> GetSingleById(Guid id1, Guid? id2 = null)
        => Task.FromResult(id2 is null ? _dbSet.Find(id1)
                                        : _dbSet.Find(id1, id2));

    public Task Update(T entity)
    {
        entity.SetDataAtualizacao();
        _dbSet.Update(entity);
        _context.SaveChanges();
        return Task.CompletedTask;
    }


}
