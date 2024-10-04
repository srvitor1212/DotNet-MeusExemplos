using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;
using Infra.Data.Context;

namespace Infra.Data.Repository;

public class CarroMotoristaRepository : BaseRepository<CarroMotorista>, ICarroMotoristaRepository
{
    public CarroMotoristaRepository(MeuContext context) : base(context)
    {
    }
}
