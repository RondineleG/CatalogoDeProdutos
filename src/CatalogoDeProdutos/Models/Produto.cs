using System;

namespace CatalogoDeProdutos.Models
{
    public class Produto
    {
       public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Imagem { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } 
    }
}