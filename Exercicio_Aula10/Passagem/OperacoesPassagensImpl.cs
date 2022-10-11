using Exercicio_Aula10.Enums;
using Exercicio_Aula10.Factorys;
using System;
using System.Collections.Generic;

namespace Exercicio_Aula10
{
    public class OperacoesPassagensImpl : IOperacoesPassagens
    {
        public List<Passagem> listaPassagens = new List<Passagem>();

        public Passagem MontarPassagem()
        {
            Console.WriteLine("Selecione o tipo de passagem:");
            Console.WriteLine("1- Digital   2- Impressa");
            string passagemSelecionada = Console.ReadLine();
            Console.WriteLine("\nDigite o valor da passagem:");
            string valorPassagem = Console.ReadLine();
            Console.WriteLine("\nDigite o local de embarque");
            string localEmbarque = Console.ReadLine();
            Console.WriteLine("\nDigite o local de desembarque");
            string localDembarque = Console.ReadLine();
            Console.WriteLine("\n1- Com seguro  2- Sem seguro");
            string possuiSeguro = Console.ReadLine();
            Console.WriteLine("\n1- Com poltrona especial  2- Sem poltrona especial");
            string possuiPoltronaEspecial = Console.ReadLine();
            Console.WriteLine("\nDigite o numero da poltrona");
            string numeroPoltrona = Console.ReadLine();

            Passagem passagemBuilder = new PassagemBuilder()
                                                .tipoPassagem(passagemSelecionada)
                                                .preco(decimal.Parse(valorPassagem))
                                                .localEmbarque(localEmbarque)
                                                .localDesembarque(localDembarque)
                                                .seguro(possuiSeguro == "1" ? true : false)
                                                .poltronaEspecial(possuiPoltronaEspecial == "1" ? true : false)
                                                .numeroPoltrona(int.Parse(numeroPoltrona))
                                                .montaPassagem();
            Console.WriteLine(passagemBuilder);
            return passagemBuilder;
        }

        public void ListarPassagens()
        {
            bool eListaPassagemVazia = listaPassagens.Count < 1;
            if (eListaPassagemVazia)
            {
                Console.WriteLine("Nenhuma passagem foi comprada\n");
                return;
            }
            listaPassagens.ForEach(Console.WriteLine);
        }

        public void ComprarPassagem()
        {
            DescontoBussines descontoBussines = new DescontoBussines();
            try
            {
                Passagem novaPassagem = MontarPassagem();
                descontoBussines.CalcularDescontos(novaPassagem);
                ValidaPassagem validaPassagem = new ValidaPassagem(novaPassagem);
                listaPassagens.Add(novaPassagem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}