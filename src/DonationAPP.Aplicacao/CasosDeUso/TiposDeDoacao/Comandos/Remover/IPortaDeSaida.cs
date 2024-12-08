using DonationAPP.Essentials.Aplicacao.Interfaces.PortasDeSaida;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Remover
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso,
        IPortaDeSaidaErroGenerico
    {
    }
}
