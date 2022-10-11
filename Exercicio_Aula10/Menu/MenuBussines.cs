using System;
using System.Collections.Generic;

namespace Exercicio_Aula10
{
    internal class MenuBussines
    {
        internal void InicializarMenu()
        {
            OperacoesPassagensImpl operacoesPassagemImpl = new OperacoesPassagensImpl();
            OperacoesPassagensProxy operacoesPassagensProxy = new OperacoesPassagensProxy(operacoesPassagemImpl);

            Console.WriteLine("Bem vindo ao painel Rodosoft!");
            while (true)
            {
                Console.WriteLine("\nEscolha sua opção:");
                Console.WriteLine("1- Compra de Passagens    2- Listar passagens compradas     3- Lista Logs     0- Sair");
                string opcaoMenu = Console.ReadLine();
                if (opcaoMenu == "1") operacoesPassagensProxy.ComprarPassagem();
                if (opcaoMenu == "2") operacoesPassagensProxy.ListarPassagens();
                if (opcaoMenu == "3") operacoesPassagensProxy.ListarLogs();
                if (opcaoMenu == "0") break;
            }           
        }       
    }
}