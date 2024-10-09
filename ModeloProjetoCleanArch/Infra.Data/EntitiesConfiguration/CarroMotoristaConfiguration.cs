using Domain.Model.MuitosPraMuitos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class CarroMotoristaConfiguration : IEntityTypeConfiguration<CarroMotorista>
{
    public void Configure(EntityTypeBuilder<CarroMotorista> builder)
    {
        // Como é chave composta não queremos usar o BaseConfiguration.ConfiguracaoPadrao
        builder.HasKey(c => new { c.CarroId, c.MotoristaId });


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
            .HasForeignKey(x => x.MotoristaId);



    }
}
