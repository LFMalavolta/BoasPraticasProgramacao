using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula4_16_08
{
    class MySQLBancoDados : IBancoDados
    {
        public void salvar(Passagem passagem)
        {
            Console.WriteLine("salvando passagem no MySQL");
        }
    }
}
