using DonationAPP.Dominio.Modelos.Instituicoes;
using System;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar
{
    public sealed class CasoDeUso
    {
        public void Executar(DadosDeEntrada dadosDeEntrada)
        {
            try
            {
                var instituicao = InstituicaoFabrica
                    .Criar(dadosDeEntrada.Id, dadosDeEntrada.Nome, dadosDeEntrada.CNPJ);


            }
            catch
            {
            }
        }
    }
}
