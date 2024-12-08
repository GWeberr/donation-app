using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.Instituicoes.Configuracoes
{
    internal sealed class InstituicaoEnderecoEFConfiguracao :
        IEntityTypeConfiguration<InstituicaoEndereco>
    {
        public void Configure(EntityTypeBuilder<InstituicaoEndereco> builder)
        {
            builder.ToTable("INSTITUICAOENDERECO");

            Montarindices(builder);
            MontarColunas(builder);
        }

        private static void Montarindices(EntityTypeBuilder<InstituicaoEndereco> builder)
        {
            builder.HasKey(pk => pk.InstituicaoId);
        }

        private static void MontarColunas(EntityTypeBuilder<InstituicaoEndereco> builder)
        {
            builder
                .Property(propriedade => propriedade.InstituicaoId)
                .HasColumnName("INSTITUICAOID")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.CEP)
                .HasColumnName("CEP")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.Rua)
                .HasColumnName("RUA")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.Bairro)
                .HasColumnName("BAIRRO")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.Cidade)
                .HasColumnName("CIDADE")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.UF)
                .HasColumnName("UF")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.Numero)
                .HasColumnName("NUMERO");

            builder
                .Property(propriedade => propriedade.Complemento)
                .HasColumnName("COMPLEMENTO");
        }
    }
}
