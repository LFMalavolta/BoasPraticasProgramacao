using Exercicio5_BBP_Lorenzo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5_BBP_Lorenzo
{
    public class RegistroPagamento
    {
        public void RegistrarPagamento(Venda vendaAtual)
        {
            Console.WriteLine("Registrando compra no banco de dados selecionado... Aguarde...");
            switch (vendaAtual.BancoDados)
            {
                case 0:
                    BancoDadosService bancoDadosService = new BancoDadosService(new MySQL());
                    bancoDadosService.salvandoDado();
                    break;

                case 1:
                    bancoDadosService = new BancoDadosService(new SQLServer());
                    bancoDadosService.salvandoDado();
                    break;
            }


        }
    }
}
