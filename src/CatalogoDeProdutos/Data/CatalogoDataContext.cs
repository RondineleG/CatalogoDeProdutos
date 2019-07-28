using CatalogoDeProdutos.Data.Maps;
using CatalogoDeProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoDeProdutos.Data
{
    public class CatalogoDataContext : DbContext
    {
        public DbSet<Categoria> Categorias {get;set;}

        public DbSet<Produto> Produtos {get;set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=prodcat;User ID=SA;Password=1q2w3e%&!");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new CategoriaMap());
        }
    }
}