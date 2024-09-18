using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Connect;

public static class AdicionarSqlServer
{
    public static IServiceCollection AplicarSqlServer(this IServiceCollection services,
                                                      IConfiguration configuration)
    {
        var stringConnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MeuBancoDeDados;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        services.AddDbContext<MeuContext>(options =>
                    options.UseSqlServer(stringConnection));

        return services;
    }
}