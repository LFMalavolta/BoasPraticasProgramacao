using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{
    public class BancoDadosOperacoesProxy : IOperacoesBancoDados
    {
        private IOperacoesBancoDados operacoesBancoImpl;
        public BancoDadosOperacoesProxy(IOperacoesBancoDados operacoesBancoDados)
        {
            this.operacoesBancoImpl = operacoesBancoDados;
        }
        public void Atualizar()
        {
            DateTime dataInicio = DateTime.Now;
            Console.WriteLine("BEGIN TRANSACTION");
            try
            {
                Thread.Sleep(1000);
                operacoesBancoImpl.Atualizar();
                Console.WriteLine("COMMIT TRANSACTION");
            }
            catch (Exception ex)
            {

                Console.WriteLine("ROOLBACK TRANSACTION");

            }
            DateTime dataFim = DateTime.Now;
            Console.WriteLine(dataFim.Subtract(dataInicio)); 

        }

        public void Buscar()
        {
            Console.WriteLine("BEGIN TRANSACTION");
            try
            {
                operacoesBancoImpl.Buscar();
                Console.WriteLine("COMMIT TRANSACTION");
            }
            catch (Exception ex)
            {

                Console.WriteLine("ROOLBACK TRANSACTION");

            }
        }

        public void Deletar()
        {
            Console.WriteLine("BEGIN TRANSACTION");
            try
            {
                operacoesBancoImpl.Deletar();
                Console.WriteLine("COMMIT TRANSACTION");
            }
            catch (Exception ex)
            {

                Console.WriteLine("ROOLBACK TRANSACTION");

            }
        }

        public void Salvar()
        {
            Console.WriteLine("BEGIN TRANSACTION");
            try
            {
                operacoesBancoImpl.Salvar();
                Console.WriteLine("COMMIT TRANSACTION");
            }
            catch (Exception ex)
            {

                Console.WriteLine("ROOLBACK TRANSACTION");

            }
        }
    }
}
