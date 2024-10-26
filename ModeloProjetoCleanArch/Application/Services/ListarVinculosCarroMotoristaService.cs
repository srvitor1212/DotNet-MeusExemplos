using Application.Abstraction;
using Application.Adapter;
using Application.Responses;
using Domain.InterfaceRepository;

namespace Application.Services;

public class ListarVinculosCarroMotoristaService : IConsulta<Guid?, IEnumerable<CarrosDoMotoristaResponse>>
{

    private readonly ICarroMotoristaRepository _carroMotoristaRepository;

    public ListarVinculosCarroMotoristaService(ICarroMotoristaRepository carroMotoristaRepository)
    {
        _carroMotoristaRepository = carroMotoristaRepository;
    }

    public async Task<IEnumerable<CarrosDoMotoristaResponse>> Consultar(Guid? MotoristaId)
    {
        var vinculos = await _carroMotoristaRepository.GetQueryableWithIncludes(x
            => MotoristaId == null
                || MotoristaId == Guid.Empty
                || MotoristaId == x.MotoristaId);

        if (vinculos == null)
            return new List<CarrosDoMotoristaResponse>();

        var result = CarroMotoristaAdapter.ToCarrosDoMotoristaResponse(vinculos);

        return result;
    }
}
