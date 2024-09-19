using Domain.Model.UmPraUm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class ChassiConfiguration : IEntityTypeConfiguration<Chassi>
{
    public void Configure(EntityTypeBuilder<Chassi> builder)
    {
        // Método para configurações padrão
        builder.ConfiguracaoPadrao();

        // Propriedades das colunas
        builder.Property(x => x.NumeroDeSerie)
                .IsRequired();

        // Configura a FK
        builder.HasOne(x => x.Carro)
                .WithOne(x => x.Chassi)
                .HasForeignKey<Chassi>(x => x.CarroId)
                .OnDelete(DeleteBehavior.Cascade);
    }
}
