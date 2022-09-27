using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula3_09_08
{
    public interface Usuario 
    {
        string cargo { get; set; }

        float salario { get; set; }

        float CalcularSalario();
    }
}
