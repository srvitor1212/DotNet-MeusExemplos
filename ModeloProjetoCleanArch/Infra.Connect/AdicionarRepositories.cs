using Domain.InterfaceRepository;
using Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Connect;

public static class AdicionarRepositories
{
    public static IServiceCollection AplicarRepositories(this IServiceCollection services)
    {

        services.AddScoped<ICarroRepository, CarroRepository>();
        services.AddScoped<IFabricanteRepository, FabricanteRepository>();


        return services;
    }
}
