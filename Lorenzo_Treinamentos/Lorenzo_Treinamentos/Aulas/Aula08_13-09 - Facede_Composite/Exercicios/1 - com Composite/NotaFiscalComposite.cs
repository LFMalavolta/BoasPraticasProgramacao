using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{
    public class NotaFiscalComposite
    {
        List<IDadosLinha> listaNotaFiscal = new List<IDadosLinha>();
        IDadosLinha rodape = null;

        public void AdcionarCabecalho(IDadosLinha linhaParaInserir)
        {
            this.listaNotaFiscal.Insert(0, linhaParaInserir);
        }

        public void AdcionarRodape(IDadosLinha linhaParaInserir)
        {
            this.rodape = linhaParaInserir;
        }

        public void AdcionarLinhas(IDadosLinha linhaParaInserir)
        {
            this.listaNotaFiscal.Add(linhaParaInserir);
        }

        public string RetornaNotaFiscal()
        {
            string notaFiscal = "";

            foreach (IDadosLinha dadosLinha in listaNotaFiscal)
            {
                notaFiscal += dadosLinha.DadosLinhas();
                notaFiscal += "----------------\n";
            }
            notaFiscal += rodape;
            return notaFiscal;
        }
    }
}
