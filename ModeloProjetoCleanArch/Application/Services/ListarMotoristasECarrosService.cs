using Application.Abstraction;
using Application.Adapter;
using Application.Responses;
using Domain.InterfaceRepository;

namespace Application.Services;

public class ListarMotoristasECarrosService : IConsulta<MotoristasECarrosResponse>
{

    private readonly ICarroRepository _carroRepository;
    private readonly IMotoristaRepository _motoristaRepository;

    public ListarMotoristasECarrosService(ICarroRepository carroRepository, IMotoristaRepository motoristaRepository)
    {
        _carroRepository = carroRepository;
        _motoristaRepository = motoristaRepository;
    }

    public async Task<MotoristasECarrosResponse> Consultar()
    {
        var result = new MotoristasECarrosResponse();

        var carros = await _carroRepository.GetQueryable();

        if (carros != null)
            result.Carros = carros.Select(CarroAdapter.ToCarros).ToList();

        var motoristas = await _motoristaRepository.GetQueryable();

        if (motoristas != null)
            result.Motoristas = motoristas.Select(MotoristaAdapter.ToMotoristas).ToList();

        return result;
    }
}
