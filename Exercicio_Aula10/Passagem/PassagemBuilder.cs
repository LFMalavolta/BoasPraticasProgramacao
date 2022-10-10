using Exercicio_Aula10.Factorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula10
{
    public class PassagemBuilder
    {
        private readonly Passagem passagem;

        public PassagemBuilder()
        {
            passagem = new Passagem();
        }

        public PassagemBuilder tipoPassagem(string passagemSelecionada)
        {
            FactoryPassagens factoryPassagens = new FactoryPassagens();
            IPassagens passagens = factoryPassagens.CriarPassagem(int.Parse(passagemSelecionada));
            passagem.TipoPassagem = passagens.SelecionaPassagem();
            return this;
        }

        public PassagemBuilder seguro(bool seguro)
        {
            passagem.Seguro = seguro;
            return this;
        }
        public PassagemBuilder poltronaEspecial(bool poltronaEspecial)
        {
            passagem.PoltronaEspecial = poltronaEspecial;
            return this;
        }
        public PassagemBuilder numeroPoltrona(int poltrona)
        {
            passagem.NumeroPoltronas = poltrona;
            return this;
        }
        public PassagemBuilder localEmbarque(string localEmbarque)
        {
            passagem.LocalEmbarque= localEmbarque;
            return this;
        }
        public PassagemBuilder localDesembarque(string localDesembarque)
        {
            passagem.LocalDesembarque = localDesembarque;
            return this;
        }
        public PassagemBuilder preco(decimal preco)
        {
            passagem.PrecoPassagem = preco;
            return this;
        }

        public Passagem montaPassagem()
        {
            return passagem;
        }

    }
}
