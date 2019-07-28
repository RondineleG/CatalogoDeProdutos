using CatalogoDeProdutos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatalogoDeProdutos.Data.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
       public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
            builder.Property(x => x.Imagem).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
            builder.Property(x => x.DataUltimaAtualizacao).IsRequired();
            builder.Property(x => x.Preco).IsRequired().HasColumnType("money");
            builder.Property(x => x.Quantidade).IsRequired();
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.HasOne(x => x.Categoria).WithMany(x => x.Produtos);
        } 
    }
}