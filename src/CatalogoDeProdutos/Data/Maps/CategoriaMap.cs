using CatalogoDeProdutos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatalogoDeProdutos.Data.Maps
{
    public class CategoriaMap :IEntityTypeConfiguration<Categoria>
    {
         public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
        }
    }
}