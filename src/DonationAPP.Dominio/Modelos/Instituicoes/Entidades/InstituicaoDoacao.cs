namespace DonationAPP.Dominio.Modelos.Instituicoes.Entidades
{
    public sealed class InstituicaoDoacao
    {
        public Guid Id { get; private set; }
        public Guid InstituicaoId { get; private set; }
        public Guid TipoDoacao_Id { get; private set; }
        public string TipoDeDoacao_Nome { get; private set; }
        public decimal Quantidade { get; private set; }
        public DateTime Data { get; private set; }

        public InstituicaoDoacao(
            Guid instituicaoId,
            Guid tipoDoacao_Id,
            string tipoDeDoacao_Nome,
            Guid id,
            decimal quantidade)
        {
            Id = id;
            InstituicaoId = instituicaoId;
            TipoDoacao_Id = tipoDoacao_Id;
            TipoDeDoacao_Nome = tipoDeDoacao_Nome;
            Quantidade = quantidade;
            Data = DateTime.UtcNow;
        }
    }
}
