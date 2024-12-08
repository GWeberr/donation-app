using DonationAPP.Essentials.Aplicacao.Interfaces.PortasDeSaida;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Alterar
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso<DadosDeSaida>,
        IPortaDeSaidaErroGenerico
    {
    }
}
