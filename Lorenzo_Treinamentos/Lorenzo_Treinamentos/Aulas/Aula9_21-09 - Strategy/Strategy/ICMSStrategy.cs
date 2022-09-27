using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula9_21_09.Strategy
{
    class ICMSStrategy : IImpostos
    {
        public double CalcularImpostos(double valor)
        {
            return valor * (10 - 2);
        }
    }
}
