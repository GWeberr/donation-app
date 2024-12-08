using DonationAPP.Essentials.Aplicacao.PortasDeSaida.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso<DadosDeSaida>,
        IPortaDeSaidaRegraInvalida,
        IPortaDeSaidaErroGenerico
    {
    }
}
