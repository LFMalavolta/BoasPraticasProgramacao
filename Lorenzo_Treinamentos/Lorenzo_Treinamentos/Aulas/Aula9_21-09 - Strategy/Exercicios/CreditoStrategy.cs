using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula9_21_09___Strategy.Exercicios
{
    class CreditoStrategy : IMeiosPagamentos
    {
        public double CalcularValor(string nomeCliente, double valor)
        {
            File.AppendAllText("ComprasCredito.txt", "Cliente: " + nomeCliente + "pagou no valor: " + valor);
            return valor + ((3.5 / 100) * valor);
        }
    }
}
