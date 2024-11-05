using System;

namespace DonationAPP.Dominio.Modelos.Doacao
{
    public sealed class Doador
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string CNPJ { get; private set; }

        public Doador(Guid id, string nome, string cnpj)
        {
            Id = id;
            Nome = nome;
            CNPJ = cnpj;
        }
    }
}
