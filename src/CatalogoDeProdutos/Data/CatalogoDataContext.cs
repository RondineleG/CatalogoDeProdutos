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
          optionsBuilder.UseSqlServer(@"Data Source=.\\SQLEXPRESS;Initial Catalog=CatalogoDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new CategoriaMap());
        }
    }
}