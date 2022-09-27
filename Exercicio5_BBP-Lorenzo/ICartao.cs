using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5_BBP_Lorenzo
{
    public interface ICartao : IFormaPagamento
    {
        public string BandeiraCartao { get; set; }
        public string InstituicaoProcessadora { get; set; }

        void ValidarPagamento(ICartao formaPagamento);
    }
}
