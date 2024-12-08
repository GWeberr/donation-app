using DonationAPP.Dominio.Modelos.Doadores;

namespace DonationAPP.Dominio.Modelos.Instituicoes.Entidades
{
    public sealed class Instituicao
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string CNPJ { get; private set; }
        public int DoacoesRecebidas { get; private set; }
        public InstituicaoEndereco? Endereco { get; private set; }
        public IReadOnlyCollection<Doador>? Doadores { get { return _doadores; } }
        private List<Doador>? _doadores;

        internal Instituicao(
            Guid id,
            string nome,
            string cNPJ)
        {
            Id = id;
            Nome = nome;
            CNPJ = cNPJ;
            DoacoesRecebidas = 0;
            _doadores = null;
        }

        public void Vincular(InstituicaoEndereco endereco)
        {
            Endereco = endereco;
        }

        internal void Carregar(List<Doador> doadores)
        {
            _doadores = doadores;
        }

        public void RegistrarDoacao(Guid doadorId, int quantidade)
        {
            if (_doadores is null)
                throw new Exception("Lista de doadores não foi carregada!");

            var doador = _doadores.FirstOrDefault(d => d.Id == doadorId);
            if (doador != null)
            {
                doador.RegistrarDoacao(quantidade);
                DoacoesRecebidas += quantidade;
            }
            else
                throw new Exception("Doador não encontrado para essa instituição.");
        }

        public void AdicionarDoador(Doador doador)
        {
            if (_doadores is null)
                throw new Exception("Lista de doadores não foi carregada!");

            if (!_doadores.Exists(d => d.Id == doador.Id))
                _doadores.Add(doador);
            else
                throw new Exception("Doador já está registrado.");
        }
    }
}
