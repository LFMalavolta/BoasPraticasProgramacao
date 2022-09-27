using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula3_09_08
{
    class ProfessorPagamento : Usuario
    {
        public string cargo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float salario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public float CalcularSalario()
        {
            return salario + (salario * 5f);
        }
    }
}
