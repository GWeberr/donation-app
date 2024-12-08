﻿using DonationAPP.Essentials.Aplicacao.Dados.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Consultas.Todos
{
    public sealed class DadosDeSaida :
        DadosDeSaidaListaBase<DadosDeSaidaItem>
    {
        public DadosDeSaida(List<DadosDeSaidaItem> itens) : 
            base(itens)
        {
        }
    }
}
