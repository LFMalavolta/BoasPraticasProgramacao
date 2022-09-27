using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{
    public class TotalComprasComposite
    {
        List<TotalCompras> totalComprasLista = new List<TotalCompras>();

        public void AdicionarTotalCompras(TotalCompras totalCompra)
        {
            this.totalComprasLista.Add(totalCompra);
        }

        public int RetornaTotalCompras()
        {
            int totalComprasDia = 0;
            foreach (TotalCompras totalDaCompra in totalComprasLista)
            {
                totalComprasDia += totalDaCompra.TotalCompras(); 
            }
            return totalComprasDia;
        }
    }
}
