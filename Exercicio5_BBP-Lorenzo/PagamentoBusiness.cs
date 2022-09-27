using Exercicio5_BBP_Lorenzo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5_BBP_Lorenzo
{
    public class PagamentoBusiness
    {
        public void RealizarPagamento(Venda vendaAtual)
        {
            try
            {
                ValidacaoPagamento validaPagamento = new ValidacaoPagamento();
                RegistroPagamento registroPagamento = new RegistroPagamento();

                validaPagamento.ValidarPagamento(vendaAtual);
                registroPagamento.RegistrarPagamento(vendaAtual);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
            

    }
}
