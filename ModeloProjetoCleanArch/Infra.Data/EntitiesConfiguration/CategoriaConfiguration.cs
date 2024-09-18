using Domain.Model.UmPraUm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        // define a PK
        builder.HasKey(x => x.Id);

        // propriedades das colunas
        builder.Property(x => x.Nome)
                .HasMaxLength(100)
                .IsRequired();
    }
}
