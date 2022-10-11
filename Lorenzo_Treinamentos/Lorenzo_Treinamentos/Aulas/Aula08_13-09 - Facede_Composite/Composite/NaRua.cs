using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{
    public class NaRua : TotalCompras
    {
        int totalCompras;

        public void RealizarVendaRua(int totalCompra)
        {
            this.totalCompras += totalCompra;
        }

        public int TotalCompras()
        {
            return totalCompras;
        }
    }
}
