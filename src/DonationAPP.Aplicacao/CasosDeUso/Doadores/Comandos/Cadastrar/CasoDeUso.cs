using DonationAPP.Dominio.Modelos.Doadores;
using System;

namespace DonationAPP.Aplicacao.CasosDeUso.Doadores.Comandos.Cadastrar
{
    public sealed class CasoDeUso
    {
        public void Executar(DadosDeEntrada dadosDeEntrada)
        {
            try
            {
                var doador = DoadorFabrica.Criar(dadosDeEntrada.Id, dadosDeEntrada.Nome, dadosDeEntrada.Email, dadosDeEntrada.QuantidadeDoada);
            }
            catch
            {
            }
        }
    }
}
