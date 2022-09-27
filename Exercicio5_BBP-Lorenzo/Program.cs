using Exercicio5_BBP_Lorenzo.Models;
using System;

namespace Exercicio5_BBP_Lorenzo
{
    class Program
    {
        static void Main(string[] args)
        {
            Venda vendaAtual = new Venda();
            BancoDadosBusiness bancoDados = new BancoDadosBusiness();
            bancoDados.SelecionarBancoDados(vendaAtual);
            Console.WriteLine("\nBem vindo a tela de Pagamento");

            Console.WriteLine("Digite o valor do produto: ");
            string valorProduto = Console.ReadLine();
            
            Console.WriteLine("\nDigite a forma de pagamento:");
            Console.WriteLine("0 - Dinheiro");
            Console.WriteLine("1 - Cartão de Crédito");
            string formaPagamento = Console.ReadLine();
            bool ExisteFormaPagamento = Enum.IsDefined(typeof(FormasPagamento), int.Parse(formaPagamento));

            while (ExisteFormaPagamento == false)
            {
                Console.WriteLine("\nForma de pagamento invalida, favor escolher novamente!");
                Console.WriteLine("Digite a forma de pagamento:");
                Console.WriteLine("0 - Dinheiro");
                Console.WriteLine("1 - Cartão de Crédito");
                formaPagamento = Console.ReadLine();
                ExisteFormaPagamento = Enum.IsDefined(typeof(FormasPagamento), int.Parse(formaPagamento));
            }

            Console.WriteLine("Valor do produto: R$" + valorProduto + " sera pago em " + Enum.GetName(typeof(FormasPagamento), int.Parse(formaPagamento)));
            Console.WriteLine("\nProcessando pagamento...");
            vendaAtual.MeioPagamento = int.Parse(formaPagamento);
            vendaAtual.ValorTotalCompra = double.Parse(valorProduto);

            PagamentoBusiness pagamentoBusiness =  new PagamentoBusiness();
            pagamentoBusiness.RealizarPagamento(vendaAtual);
        }
    }
}
