using Microsoft.EntityFrameworkCore;

namespace MinimalApi;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> options) : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}
