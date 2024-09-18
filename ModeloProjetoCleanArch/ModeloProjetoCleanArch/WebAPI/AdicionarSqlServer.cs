using Microsoft.EntityFrameworkCore;

namespace WebAPI;

public static class AdicionarSqlServer
{
    public static IServiceCollection AplicarSqlServer(
                                        this IServiceCollection services,
                                        IConfiguration configuration)
    {
        services.AddDbContext<MeuContext>(options => 
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MeuBancoDeDados;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));


        return services;
    }
}

internal class MeuContext : DbContext
{
    public MeuContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<EntidadeExemplo> EntidadeExemplo { get; set; }
}
