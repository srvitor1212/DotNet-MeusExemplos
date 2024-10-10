using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;
using Infra.Data.Context;
using Infra.Data.Repository.Base;

namespace Infra.Data.Repository;

public class CarroMotoristaRepository : CoreRepository<CarroMotorista>, ICarroMotoristaRepository
{
    public CarroMotoristaRepository(MeuContext context) : base(context)
    {
    }
}
