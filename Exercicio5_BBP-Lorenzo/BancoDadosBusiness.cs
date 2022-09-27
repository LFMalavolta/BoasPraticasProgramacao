using Exercicio5_BBP_Lorenzo.Enums;
using Exercicio5_BBP_Lorenzo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5_BBP_Lorenzo
{
    public class BancoDadosBusiness
    {
        public void SelecionarBancoDados(Venda vendaAtual)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Escolha o banco de Dados");
            Console.WriteLine("0 - MySQL");
            Console.WriteLine("1 - SQLServer");
            string bancoEscolhido = Console.ReadLine();
            bool existeBancoDados = Enum.IsDefined(typeof(BancoDados), int.Parse(bancoEscolhido));

            while (existeBancoDados == false)
            {
                Console.WriteLine("\nBanco escolhido invalido, favor escolher novamente!");
                Console.WriteLine("Escolha o banco de Dados");
                Console.WriteLine("0 - MySQL");
                Console.WriteLine("1 - SQLServer");
                bancoEscolhido = Console.ReadLine();
                existeBancoDados = Enum.IsDefined(typeof(BancoDados), int.Parse(bancoEscolhido));
            }
            vendaAtual.BancoDados = int.Parse(bancoEscolhido);
            Console.WriteLine("---------------------------------------------------------------------------------");
        }


    }
}
