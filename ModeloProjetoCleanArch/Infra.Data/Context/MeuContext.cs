using Domain.Model.MuitosPraMuitos;
using Domain.Model.UmPraMuitos;
using Domain.Model.UmPraUm;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context;

public class MeuContext : DbContext
{
    public MeuContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Carro> Carro {  get; set; }
    public DbSet<Chassi> Chassi { get; set; }
    public DbSet<Fabricante> Fabricante { get; set; }
    public DbSet<Motorista> Motorista { get; set; }
    public DbSet<CarroMotorista> CarroMotorista { get; set; }
}
