using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context;

public class MeuContext : DbContext
{
    public MeuContext(DbContextOptions options) : base(options)
    {
    }
}
