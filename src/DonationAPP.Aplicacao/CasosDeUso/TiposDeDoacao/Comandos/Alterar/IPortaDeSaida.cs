using DonationAPP.Essentials.Aplicacao.Interfaces.PortasDeSaida;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Alterar
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso<DadosDeSaida>,
        IPortaDeSaidaErroGenerico
    {
    }
}
