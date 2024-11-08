using System;

namespace DonationAPP.Aplicacao.CasosDeUso.Doadores.Comandos.namespace DonationAPP.Aplicacao.CasosDeUso.Doadores.Comandos.Cadastrar

{
    public sealed class DadosDeEntrada
    {
        public Guid Id { get; }
        public string Nome { get; }
        public string Email { get; }
        public string QuantidadeDoada { get; }

        public DadosDeEntrada(
            Guid id,
            string nome,
            string email,
            int QuantidadeDoada)
        {
            Id = id;
            Nome = nome;
            Email = email;
            QuantidadeDoada = 0;
        }
    }
}
