using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lorenzo_Treinamentos.Aulas.Aula9_21_09___Strategy.Exercicios;

namespace Lorenzo_Treinamentos.Aulas
{
    public class MeiosPagamentoContext
    {
        public double CalcularValorMeioPagamento(string meioPagamento, string nomeCliente, double valor)
        {
            if (meioPagamento == "Credito")
            {
                return new CreditoStrategy().CalcularValor(nomeCliente, valor);
            }

            if (meioPagamento == "Debito")
            {
                return new DebitoStrategy().CalcularValor(nomeCliente, valor);
            }

            if (meioPagamento == "PIX")
            {
                return new PixStrategy().CalcularValor(nomeCliente, valor);
            }

            throw new Exception("Meio de pagamento incorreto");
        }
    }
}
