using DonationAPP.Dominio.Modelos.Doacoes.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.Doacoes.Configuracoes
{
    internal sealed class DoacaoEFConfiguracao :
        IEntityTypeConfiguration<Doacao>
    {
        public void Configure(EntityTypeBuilder<Doacao> builder)
        {
            builder.ToTable("DOACAO");

            MontarIndices(builder);
            MontarColunas(builder);
        }

        private static void MontarIndices(EntityTypeBuilder<Doacao> builder)
        {
            builder.HasKey(pk => pk.Id);
        }

        private static void MontarColunas(EntityTypeBuilder<Doacao> builder)
        {
            builder
                .Property(propriedade => propriedade.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.InstituicaoId)
                .HasColumnName("INSTITUICAOID")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.TipoDoacaoId)
                .HasColumnName("TIPODOACAOID")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.Valor)
                .HasColumnName("VALOR")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.Data)
                .HasColumnName("DATA")
                .IsRequired();
        }
    }
}
