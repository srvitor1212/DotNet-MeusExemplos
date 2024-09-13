using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;
public class UmPraUmFilhoConfiguration : IEntityTypeConfiguration<UmPraUmFilho>
{
    public void Configure(EntityTypeBuilder<UmPraUmFilho> builder)
    {
        builder.ConfiguracaoPadrao();

        builder.HasOne(c => c.UmPraUmPai)
               .WithOne(c => c.UmPraUmFilho)
               .HasForeignKey<UmPraUmFilho>(c => c.UmPraUmPaiId);
    }
}
