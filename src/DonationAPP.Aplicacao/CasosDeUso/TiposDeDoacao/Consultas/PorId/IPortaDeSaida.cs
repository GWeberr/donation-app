using DonationAPP.Essentials.Aplicacao.Interfaces.PortasDeSaida;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.PorId
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso<DadosDeSaida>,
        IPortaDeSaidaRegraInvalida,
        IPortaDeSaidaErroGenerico
    {
    }
}
