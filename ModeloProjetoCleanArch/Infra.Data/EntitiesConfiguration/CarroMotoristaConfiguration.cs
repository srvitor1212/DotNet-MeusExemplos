using Domain.Model.MuitosPraMuitos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class CarroMotoristaConfiguration : IEntityTypeConfiguration<CarroMotorista>
{
    public void Configure(EntityTypeBuilder<CarroMotorista> builder)
    {
        // Método para configurações padrão
        builder.ConfiguracaoPadrao();

        // Propriedades das colunas
        builder.Property(x => x.CarroId)
            .IsRequired();

        builder.Property(x => x.MotoristaId)
            .IsRequired();

        
        // N:N - MUITOS carros pra MUITOS motoristas
        builder.HasOne(x => x.Carro)
            .WithMany(x => x.CarroMotorista)
            .HasForeignKey(x => x.CarroId);

        builder.HasOne(x => x.Motorista)
            .WithMany(x => x.CarroMotorista)
            .HasForeignKey(x=> x.MotoristaId);



    }
}
