using System;
using System.Collections.Generic;

namespace Exercicio_Aula10
{
    internal class MenuBussines
    {
        internal void InicializarMenu()
        {
            PassagemBussines passagemBussines = new PassagemBussines();
            Console.WriteLine("Bem vindo ao painel Rodosoft!");
            while (true)
            {
                Console.WriteLine("Escolha sua opção:");
                Console.WriteLine("1- Compra de Passagens    2- Listar passagens compradas     0- Sair");
                string opcaoMenu = Console.ReadLine();
                if (opcaoMenu == "1") passagemBussines.ComprarPassagem();
                if (opcaoMenu == "2") passagemBussines.ListarPassagens();
                if (opcaoMenu == "0") break;
            }           
        }       
    }
}