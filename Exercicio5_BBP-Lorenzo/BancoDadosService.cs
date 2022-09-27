using Exercicio5_BBP_Lorenzo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5_BBP_Lorenzo
{
    public class BancoDadosService
    {
        public IBancoDados bancoDados { get; set; }

        public BancoDadosService()
        {

        }

        public BancoDadosService(IBancoDados bancoDadosSelecionado)
        {
            this.bancoDados = bancoDadosSelecionado;
        }

        public void salvandoDado()
        {
            bancoDados.salvar();
        }

        public void removendoDado()
        {
            bancoDados.remover();
        }
    }
}
