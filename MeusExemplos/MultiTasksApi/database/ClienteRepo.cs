using Microsoft.EntityFrameworkCore;

namespace MultiTasksApi.database;

public class ClienteRepo : IClienteRepo
{
    private readonly AppDbContext _appDbContext;
    private readonly DbSet<Cliente> _dbSet;

    public ClienteRepo(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
        _dbSet = _appDbContext.Set<Cliente>();
    }

    public async Task<IEnumerable<Cliente>> GetAllAsync()
        => await _dbSet.ToListAsync();
}
