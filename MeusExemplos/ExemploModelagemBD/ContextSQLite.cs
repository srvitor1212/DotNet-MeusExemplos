using ExemploModelagemBD.Tabelas;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ExemploModelagemBD;
public class ContextSQLite : DbContext
{
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Pedido> Pedido { get; set; }
    public DbSet<Produto> Produto { get; set; }
    //public DbSet<ItemPedido> ItemPedido { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=DataBaseSQLIte.db");
    }

    //Aplica as configurações do Map exemplo: "PessoaMap : IEntityTypeConfiguration<Cliente>"
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
