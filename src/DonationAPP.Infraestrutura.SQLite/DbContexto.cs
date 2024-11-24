﻿using DonationAPP.Dominio.Modelos.Doacoes;
using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Dominio.Modelos.TipoDoacoes;
using DonationAPP.Infraestrutura.SQLite.Modelos.Doacoes.Configuracoes;
using DonationAPP.Infraestrutura.SQLite.Modelos.Instituicoes.Configuracoes;
using DonationAPP.Infraestrutura.SQLite.Modelos.TiposDeDoacao.Configuracoes;
using Microsoft.EntityFrameworkCore;

namespace DonationAPP.Infraestrutura.SQLite
{
    public sealed class DbContexto(DbContextOptions<DbContexto> options) :
        DbContext(options)
    {
        public DbSet<Doacao> Doacoes { get; private set; } = default!;
        public DbSet<Instituicao> Instituicoes { get; private set; } = default!;
        public DbSet<TipoDoacao> TiposDoacao { get; private set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoacaoEFConfiguracao());
            modelBuilder.ApplyConfiguration(new InstituicaoEFConfiguracao());
            modelBuilder.ApplyConfiguration(new TipoDeDaocaoEFConfiguracao());
        }
    }
}
