using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula7_06_09.Exercicios
{
    public class ConectaBanco
    {
        public string nomeBanco { get; set; }
        public int enderecoBanco { get; set; }

        public static ConectaBanco instancia; //2

        private ConectaBanco() //1
        {

        }

        public static ConectaBanco GetInstancia() //3
        {
            if (instancia == null)
            {
                instancia = new ConectaBanco();
                Console.WriteLine("Criado novo objeto ConectaBanco");
            }
            return instancia;
        }

    }
}
