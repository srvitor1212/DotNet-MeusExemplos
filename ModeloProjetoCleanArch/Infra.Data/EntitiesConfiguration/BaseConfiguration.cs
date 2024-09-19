using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public static class BaseConfiguration
{
    public static void ConfiguracaoPadrao<T>(this EntityTypeBuilder<T> builder) where T : BaseModel
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.DataCriacao).IsRequired();
        builder.Property(x => x.DataAtualizacao);
    }
}
