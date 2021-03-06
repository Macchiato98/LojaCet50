﻿// <auto-generated />
using System;
using LojaCet50.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LojaCet50.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210105163718_InitBase")]
    partial class InitBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LojaCet50.Models.Dados.Entidades.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apelido");

                    b.Property<DateTime>("DatadeNascimento");

                    b.Property<string>("Morada");

                    b.Property<string>("Nome");

                    b.Property<int>("NumeroTelefone");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("LojaCet50.Models.Dados.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Disponivel");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.Property<double>("Stock");

                    b.Property<DateTime>("UltimaCompra");

                    b.Property<DateTime>("UltimaVenda");

                    b.Property<string>("UrlDaImagem");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
