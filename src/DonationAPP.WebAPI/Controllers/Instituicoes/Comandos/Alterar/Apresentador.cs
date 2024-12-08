﻿using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Alterar;
using DonationAPP.Essentials.WebAPI.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Alterar
{
    public sealed class Apresentador :
        ApresentadorBase,
        IPortaDeSaida
    {
        public void Sucesso(DadosDeSaida dadosDeSaida)
        {
            var endereco = ConstruirRespostaEndereco(dadosDeSaida.Endereco);

            var resposta = new RespostaDTO
            {
                Nome = dadosDeSaida.Nome,
                CNPJ = dadosDeSaida.CNPJ,
                Endereco = endereco
            };

            ViewModel = new OkObjectResult(resposta)
            {
                StatusCode = StatusCodes.Status201Created
            };
        }

        private static RespostaDTOEndereco ConstruirRespostaEndereco(DadosDeSaidaEndereco endereco)
        {
            return new RespostaDTOEndereco()
            {
                CEP = endereco.CEP,
                Rua = endereco.Rua,
                Cidade = endereco.Cidade,
                Bairro = endereco.Bairro,
                Complemento = endereco.Complemento,
                Numero = endereco.Numero,
                UF = endereco.UF,
            };
        }
    }
}