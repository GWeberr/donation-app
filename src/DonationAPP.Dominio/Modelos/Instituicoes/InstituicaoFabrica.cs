using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;
using DonationAPP.Dominio.Modelos.TiposDeDoacao.Entidades;

namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public static class InstituicaoFabrica
    {
        public static Instituicao Criar(
            Guid id,
            string nome,
            string cnpj)
        {
            return new Instituicao(id, nome, cnpj);
        }

        public static InstituicaoEndereco CriarEndereco(
            Instituicao instituicao,
            string cep,
            string rua,
            string bairro,
            string cidade,
            string uf,
            int? numero,
            string? complemento)
        {
            return new InstituicaoEndereco(instituicao.Id, cep, rua, bairro, cidade, uf, numero, complemento);
        }

        public static InstituicaoDoacao CriarDoacao(
            Instituicao instituicao,
            TipoDeDoacao tipoDeDoacao,
            Guid id,
            string descricao,
            decimal quantidade)
        {
            return new InstituicaoDoacao(instituicao.Id, tipoDeDoacao.Id, tipoDeDoacao.Nome, id, descricao, quantidade);
        }
    }
}
