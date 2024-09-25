using Domain.Model.UmPraMuitos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class FabricanteConfiguration : IEntityTypeConfiguration<Fabricante>
{
    public void Configure(EntityTypeBuilder<Fabricante> builder)
    {
        // Método para configurações padrão
        builder.ConfiguracaoPadrao();

        // Propriedades das colunas
        //todo

        // Configura a FK
        builder.HasMany(x => x.Carros)
                .WithOne(x => x.Fabricante)
                .HasForeignKey(x => x.FabricanteId);
    }
}
