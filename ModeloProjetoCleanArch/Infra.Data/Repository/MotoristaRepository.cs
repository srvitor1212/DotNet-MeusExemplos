using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;
using Infra.Data.Context;
using Infra.Data.Repository.Base;

namespace Infra.Data.Repository;

public class MotoristaRepository : BaseModelRepository<Motorista>, IMotoristaRepository
{
    public MotoristaRepository(MeuContext context) : base(context) { }
}
