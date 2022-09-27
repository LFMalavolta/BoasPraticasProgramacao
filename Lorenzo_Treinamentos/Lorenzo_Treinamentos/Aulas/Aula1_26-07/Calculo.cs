using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos
{
    public class Calculo
    {
        //Slide 14
        public int calcularValor(int valorA, int valorB)
        {
            int resultado = valorA + valorB;
            return resultado;
        }

        //Slide 19
        public void buscarChave(String id)
        {
            bool idInvalido = (id == null || id == "");
            if (idInvalido)
            {
                throw new Exception("id é invalido");
            }
            else
            {
                //processa o código
            }
        }

    }
}
