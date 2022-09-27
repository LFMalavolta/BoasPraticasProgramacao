using System;

namespace BoasPraticasProgramacao
{


    class FuncionarioService
    {
        Funcionario funcionario { get; set; }

        public int editarFuncionario(Funcionario funcionario)
        {
            int retorno = 0;
            try
            {
                ValidaFuncionario(funcionario);
                retorno = processaEditarFuncionarario(funcionario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }         
            return retorno;
        }
        public int processaEditarFuncionarario(Funcionario funcionario)
        {
            // processa a edicao do funcionario.
            bool sucessoEdicao = true;
            int sucessoNaEdicao = 1;

            if (sucessoEdicao)
            {
                return sucessoNaEdicao; // sucesso
            }
            else
            {
                throw new Exception("Erro ao editar o funcionário"); // error na edicao.
            }
        }
        private void ValidaFuncionario(Funcionario funcionario)
        {
            bool idFuncionarioIgualAZero = funcionario.id == 0;
            if (idFuncionarioIgualAZero)
            {
                throw new Exception("Funcionario deve ter um ID");
            }
        }
    }


}
