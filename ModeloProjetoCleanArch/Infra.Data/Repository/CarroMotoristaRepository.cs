using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repository;

public class CarroMotoristaRepository : ICarroMotoristaRepository
{

    //todo: verificar a viabilidade e possibilidade de criar uma BaseConfiguration para esse tipo de tabela
    protected readonly MeuContext _context;
    protected readonly DbSet<CarroMotorista> _dbSet;

    public CarroMotoristaRepository(MeuContext context)
    {
        _context = context;
        _dbSet = _context.Set<CarroMotorista>();
    }
}
