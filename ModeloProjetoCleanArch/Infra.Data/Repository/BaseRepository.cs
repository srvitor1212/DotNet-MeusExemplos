using Domain;
using Infra.Data.Abstraction;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
{
    protected readonly MeuContext _context;
    protected readonly DbSet<T> _dbSet;

    public BaseRepository(MeuContext context, DbSet<T> dbSet)
    {
        _context = context;
        _dbSet = dbSet;
    }

    //todo: implementar métodos
}
