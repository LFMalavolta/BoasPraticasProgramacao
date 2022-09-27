using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula8
{
    public class NotaFiscalBuilder
    {
        private readonly NotaFiscal notaFiscal;

        public NotaFiscalBuilder()
        {
            notaFiscal = new NotaFiscal();
        }

        public NotaFiscalBuilder cabecalho(string cabecalho)
        {
            notaFiscal.Cabecalho = cabecalho;
            return this;
        }

        public NotaFiscalBuilder itens(string itens)
        {
            notaFiscal.Itens += (itens + "\n");
            return this;
        }

        public NotaFiscalBuilder valorTotal(int valorTotal)
        {
            notaFiscal.ValorTotal = "R$ " + valorTotal;
            return this;
        }

        public NotaFiscal montaNota()
        {
            return notaFiscal;
        }
    }
}
