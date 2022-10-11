using System;

namespace Exercicio_Aula10
{
    internal class DescontoBussines
    {
        internal void CalcularDescontos(Passagem novaPassagem)
        {
            try
            {
            Descontos descontos = new Descontos();
            descontos.descontoDigital(novaPassagem);
            descontos.descontoSeguro(novaPassagem);
            descontos.descontoPoltronaEspecial(novaPassagem);
            descontos.descontoPoltronas(novaPassagem);
            novaPassagem.PrecoPassagem += descontos.getPrecoComDesconto();
            Console.WriteLine($"Preco após cálculos de descontos: {novaPassagem.PrecoPassagem}");
            }
            catch (Exception)
            {
                throw new Exception("Erro ao calcular descontos");
            }
        }
    }
}