using Microsoft.EntityFrameworkCore;

namespace MultiTasksApi.database;

public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}

