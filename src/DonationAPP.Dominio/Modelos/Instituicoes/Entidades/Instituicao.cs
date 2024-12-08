namespace DonationAPP.Dominio.Modelos.Instituicoes.Entidades
{
    public sealed class Instituicao
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string CNPJ { get; private set; }
        public int DoacoesRecebidas { get; private set; }
        public InstituicaoEndereco? Endereco { get; private set; }
        public IReadOnlyCollection<InstituicaoDoacao>? Doacoes { get { return _doacoes; } }
        private List<InstituicaoDoacao>? _doacoes;

        internal Instituicao(
            Guid id,
            string nome,
            string cNPJ)
        {
            Id = id;
            Nome = nome;
            CNPJ = cNPJ;
            DoacoesRecebidas = 0;
            _doacoes = null;
        }

        public void Vincular(InstituicaoEndereco endereco)
        {
            Endereco = endereco;
        }

        internal void Carregar(InstituicaoEndereco endereco)
        {
            if (Endereco is not null)
                throw new ArgumentException("Endereço já carregado para esta instituição");

            Endereco = endereco;
        }

        internal void Carregar(List<InstituicaoDoacao> doacoes)
        {
            if (_doacoes is not null)
                throw new ArgumentException("Doações já carregadas para esta instituição");

            _doacoes = doacoes;
        }

        public void Adicionar(InstituicaoDoacao doacaoNova)
        {
            if (_doacoes is null)
                throw new ArgumentException("Doações não carregadas para esta instituição");
            else if (doacaoNova is null)
                throw new ArgumentException("Doações não informada");
            else if (_doacoes.Any(doacao => doacao.Id == doacaoNova.Id))
                throw new ArgumentException("Doações já existe nesta instituição");

            DoacoesRecebidas++;

            _doacoes.Add(doacaoNova);
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarCNPJ(string cnpj)
        {
            CNPJ = cnpj;
        }
    }
}
