using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Connect;

public static class AdicionarServices
{
    public static IServiceCollection AplicarServices(this IServiceCollection services)
    {
        services.AddScoped<CarrosPorData>();

        return services;
    }
}
