using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;
using Infra.Data.Context;
using Infra.Data.Repository.Base;

namespace Infra.Data.Repository;

public class CarroMotoristaRepository : CoreRepository<CarroMotorista>, ICarroMotoristaRepository
{

    //todo: verificar a viabilidade e possibilidade de criar uma BaseConfiguration para esse tipo de tabela
    public CarroMotoristaRepository(MeuContext context) : base(context)
    {
    }
}
