using Exercicio5_BBP_Lorenzo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5_BBP_Lorenzo
{
    public class MySQL : IBancoDados
    {
        public void remover()
        {
            Console.WriteLine("Removendo dado do banco MySQL");
        }

        public void salvar()
        {
            Console.WriteLine("Salvando dado no banco MySQL");
        }
    }
}
