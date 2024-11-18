using DonationAPP.Essentials.Aplicacao.Interfaces.Dados;

namespace DonationAPP.Essentials.Aplicacao.Interfaces.PortasDeSaida
{
    public interface IPortaDeSaidaSucesso<TDadosDeSaida> 
        where TDadosDeSaida : IDadosDeSaida
    {
        void Sucesso(TDadosDeSaida dadosDeSaida);
    }
}
