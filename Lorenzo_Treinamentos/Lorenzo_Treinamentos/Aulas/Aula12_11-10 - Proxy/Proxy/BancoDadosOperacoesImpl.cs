using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{ 
    public class BancoDadosOperacoesImpl : IOperacoesBancoDados
    {
        public void Atualizar()
        {
            //string sql == "update tabelas...."
            Console.WriteLine("Update no banco");
        }

        public void Buscar()
        {
            Console.WriteLine("Select no banco");

        }

        public void Deletar()
        {
            Console.WriteLine("Delete no banco");

        }

        public void Salvar()
        {
            Console.WriteLine("Insert no banco");

        }
    }
}
