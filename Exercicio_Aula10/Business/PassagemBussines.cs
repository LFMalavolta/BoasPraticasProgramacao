using Exercicio_Aula10.Enums;
using Exercicio_Aula10.Factorys;
using System;

namespace Exercicio_Aula10
{
    public class PassagemBussines
    {
        public void selecionaTipoPassagem()
        {
            Console.WriteLine("Selecione o tipo de passagem:");
            Console.WriteLine("1- Digital \n2- Impressa\n");
            string passagemSelecionada = Console.ReadLine();

            FactoryPassagens factoryPassagens = new FactoryPassagens();
            IPassagens passagens = factoryPassagens.CriarPassagem(int.Parse(passagemSelecionada));
            passagens.SelecionaPassagem();
        }
    }
}