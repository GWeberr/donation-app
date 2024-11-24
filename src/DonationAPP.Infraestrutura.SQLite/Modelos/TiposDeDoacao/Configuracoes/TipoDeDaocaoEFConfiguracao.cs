using DonationAPP.Dominio.Modelos.TipoDoacoes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.TiposDeDoacao.Configuracoes
{
    public sealed class TipoDeDaocaoEFConfiguracao :
        IEntityTypeConfiguration<TipoDoacao>
    {
        public void Configure(EntityTypeBuilder<TipoDoacao> builder)
        {
            builder.ToTable("TIPODOACAO");

            MontarIndices(builder);
            MontarColunas(builder);
        }

        private static void MontarIndices(EntityTypeBuilder<TipoDoacao> builder)
        {
            builder.HasKey(pk => pk.Id);
        }

        private static void MontarColunas(EntityTypeBuilder<TipoDoacao> builder)
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
