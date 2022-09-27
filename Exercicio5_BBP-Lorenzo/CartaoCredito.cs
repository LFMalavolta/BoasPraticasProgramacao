using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5_BBP_Lorenzo
{
    public class CartaoCredito : ICartao
    {
        public double ValorTotalPagamento { get; set; }
        public string BandeiraCartao { get; set; }
        public string InstituicaoProcessadora { get; set; }

        public void ValidarPagamento(ICartao formaPagamento)
        {
            bool eBandeiraCartaoVazia = string.IsNullOrEmpty(formaPagamento.BandeiraCartao);
            if (eBandeiraCartaoVazia) { throw new Exception("Bandeira invalida"); }

            bool eInstituicaoProcessadoraVazia = string.IsNullOrEmpty(formaPagamento.InstituicaoProcessadora);
            if (eInstituicaoProcessadoraVazia) { throw new Exception("Instituicao processadora invalida"); }

            bool eValorTotalVazio = formaPagamento.ValorTotalPagamento == 0;
            if (eValorTotalVazio) { throw new Exception("Valor informado vazio"); }

            //Sucesso em validar
        }
    }
}
