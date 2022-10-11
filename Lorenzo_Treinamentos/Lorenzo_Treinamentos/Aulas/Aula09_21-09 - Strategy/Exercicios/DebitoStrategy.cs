using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula9_21_09___Strategy.Exercicios
{
    class DebitoStrategy : IMeiosPagamentos
    {
        public double CalcularValor(string nomeCliente, double valor)
        {
            return valor + ((5.5 / 100) * valor);
        }
    }
}
