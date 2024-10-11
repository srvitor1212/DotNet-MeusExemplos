using Application.Abstraction;
using Application.Responses;
using Application.Responses.VinculoCarroMotorista;
using Domain.Enum;
using Domain.InterfaceRepository;

namespace Application.Services;

public class ListarVinculosCarroMotoristaService : IConsulta<OpcaoFiltroCarroMotorista, ICarroMotoristaResponse>
{

    private readonly ICarroMotoristaRepository _carroMotoristaRepository;

    public ListarVinculosCarroMotoristaService(ICarroMotoristaRepository carroMotoristaRepository)
    {
        _carroMotoristaRepository = carroMotoristaRepository;
    }

    public async Task<ICarroMotoristaResponse> Consultar(OpcaoFiltroCarroMotorista payload)
    {
        var vinculos = await _carroMotoristaRepository.GetQueryable();

        if (vinculos == null)
            return RetornarVazio(payload);

        if (payload == OpcaoFiltroCarroMotorista.Carro)
        {
            var vinculosOrdenados = vinculos.OrderBy(x => x.CarroId).ToList();

            var result = new List<CarrosDoMotoristaResponse>();
            //todo retornar a lista topzera

        }
    }

    private static ICarroMotoristaResponse RetornarVazio(OpcaoFiltroCarroMotorista op)
        => op == OpcaoFiltroCarroMotorista.Motorista
                 ? new MotoristasDoCarroResponse()
                 : new CarrosDoMotoristaResponse();

}
