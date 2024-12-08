using DonationAPP.Essentials.Aplicacao.PortasDeSaida.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Remover
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso,
        IPortaDeSaidaErroGenerico
    {
    }
}
