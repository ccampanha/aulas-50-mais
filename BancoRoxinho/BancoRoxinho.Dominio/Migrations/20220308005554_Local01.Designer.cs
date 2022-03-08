﻿// <auto-generated />
using System;
using BancoRoxinho.Dominio.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BancoRoxinho.Dominio.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220308005554_Local01")]
    partial class Local01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BancoRoxinho.Dominio.Model.ContaCorrente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumeroDaConta")
                        .HasColumnType("int");

                    b.Property<float>("Saldo")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("ContasCorrentes");
                });

            modelBuilder.Entity("BancoRoxinho.Dominio.Model.PessoaFisica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("ContaCorrenteId")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDaMae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContaCorrenteId");

                    b.ToTable("PessoasFisicas");
                });

            modelBuilder.Entity("BancoRoxinho.Dominio.Model.PessoaJuridica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<int?>("ContaCorrenteId")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContaCorrenteId");

                    b.ToTable("PessoasJuridicas");
                });

            modelBuilder.Entity("BancoRoxinho.Dominio.Model.Transacoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContaDestinoId")
                        .HasColumnType("int");

                    b.Property<int?>("ContaOrigemId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ContaDestinoId");

                    b.HasIndex("ContaOrigemId");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("BancoRoxinho.Dominio.Model.PessoaFisica", b =>
                {
                    b.HasOne("BancoRoxinho.Dominio.Model.ContaCorrente", "ContaCorrente")
                        .WithMany()
                        .HasForeignKey("ContaCorrenteId");

                    b.Navigation("ContaCorrente");
                });

            modelBuilder.Entity("BancoRoxinho.Dominio.Model.PessoaJuridica", b =>
                {
                    b.HasOne("BancoRoxinho.Dominio.Model.ContaCorrente", "ContaCorrente")
                        .WithMany()
                        .HasForeignKey("ContaCorrenteId");

                    b.Navigation("ContaCorrente");
                });

            modelBuilder.Entity("BancoRoxinho.Dominio.Model.Transacoes", b =>
                {
                    b.HasOne("BancoRoxinho.Dominio.Model.ContaCorrente", "ContaDestino")
                        .WithMany()
                        .HasForeignKey("ContaDestinoId");

                    b.HasOne("BancoRoxinho.Dominio.Model.ContaCorrente", "ContaOrigem")
                        .WithMany()
                        .HasForeignKey("ContaOrigemId");

                    b.Navigation("ContaDestino");

                    b.Navigation("ContaOrigem");
                });
#pragma warning restore 612, 618
        }
    }
}
