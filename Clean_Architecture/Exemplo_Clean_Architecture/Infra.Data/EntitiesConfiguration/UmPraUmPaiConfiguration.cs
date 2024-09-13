using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;
public class UmPraUmPaiConfiguration : IEntityTypeConfiguration<UmPraUmPai>
{
    public void Configure(EntityTypeBuilder<UmPraUmPai> builder)
    {
        builder.ConfiguracaoPadrao();

        builder.HasOne(c => c.UmPraUmFilho)
               .WithOne(c => c.UmPraUmPai)
               .HasForeignKey<UmPraUmFilho>(c => c.UmPraUmPaiId);
    }
}
