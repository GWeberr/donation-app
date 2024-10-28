using DonationAPP.Dominio.Modelos.Instituicoes;
using System;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar
{
    public sealed class CasoDeUso
    {
        public void Executar()
        {
            var instituicao = InstituicaoFabrica.Criar(Guid.NewGuid(), "empresa", "123", 1);
        }
    }
}
