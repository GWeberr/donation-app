using DonationAPP.Essentials.Aplicacao.Interfaces.PortasDeSaida;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Remover
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso,
        IPortaDeSaidaErroGenerico
    {
    }
}
