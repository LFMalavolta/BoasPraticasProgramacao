using System;

namespace Exercicio_Aula10
{
    internal class Descontos
    {
        private decimal descontoPorcento;
        private decimal precoComDesconto;
        internal void descontoDigital(Passagem novaPassagem)
        {
            bool ePassagemDigital = novaPassagem.TipoPassagem.ToLower() == "passagem digital";
            if (ePassagemDigital)
            {
                descontoPorcento = ((decimal)5/ (decimal)100) * novaPassagem.PrecoPassagem;
                precoComDesconto -= descontoPorcento;
            }
        }

        internal void descontoSeguro(Passagem novaPassagem)
        {
            bool possuiSeguro = novaPassagem.Seguro == true;
            if (possuiSeguro)
            {
                descontoPorcento = ((decimal)3 / (decimal)100) * novaPassagem.PrecoPassagem;
                precoComDesconto += descontoPorcento;
            }
        }

        internal void descontoPoltronas(Passagem novaPassagem)
        {
            bool poltronaEntre1E20 = novaPassagem.NumeroPoltronas >= 1 && novaPassagem.NumeroPoltronas <= 20;
            if (poltronaEntre1E20)
            {
                descontoPorcento = ((decimal)15 / (decimal)100) * novaPassagem.PrecoPassagem;
                precoComDesconto -= descontoPorcento;
            }
        }

        internal void descontoPoltronaEspecial(Passagem novaPassagem)
        {
            bool possuiDescontoPoltronaEpecial = novaPassagem.PoltronaEspecial == true;
            if (possuiDescontoPoltronaEpecial)
            {
                descontoPorcento = ((decimal)10 / (decimal)100) * novaPassagem.PrecoPassagem;
                precoComDesconto -= descontoPorcento;
            }
        }

        internal decimal getPrecoComDesconto()
        {
            return precoComDesconto;
        }
    }
}