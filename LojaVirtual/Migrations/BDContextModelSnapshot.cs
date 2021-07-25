﻿// <auto-generated />
using System;
using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LojaVirtual.Migrations
{
    [DbContext(typeof(BDContext))]
    partial class BDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "en_US.utf8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("LojaVirtual.Models.Endereço", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("Id");

                    b.ToTable("Endereço");
                });

            modelBuilder.Entity("LojaVirtual.Models.Estoque", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Lojaid")
                        .HasColumnType("integer");

                    b.Property<double>("PreçoCompra")
                        .HasColumnType("double precision");

                    b.Property<int?>("Produtoid")
                        .HasColumnType("integer");

                    b.Property<double>("ProçoVenda")
                        .HasColumnType("double precision");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("Lojaid");

                    b.HasIndex("Produtoid");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("LojaVirtual.Models.GoogleAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("nameidentifier")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GoogleAccounts");
                });

            modelBuilder.Entity("LojaVirtual.Models.MicrosoftAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Identifier")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MicrosoftAccounts");
                });

            modelBuilder.Entity("LojaVirtual.Models.Produtos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descrição")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("LojaVirtual.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int?>("EndereçoId")
                        .HasColumnType("integer");

                    b.Property<int?>("GoogleId")
                        .HasColumnType("integer");

                    b.Property<int?>("Lojaid")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone2")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("EndereçoId");

                    b.HasIndex("GoogleId");

                    b.HasIndex("Lojaid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LojaVirtual.Models.lojas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("EndereçoId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("EndereçoId");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("LojaVirtual.Models.Estoque", b =>
                {
                    b.HasOne("LojaVirtual.Models.lojas", "Loja")
                        .WithMany("Estoques")
                        .HasForeignKey("Lojaid");

                    b.HasOne("LojaVirtual.Models.Produtos", "Produto")
                        .WithMany("Estoques")
                        .HasForeignKey("Produtoid");

                    b.Navigation("Loja");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("LojaVirtual.Models.Users", b =>
                {
                    b.HasOne("LojaVirtual.Models.Endereço", "Endereço")
                        .WithMany()
                        .HasForeignKey("EndereçoId");

                    b.HasOne("LojaVirtual.Models.GoogleAccount", "Google")
                        .WithMany()
                        .HasForeignKey("GoogleId");

                    b.HasOne("LojaVirtual.Models.lojas", "Loja")
                        .WithMany("users")
                        .HasForeignKey("Lojaid");

                    b.Navigation("Endereço");

                    b.Navigation("Google");

                    b.Navigation("Loja");
                });

            modelBuilder.Entity("LojaVirtual.Models.lojas", b =>
                {
                    b.HasOne("LojaVirtual.Models.Endereço", "Endereço")
                        .WithMany()
                        .HasForeignKey("EndereçoId");

                    b.Navigation("Endereço");
                });

            modelBuilder.Entity("LojaVirtual.Models.Produtos", b =>
                {
                    b.Navigation("Estoques");
                });

            modelBuilder.Entity("LojaVirtual.Models.lojas", b =>
                {
                    b.Navigation("Estoques");

                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}
