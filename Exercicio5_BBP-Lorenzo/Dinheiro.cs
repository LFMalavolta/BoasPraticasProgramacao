using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5_BBP_Lorenzo
{
    public class Dinheiro : IFormaPagamento
    {
        public double ValorTotalPagamento { get; set; }

        public void ValidarPagamento(IFormaPagamento formaPagamento)
        {
            bool eValorTotalVazio = formaPagamento.ValorTotalPagamento == 0;
            if (eValorTotalVazio) { throw new Exception("Valor informado vazio"); }

            //Sucesso em validar
        }
    }
}
