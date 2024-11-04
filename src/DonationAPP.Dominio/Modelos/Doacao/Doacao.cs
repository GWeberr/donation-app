using System;

namespace DonationAPP.Dominio.Modelos.Doacao
{
    public sealed class Doacao
    {
        public Guid Id { get; private set; }
        public Guid InstituicaoId { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }

        public Doacao(Guid id, Guid instituicaoId, decimal valor)
        {
            Id = id;
            InstituicaoId = instituicaoId;
            Valor = valor;
            Data = DateTime.UtcNow;
        }
    }
}
