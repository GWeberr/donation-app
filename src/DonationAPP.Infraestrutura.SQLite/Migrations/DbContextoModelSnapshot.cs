﻿// <auto-generated />
using System;
using DonationAPP.Infraestrutura.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DonationAPP.Infraestrutura.SQLite.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("DonationAPP.Dominio.Modelos.Instituicoes.Entidades.Instituicao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("ID");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("CNPJ");

                    b.Property<int>("DoacoesRecebidas")
                        .HasColumnType("INTEGER")
                        .HasColumnName("DOACOESRECEBIDAS");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.ToTable("INSTITUICAO", (string)null);
                });

            modelBuilder.Entity("DonationAPP.Dominio.Modelos.Instituicoes.Entidades.InstituicaoDoacao", b =>
                {
                    b.Property<Guid>("InstituicaoId")
                        .HasColumnType("TEXT")
                        .HasColumnName("INSTITUICAOID");

                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT")
                        .HasColumnName("ID");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT")
                        .HasColumnName("DATA");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("DESCRICAO");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("TEXT")
                        .HasColumnName("QUANTIDADE");

                    b.Property<string>("TipoDeDoacao_Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("TIPODEDOACAO_NOME");

                    b.Property<Guid>("TipoDoacao_Id")
                        .HasColumnType("TEXT")
                        .HasColumnName("TIPODEDOACAO_ID");

                    b.HasKey("InstituicaoId", "Id");

                    b.ToTable("INSTITUICAODOACAO", (string)null);
                });

            modelBuilder.Entity("DonationAPP.Dominio.Modelos.Instituicoes.Entidades.InstituicaoEndereco", b =>
                {
                    b.Property<Guid>("InstituicaoId")
                        .HasColumnType("TEXT")
                        .HasColumnName("INSTITUICAOID");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("CIDADE");

                    b.Property<string>("Complemento")
                        .HasColumnType("TEXT")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<int?>("Numero")
                        .HasColumnType("INTEGER")
                        .HasColumnName("NUMERO");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("RUA");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("UF");

                    b.HasKey("InstituicaoId");

                    b.ToTable("INSTITUICAOENDERECO", (string)null);
                });

            modelBuilder.Entity("DonationAPP.Dominio.Modelos.TiposDeDoacao.Entidades.TipoDeDoacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("ID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.ToTable("TIPODEDOACAO", (string)null);
                });

            modelBuilder.Entity("DonationAPP.Dominio.Modelos.Instituicoes.Entidades.InstituicaoDoacao", b =>
                {
                    b.HasOne("DonationAPP.Dominio.Modelos.Instituicoes.Entidades.Instituicao", null)
                        .WithMany("Doacoes")
                        .HasForeignKey("InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DonationAPP.Dominio.Modelos.Instituicoes.Entidades.InstituicaoEndereco", b =>
                {
                    b.HasOne("DonationAPP.Dominio.Modelos.Instituicoes.Entidades.Instituicao", null)
                        .WithOne("Endereco")
                        .HasForeignKey("DonationAPP.Dominio.Modelos.Instituicoes.Entidades.InstituicaoEndereco", "InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DonationAPP.Dominio.Modelos.Instituicoes.Entidades.Instituicao", b =>
                {
                    b.Navigation("Doacoes");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
