using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.Instituicoes.Configuracoes
{
    internal sealed class InstituicaoEFConfiguracao :
        IEntityTypeConfiguration<Instituicao>
    {
        public void Configure(EntityTypeBuilder<Instituicao> builder)
        {
            builder.ToTable("INSTITUICAO");

            Montarindices(builder);
            MontarColunas(builder);
            MontarRelacionamentos(builder);
        }

        private static void Montarindices(EntityTypeBuilder<Instituicao> builder)
        {
            builder.HasKey(pk => pk.Id);
        }

        private static void MontarColunas(EntityTypeBuilder<Instituicao> builder)
        {
            builder
                .Property(propriedade => propriedade.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.Nome)
                .HasColumnName("NOME")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.CNPJ)
                .HasColumnName("CNPJ")
                .IsRequired();

            builder
                .Property(propriedade => propriedade.DoacoesRecebidas)
                .HasColumnName("DOACOESRECEBIDAS")
                .IsRequired();

            builder
                .Ignore(p => p.Doadores);
        }

        private static void MontarRelacionamentos(EntityTypeBuilder<Instituicao> builder)
        {
            builder
                .HasOne(entidadePrimaria => entidadePrimaria.Endereco!)
                .WithOne()
                .HasForeignKey<InstituicaoEndereco>(entidadeEstrangeira => entidadeEstrangeira.InstituicaoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
