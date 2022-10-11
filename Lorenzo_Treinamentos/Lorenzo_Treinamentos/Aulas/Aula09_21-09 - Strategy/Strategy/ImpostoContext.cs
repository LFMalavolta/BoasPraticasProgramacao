using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula9_21_09.Strategy
{
    public class ImpostoContext
    {
        public IImpostos GetStrategy(string tipoImposto)
        {
            if (tipoImposto == "ICMS")
            {
                return new ICMSStrategy();
            }
            else if (tipoImposto == "IPI")
            {
                return new IPIStrategy();
            }
            else
            {
                throw new Exception("Tipo imposto invalido");
            }
        }

        public double CalcularImpostos(string tipoImposto, double valor)
        {
            if (tipoImposto == "ICMS")
            {
                return new ICMSStrategy().CalcularImpostos(valor);
            }
            else if (tipoImposto == "IPI")
            {
                return new IPIStrategy().CalcularImpostos(valor);
            }
            else
            {
                throw new Exception("Tipo imposto invalido");
            }
        }
    }
}
