using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula10.Interfaces.Passagens
{
    public class PassagemImpressa : IPassagens
    {
        public void SelecionaPassagem()
        {
            Console.WriteLine("Passagem Digital selecionada");
        }
    }
}
