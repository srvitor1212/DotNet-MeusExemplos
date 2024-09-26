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
        builder.Property(x => x.Nome)
            .IsRequired();

        builder.Property(x => x.CNPJ)
            .IsRequired();
    }
}
