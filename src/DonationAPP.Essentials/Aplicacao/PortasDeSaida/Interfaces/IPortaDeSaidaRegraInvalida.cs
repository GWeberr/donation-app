using DonationAPP.Essentials.Aplicacao.Dados.Interfaces;

namespace DonationAPP.Essentials.Aplicacao.PortasDeSaida.Interfaces
{
    public interface IPortaDeSaidaSucesso
    {
        void Sucesso();
    }

    public interface IPortaDeSaidaSucesso<TDadosDeSaida>
        where TDadosDeSaida : IDadosDeSaida
    {
        void Sucesso(TDadosDeSaida dadosDeSaida);
    }
}
