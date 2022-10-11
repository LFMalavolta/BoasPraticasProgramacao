using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula3_09_08
{
    public class ProcessaPagamento
    {
        public float ProcessarCalculo(Pagamento pagamento, float salario)
        {
            return pagamento.Calcular(salario); 
        }

        
    }
}
