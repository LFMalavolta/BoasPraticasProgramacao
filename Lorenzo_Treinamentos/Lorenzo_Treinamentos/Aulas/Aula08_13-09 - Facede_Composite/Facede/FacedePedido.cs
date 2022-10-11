using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{
    public class FacedePedido
    {
        ModuloEstoque moduloEstoque = new ModuloEstoque();
        ModuloFinanceiro moduloFinanceiro = new ModuloFinanceiro();
        ModuloPosVenda moduloPosVenda = new ModuloPosVenda();

        public void RealizarPedido(Pedido pedido)
        {
            Console.WriteLine("### PROCESSANDO PEDIDO ###");
            moduloEstoque.EnviarPedido(pedido);
            moduloFinanceiro.Faturar(pedido);
            moduloPosVenda.AgendarContatoCliente(pedido);
        }
    }
}
