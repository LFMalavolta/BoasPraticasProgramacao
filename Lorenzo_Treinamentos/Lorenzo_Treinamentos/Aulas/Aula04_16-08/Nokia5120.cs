using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula4_16_08
{
    class Nokia5120 : ICelular
    {
        public void EnviarMensagem()
        {
            Console.WriteLine("Nokia enviando mensagem");
        }

        public void FazerLigacao()
        {
            Console.WriteLine("Nokia fazendo ligacao");
        }

        public void ReceberMensagem()
        {
            Console.WriteLine("Nokia recebendo mensagem");
        }
    }
}
