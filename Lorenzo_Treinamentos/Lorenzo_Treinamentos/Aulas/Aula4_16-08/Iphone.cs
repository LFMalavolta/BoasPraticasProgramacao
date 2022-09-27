using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula4_16_08
{
    class Iphone : ISmartPhone
    {
        public void ConectaInternet()
        {
            Console.WriteLine("Iphone conecta na internet");
        }

        public void EnviarMensagem()
        {
            Console.WriteLine("Iphone envia mensagem");
        }

        public void FazerLigacao()
        {
            Console.WriteLine("Iphone faz ligacao");
        }

        public void ReceberMensagem()
        {
            Console.WriteLine("Iphone recebe mensagem");
        }
    }
}
