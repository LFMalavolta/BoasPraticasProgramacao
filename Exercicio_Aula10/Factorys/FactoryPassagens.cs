using Exercicio_Aula10.Enums;
using Exercicio_Aula10.Interfaces.Passagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula10.Factorys
{
    public class FactoryPassagens
    {
        public IPassagens CriarPassagem(int tipoPassagem)
        {
            if (tipoPassagem == 1)
            {
                return new PassagemDigital();
            }
            else if (tipoPassagem == 2)
            {
                return new PassagemImpressa();
            }
            throw new Exception("Passagem inválida");
        }
    }
}
