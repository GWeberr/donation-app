using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.Instituicoes.Configuracoes
{
    internal sealed class InstituicaoDoacaoEFConfiguracao :
        IEntityTypeConfiguration<InstituicaoDoacao>
    {
        public void Configure(EntityTypeBuilder<InstituicaoDoacao> builder)
        {
            builder.ToTable("INSTITUICAODOACAO");

            MontarIndices(builder);
            MontarColunas(builder);
        }

        private static void MontarIndices(EntityTypeBuilder<InstituicaoDoacao> builder)
        {
            builder.HasKey(pk => new { pk.InstituicaoId, pk.Id });
        }

        private static void MontarColunas(EntityTypeBuilder<InstituicaoDoacao> builder)
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
                .Property(propriedade => propriedade.TipoDoacao_Id)
                .HasColumnName("TIPODEDOACAO_ID")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.TipoDeDoacao_Nome)
                .HasColumnName("TIPODEDOACAO_NOME")
                .IsRequired();

            builder
               .Property(propriedade => propriedade.Descricao)
               .HasColumnName("DESCRICAO")
               .IsRequired();

            builder
                .Property(propriedade => propriedade.Quantidade)
                .HasColumnName("QUANTIDADE")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.Data)
                .HasColumnName("DATA")
                .IsRequired();
        }
    }
}
