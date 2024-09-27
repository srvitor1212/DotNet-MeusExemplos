using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Connect;

public static class AdicionarServices
{
    public static IServiceCollection AplicarServices(this IServiceCollection services)
    {
        services.AddScoped<CarrosPorDataService>();
        services.AddScoped<CarroComChassiService>();
        services.AddScoped<CarrosPorFabricante>();

        return services;
    }
}
