using Exercicio5_BBP_Lorenzo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5_BBP_Lorenzo
{
    public class ValidacaoPagamento
    {
        public void ValidarPagamento(Venda vendaAtual)
        {
            switch (vendaAtual.MeioPagamento)
            {
                case 0:
                    Dinheiro dinheiro = new Dinheiro();
                    dinheiro.ValorTotalPagamento = vendaAtual.ValorTotalCompra;
                    dinheiro.ValidarPagamento(dinheiro);
                    break;

                case 1:
                    CartaoCredito cartaoCredito = new CartaoCredito();
                    ICartao cartaoDados = PreencherDadosCartao(cartaoCredito);
                    cartaoCredito.BandeiraCartao = cartaoDados.BandeiraCartao;
                    cartaoCredito.InstituicaoProcessadora = cartaoDados.InstituicaoProcessadora;
                    cartaoCredito.ValorTotalPagamento = vendaAtual.ValorTotalCompra;
                    cartaoCredito.ValidarPagamento(cartaoCredito);
                    break;
            }

        }

        private ICartao PreencherDadosCartao(ICartao cartao)
        {
            Console.WriteLine("Digite a bandeira do cartao: ");
            cartao.BandeiraCartao = Console.ReadLine();

            Console.WriteLine("Digite a instituicção Processadora");
            cartao.InstituicaoProcessadora = Console.ReadLine();

            return cartao;
        }
    }
}
