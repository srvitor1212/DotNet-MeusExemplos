using Application.Abstraction;
using Application.Responses;
using Application.Responses.VinculoCarroMotorista;
using Domain.Enum;
using Domain.InterfaceRepository;

namespace Application.Services;

public class ListarVinculosCarroMotoristaService : IConsulta<OpcaoFiltroCarroMotorista, IEnumerable<ICarroMotoristaResponse>>
{

    private readonly ICarroRepository _carroRepository;

    public ListarVinculosCarroMotoristaService(ICarroRepository carroRepository)
    {
        _carroRepository = carroRepository;
    }

    public async Task<IEnumerable<ICarroMotoristaResponse>> Consultar(OpcaoFiltroCarroMotorista payload)
    {

        if (payload == OpcaoFiltroCarroMotorista.Carro)
        {
            var carros = await _carroRepository.GetCarrosWithMotoristas();
        }
            






        return RetornarVazio(payload);
    }

    private static IEnumerable<ICarroMotoristaResponse> RetornarVazio(OpcaoFiltroCarroMotorista op)
        => op == OpcaoFiltroCarroMotorista.Motorista
                 ? new List<MotoristasDoCarroResponse>()
                 : new List<CarrosDoMotoristaResponse>();

}
