using System;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar
{
    public sealed class DadosDeEntrada
    {
        public Guid Id { get; }
        public string Nome { get; }
        public string CNPJ { get; }

        public DadosDeEntrada(
            Guid id, 
            string nome, 
            string cnpj)
        {
            Id = id;
            Nome = nome;
            CNPJ = cnpj;
        }
    }
}
