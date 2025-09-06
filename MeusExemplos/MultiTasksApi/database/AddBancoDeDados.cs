using Microsoft.EntityFrameworkCore;

namespace MultiTasksApi.database;

public static class AddBancoDeDados
{

    public static IServiceCollection AdicionarSqlite(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(x =>
            x.UseSqlite($"Data Source=MultiTasksApi.DB"));

        return services;
    }

    public static IServiceCollection AdicionarRepos(this IServiceCollection services)
    {
        services.AddScoped<IClienteRepo, ClienteRepo>();

        services.AddScoped<ClienteService>();

        return services;
    }
}
