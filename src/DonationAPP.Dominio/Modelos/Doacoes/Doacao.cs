using System;

namespace DonationAPP.Dominio.Modelos.Doacoes
{
    public sealed class Doacao
    {
        public Guid Id { get; private set; }
        public Guid InstituicaoId { get; private set; }
        public Guid TipoDoacaoId { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }

        public Doacao(Guid id, Guid instituicaoId, Guid tipoDoacaoId, decimal valor)
        {
            Id = id;
            InstituicaoId = instituicaoId;
            TipoDoacaoId = tipoDoacaoId;
            Valor = valor;
            Data = DateTime.UtcNow;
        }
    }
}
