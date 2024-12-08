using DonationAPP.Essentials.Aplicacao.Interfaces.PortasDeSaida;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso<DadosDeSaida>,
        IPortaDeSaidaErroGenerico
    {
    }
}
