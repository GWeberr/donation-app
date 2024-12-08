using DonationAPP.Dominio.Modelos.TiposDeDoacao.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.TiposDeDoacao.Configuracoes
{
    public sealed class TipoDeDaocaoEFConfiguracao :
        IEntityTypeConfiguration<TipoDeDoacao>
    {
        public void Configure(EntityTypeBuilder<TipoDeDoacao> builder)
        {
            builder.ToTable("TIPODOACAO");

            MontarIndices(builder);
            MontarColunas(builder);
        }

        private static void MontarIndices(EntityTypeBuilder<TipoDeDoacao> builder)
        {
            builder.HasKey(pk => pk.Id);
        }

        private static void MontarColunas(EntityTypeBuilder<TipoDeDoacao> builder)
        {
            builder
                .Property(propriedade => propriedade.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
