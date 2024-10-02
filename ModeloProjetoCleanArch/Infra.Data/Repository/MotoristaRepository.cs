using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;
using Infra.Data.Context;

namespace Infra.Data.Repository;

public class MotoristaRepository : BaseRepository<Motorista>, IMotoristaRepository
{
    public MotoristaRepository(MeuContext context) : base(context)
    {
    }
}
