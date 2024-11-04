// Doador.cs
using DonationAPP.Dominio.Modelos.Doardor;
using System;
using System.Collections.Generic;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar.Doardor
{
    public sealed class Doador
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int QuantidadeDoada { get; private set; }

        public Doador(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
            QuantidadeDoada = 0;
        }

        public void RegistrarDoacao(int quantidade)
        {
            if (quantidade > 0)
                QuantidadeDoada += quantidade;
            else
                throw new ArgumentException("A quantidade de doação deve ser positiva.");
        }
    }
}

// Instituicao.cs
using System;
using System.Collections.Generic;
using DonationAPP.Dominio.Modelos.Doador; // Certifique-se de que o namespace está correto

namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public sealed class Instituicao
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string CNPJ { get; private set; }
        public int DoacoesRecebidas { get; private set; }
        public List<Doadores> Doador { get; private set; }

        internal Instituicao(Guid id, string nome, string cnpj)
        {
            Id = id;
            Nome = nome;
            CNPJ = cnpj;
            DoacoesRecebidas = 0;
            Doador = new List<Doadores>();
        }

        public void RegistrarDoacao(Guid doadorId, int quantidade)
        {
            var doador = Doador.Find(d => d.Id == doadorId);
            if (doador != null)
            {
                doador.RegistrarDoacao(quantidade);
                DoacoesRecebidas += quantidade;
            }
            else
            {
                throw new Exception("Doador não encontrado para essa instituição.");
            }
        }

        public void AdicionarDoador(Doador doador)
        {
            if (!Doador.Exists(d => d.Id == doador.Id))
            {
                Doador.Add(doador);
            }
            else
            {
                throw new Exception("Doador já está registrado.");
            }
        }
    }
}
