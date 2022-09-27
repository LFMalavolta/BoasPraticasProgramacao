using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao
{
    class CalculadoraPagamento
    {

        float resultadoFinal = 0;
                    public CalculadoraPagamento(Funcionario funcionario)
        {
                        validarFuncionario(funcionario);
                         resultadoFinal = calcularSalario(funcionario);
        }

        private void validarFuncionario(Funcionario funcionario)
        {

                             if (eFuncionarioInvalido(funcionario))
            {



                                    throw new Exception("Funcionario invalido");
            }
        }

        private bool eFuncionarioInvalido(Funcionario funcionario)
        {
            return funcionario.nome.Equals("") || funcionario.idade == 0;
        }


        private float calcularSalario(Funcionario funcionario)
        {
            float resultado = 0;
            float ACRESCIMO_PARA_JUNIOR = 0.1f;
            float ACRESCIMO_PARA_SENIOR = 0.2f;
            bool eSalrioJunior = funcionario.salario < 1000;
            bool eSalrioSenior = funcionario.salario > 1000;
            if (eSalrioJunior)
            {
                resultado = (funcionario.salario * ACRESCIMO_PARA_JUNIOR) + funcionario.salario;
            }
            if (eSalrioSenior)
            {
                resultado = (funcionario.salario * ACRESCIMO_PARA_SENIOR) + funcionario.salario;
            }
            return resultado;
        }

        public float retornaCalculoFuncionario()
        {
            return resultadoFinal;
        }

    }
}

