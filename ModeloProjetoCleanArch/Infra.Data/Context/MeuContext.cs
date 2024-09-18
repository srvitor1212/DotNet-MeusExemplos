using Domain.Model.UmPraUm;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context;

public class MeuContext : DbContext
{
    public MeuContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Categoria> Categoria { get; set; }
}
