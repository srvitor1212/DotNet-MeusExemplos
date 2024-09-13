using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;
public static class EntidadeBaseConfiguration
{
    public static void ConfiguracaoPadrao<T>(this EntityTypeBuilder<T> builder) where T : EntidadeBase
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.DataCriacao).IsRequired();
        builder.Property(x => x.DataAtualizacao);
    }
}
