using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula3_09_08
{
    public class ProgramadorPagamento : Pagamento
    {
        public float Calcular(float salario)
        {
            return salario + (salario * 0.30f);
        }
    }
}
