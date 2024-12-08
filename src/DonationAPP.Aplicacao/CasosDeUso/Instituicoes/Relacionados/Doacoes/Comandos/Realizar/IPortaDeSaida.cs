using DonationAPP.Essentials.Aplicacao.PortasDeSaida.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso<DadosDeSaida>,
        IPortaDeSaidaRegraInvalida,
        IPortaDeSaidaErroGenerico
    {
    }
}
