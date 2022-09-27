using BoasPraticasProgramacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula4_16_08.Exercicio_2
{
    public class LogNuvem : Log
    {
        public void log(string texto)
        {
            Console.WriteLine(texto + "Salvo direto na nuvem");
        }
    }
}
