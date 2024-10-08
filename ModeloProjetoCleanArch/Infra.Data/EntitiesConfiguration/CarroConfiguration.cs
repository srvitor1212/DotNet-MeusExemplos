﻿using Domain.Model.UmPraUm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class CarroConfiguration : IEntityTypeConfiguration<Carro>
{
    public void Configure(EntityTypeBuilder<Carro> builder)
    {
        // Método para configurações padrão
        builder.ConfiguracaoPadrao();

        // Propriedades das colunas
        builder.Property(x => x.Modelo)
                .IsRequired();

        // 1:N - UM fabricante para MUITOS carros
        builder.HasOne(x => x.Fabricante)
                .WithMany(x => x.Carros)
                .HasForeignKey(x => x.FabricanteId)
                .OnDelete(DeleteBehavior.NoAction);
    }
}
