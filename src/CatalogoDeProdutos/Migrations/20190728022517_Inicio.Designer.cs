﻿// <auto-generated />
using System;
using CatalogoDeProdutos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatalogoDeProdutos.Migrations
{
    [DbContext(typeof(CatalogoDataContext))]
    [Migration("20190728022517_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CatalogoDeProdutos.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("CatalogoDeProdutos.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataUltimaAtualizacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<decimal>("Preco")
                        .HasColumnType("money");

                    b.Property<int>("Quantidade");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("CatalogoDeProdutos.Models.Produto", b =>
                {
                    b.HasOne("CatalogoDeProdutos.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
