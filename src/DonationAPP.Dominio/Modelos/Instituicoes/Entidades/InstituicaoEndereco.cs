namespace DonationAPP.Dominio.Modelos.Instituicoes.Entidades
{
    public sealed class InstituicaoEndereco
    {
        public Guid InstituicaoId { get; private set; }
        public string CEP { get; private set; }
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public int? Numero { get; private set; }
        public string? Complemento { get; private set; }

        public InstituicaoEndereco(
            Guid instituicaoId,
            string cEP,
            string rua,
            string bairro,
            string cidade,
            string uF,
            int? numero,
            string? complemento)
        {
            InstituicaoId = instituicaoId;
            CEP = cEP;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            Numero = numero;
            Complemento = complemento;
        }
    }
}
