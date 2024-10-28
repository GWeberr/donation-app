using System;

namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public sealed class Instituicao
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; } 
        public string CNPJ { get; private set; }
        public int DoacoesRecebidas { get; private set; }

        internal Instituicao(
            Guid id, 
            string nome, 
            string cnpj)
        {
            Id = id;
            Nome = nome;
            CNPJ = cnpj;
            DoacoesRecebidas = 0;
        }
    }
}
