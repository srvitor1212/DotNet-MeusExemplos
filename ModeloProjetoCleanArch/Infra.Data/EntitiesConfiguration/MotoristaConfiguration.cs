using Domain.Model.MuitosPraMuitos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class MotoristaConfiguration : IEntityTypeConfiguration<Motorista>
{
    public void Configure(EntityTypeBuilder<Motorista> builder)
    {
        // Método para configurações padrão
        builder.ConfiguracaoPadrao();

        // Propriedades das colunas
        builder.Property(x => x.Nome)
            .IsRequired();

        builder.Property(x => x.SituacaoCarteiraMotorista)
            .IsRequired();

        builder.Property(x => x.TipoCarteira)
            .IsRequired();
    }
}
