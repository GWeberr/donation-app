﻿using DonationAPP.Essentials.Aplicacao.Interfaces.Dados;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Alterar
{
    public sealed class DadosDeSaida(Guid id, string nome) :
        IDadosDeSaida
    {
        public Guid Id { get; } = id;
        public string Nome { get; } = nome;
    }
}
