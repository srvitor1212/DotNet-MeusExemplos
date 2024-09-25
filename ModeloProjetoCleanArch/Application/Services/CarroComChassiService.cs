using Application.Abstraction;
using Application.Adapter;
using Application.Payloads;
using Application.Responses;
using Domain.InterfaceRepository;

namespace Application.Services;

public class CarroComChassiService : IConsulta<CarrosPayload, IEnumerable<CarroChassiResponse>>
{
    private readonly ICarroRepository _carroRepository;

    public CarroComChassiService(ICarroRepository carroRepository)
    {
        _carroRepository = carroRepository;
    }

    public async Task<IEnumerable<CarroChassiResponse>> Consultar(CarrosPayload payload)
    {
        var carros = await _carroRepository.GetCarrosWithIncludes(x => x.DataCriacao >= payload.dataCadastroInicial &&
                                                                 x.DataCriacao <= payload.dataCadastroFinal);

        var result = carros.Select(CarroAdapter.ToResponseCarroChassi).ToList();

        if (result.Count == 0)
            return await Task.FromResult(new List<CarroChassiResponse>());

        return await Task.FromResult(result);
    }
}
