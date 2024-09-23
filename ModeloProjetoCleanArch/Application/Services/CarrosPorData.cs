using Application.Abstraction;
using Application.Payloads;
using Application.Responses;
using Domain.InterfaceRepository;

namespace Application.Services;

public class CarrosPorData : IConsulta<UmPraUmPayload, UmPraUmResponse>
{
    private readonly ICarroRepository _carroRepository;

    public CarrosPorData(ICarroRepository carroRepository)
    {
        _carroRepository = carroRepository;
    }

    public async Task<UmPraUmResponse> Consultar(UmPraUmPayload payload)
    {
        var carros = await _carroRepository.GetQueryable(); //todo filtrar por dara inicial e final

        if (carros == null)
            return await Task.FromResult(new UmPraUmResponse());

        return await Task.FromResult(new UmPraUmResponse());
    }
}
