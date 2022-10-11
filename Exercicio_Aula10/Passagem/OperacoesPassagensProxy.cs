using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula10
{
    public class OperacoesPassagensProxy : IOperacoesPassagens
    {
        private IOperacoesPassagens operacoesPassagens;
        private List<string> logsSistema = new List<string>();

        public OperacoesPassagensProxy(IOperacoesPassagens operacoes)
        {
            this.operacoesPassagens = operacoes;
        }

        public void ComprarPassagem()
        {
            try
            {
                operacoesPassagens.ComprarPassagem();
                logsSistema.Add("###Passagem comprado com sucesso!###");
            }
            catch (Exception)
            {
                logsSistema.Add("###Compra de passagem falhou!###");
            }
        }

        public void ListarPassagens()
        {
            try
            {
                operacoesPassagens.ListarPassagens();
                logsSistema.Add("###Listando as passagens###");
            }
            catch (Exception)
            {
                logsSistema.Add("###Falha ao lista as passagens###");
            }
        }

        public void ListarLogs()
        {
            bool eListaLogsVazia = logsSistema.Count < 1;
            if (eListaLogsVazia)
            {
                Console.WriteLine("\nNenhuma log foi encontrado\n");
                return;
            }
            Console.WriteLine("----LOGS----");

            logsSistema.ForEach(Console.WriteLine);
        }
    }
}
