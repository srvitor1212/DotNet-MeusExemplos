using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class ContextMeuBanco : DbContext
{
    public ContextMeuBanco(DbContextOptions<ContextMeuBanco> options) : base(options)
    {
    }
}
