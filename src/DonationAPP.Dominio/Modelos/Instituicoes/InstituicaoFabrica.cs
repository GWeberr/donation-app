using System;

namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public static class InstituicaoFabrica
    {
        public static Instituicao Criar(Guid id, string nome, string cnpj, int doacoesRecebidas)
        {
            return new Instituicao(id, nome, cnpj, doacoesRecebidas);
        }
    }
}
