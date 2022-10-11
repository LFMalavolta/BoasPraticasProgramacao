using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{
     public class ValorNota : IDadosLinha
    {
        string stringLinha;

        public void InserirDadosNaLinha(string dadosParaInserir)
        {
            this.stringLinha += dadosParaInserir + "\n";
        }

        public string DadosLinhas()
        {
            return stringLinha;
        }
    }
}
