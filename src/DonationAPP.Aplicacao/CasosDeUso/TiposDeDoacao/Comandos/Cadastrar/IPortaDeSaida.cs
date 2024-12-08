using DonationAPP.Essentials.Aplicacao.PortasDeSaida.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Cadastrar
{
    public interface IPortaDeSaida :
        IPortaDeSaidaSucesso<DadosDeSaida>,
        IPortaDeSaidaErroGenerico
    {
    }
}
