using LogApiTasks;
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
    {
        var id = Guid.NewGuid();
        Log.Write(id, "ClienteRepo inicio");
        var result = await _dbSet.ToListAsync();
        Log.Write(id, "ClienteRepo fim");

        return result;
    }


    public async Task InsertRange(IEnumerable<Cliente> clientes)
    {
        await _dbSet.AddRangeAsync(clientes);
        await _appDbContext.SaveChangesAsync();
    }
}
