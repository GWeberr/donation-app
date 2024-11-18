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
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("DonationAPP.Dominio.Modelos.Doacoes.Doacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("ID");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT")
                        .HasColumnName("DATA");

                    b.Property<Guid>("InstituicaoId")
                        .HasColumnType("TEXT")
                        .HasColumnName("INSTITUICAOID");

                    b.Property<Guid>("TipoDoacaoId")
                        .HasColumnType("TEXT")
                        .HasColumnName("TIPODOACAOID");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT")
                        .HasColumnName("VALOR");

                    b.HasKey("Id");

                    b.ToTable("DOACAO", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
