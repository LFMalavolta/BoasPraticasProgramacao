using System;

namespace Exercicio_Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            PassagemBussines passagemBussines = new PassagemBussines();
            DescontoBussines descontoBussines = new DescontoBussines();

            try
            {
                Passagem novaPassagem = passagemBussines.montaPassagem();
                descontoBussines.calculaDescontos(novaPassagem);
                ValidaPassagem validaPassagem = new ValidaPassagem(novaPassagem);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
