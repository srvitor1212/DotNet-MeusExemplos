using Domain.InterfaceRepository;
using Domain.Model.UmPraUm;
using Infra.Data.Context;

namespace Infra.Data.Repository;

public class CarroRepository : BaseRepository<Carro>, ICarroRepository
{
    public CarroRepository(MeuContext context) : base(context)
    {
    }
}
