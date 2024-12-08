using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;
using System;

namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public static class InstituicaoFabrica
    {
        public static Instituicao Criar(Guid id, string nome, string cnpj)
        {
            return new Instituicao(id, nome, cnpj);
        }
    }
}
