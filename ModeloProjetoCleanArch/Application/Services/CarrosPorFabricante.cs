using Application.Abstraction;
using Application.Adapter;
using Application.Payloads;
using Application.Responses;
using Domain.InterfaceRepository;

namespace Application.Services;

public class CarrosPorFabricante : IConsulta<FabricantePayload, IEnumerable<CarrosPorFabricanteResponse>>
{
    private readonly IFabricanteRepository _fabricanteRepository;

    public CarrosPorFabricante(IFabricanteRepository fabricanteRepository)
    {
        _fabricanteRepository = fabricanteRepository;
    }

    public async Task<IEnumerable<CarrosPorFabricanteResponse>> Consultar(FabricantePayload payload)
    {
        var fabricantes = await _fabricanteRepository.GetQueryableWithIncludes(x => payload.FabricanteId == null ||
                                                                                    payload.FabricanteId == x.Id);

        var result = fabricantes.Select(FabricanteAdapter.ToResponse);

        return result;
    }
}
