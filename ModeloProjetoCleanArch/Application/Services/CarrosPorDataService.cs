using Application.Abstraction;
using Application.Adapter;
using Application.Payloads;
using Application.Responses;
using Domain.InterfaceRepository;

namespace Application.Services;

public class CarrosPorDataService : IConsulta<UmPraUmPayload, IEnumerable<UmPraUmResponse>>
{
    private readonly ICarroRepository _carroRepository;

    public CarrosPorDataService(ICarroRepository carroRepository)
    {
        _carroRepository = carroRepository;
    }

    public async Task<IEnumerable<UmPraUmResponse>> Consultar(UmPraUmPayload payload)
    {
        var carros = await _carroRepository.GetQueryable(x => x.DataCriacao > payload.dataCadastroInicial
                                                           && x.DataCriacao < payload.dataFinalInicial);

        var result = carros.Select(CarroAdapter.ToResponse).ToList();

        if (result.Count == 0)
            return await Task.FromResult(new List<UmPraUmResponse>());

        return await Task.FromResult(result);
    }
}
