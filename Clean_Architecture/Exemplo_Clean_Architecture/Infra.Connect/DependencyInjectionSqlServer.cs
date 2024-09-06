using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Connect;

public static class DependencyInjectionSqlServer
{
    public static IServiceCollection AdicionarSqlServer(this IServiceCollection services,
                                                           IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ContextMeuBanco>(options => options.UseSqlServer(connectionString));

        return services;
    }
}
