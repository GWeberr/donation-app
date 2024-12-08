using DonationAPP.Essentials.Aplicacao.PortasDeSaida.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.Todos
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso<DadosDeSaida>,
        IPortaDeSaidaErroGenerico
    {
    }
}
