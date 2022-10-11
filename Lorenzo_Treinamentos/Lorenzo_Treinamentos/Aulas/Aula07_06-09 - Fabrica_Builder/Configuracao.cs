using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos
{
    public class Configuracao
    {
        public string nomeAplicacao { get; set; }
        public int versaoAplicacao { get; set; }

        public static Configuracao instancia; //2 - Criar uma variavel static do tipo da classe com o nome "instancia"
        private Configuracao() //1 - Construtor deve ser privado
        {

        }

        public static Configuracao GetInstancia() //3 - Criar metodo static que instancia o objeto
        {
            if (instancia == null)
            {
                instancia =  new Configuracao();
                Console.WriteLine("Criando o objeto");
            }
            return instancia;
        }
    }
}
