using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula4_16_08
{
    class LocalBancoDados : IBancoDados
    {
        public void salvar(Passagem passagem)
        {
            Console.WriteLine("Salvando banco de dados local");
        }
    }
}
