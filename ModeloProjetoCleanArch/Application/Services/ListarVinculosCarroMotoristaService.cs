using Application.Abstraction;
using Application.Responses;
using Application.Responses.VinculoCarroMotorista;
using Domain.Enum;
using Domain.InterfaceRepository;

namespace Application.Services;

public class ListarVinculosCarroMotoristaService : IConsulta<OpcaoFiltroCarroMotorista, IEnumerable<ICarroMotoristaResponse>>
{

    private readonly ICarroMotoristaRepository _carroMotoristaRepository;

    public ListarVinculosCarroMotoristaService(ICarroMotoristaRepository carroMotoristaRepository)
    {
        _carroMotoristaRepository = carroMotoristaRepository;
    }

    public async Task<IEnumerable<ICarroMotoristaResponse>> Consultar(OpcaoFiltroCarroMotorista payload)
    {
        var vinculos = await _carroMotoristaRepository.GetQueryable();

        if (vinculos == null)
            return RetornarVazio(payload);

        if (payload == OpcaoFiltroCarroMotorista.Carro)
        {
            var vinculosPorCarro = vinculos.GroupBy(x => x.CarroId)
                                           .Select(c => new CarrosDoMotoristaResponse 
                                           { 
                                               Carros = c.Key,
                                               Motoristas = c.Select(m => m.MotoristaId).ToList()
                                           }).Cast<ICarroMotoristaResponse>().ToList(); //todo com erro

            return await Task.FromResult(vinculosPorCarro);
        }

        
        
        
        
        
        
        return RetornarVazio(payload);
    }

    private static IEnumerable<ICarroMotoristaResponse> RetornarVazio(OpcaoFiltroCarroMotorista op)
        => op == OpcaoFiltroCarroMotorista.Motorista
                 ? new List<MotoristasDoCarroResponse>()
                 : new List<CarrosDoMotoristaResponse>();

}
