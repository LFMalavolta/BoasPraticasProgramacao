using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;

namespace BoasPraticasProgramacao
{
    public class TvServico
    {
        List<Televisao> listaTelevisoes = new List<Televisao>();

        public void AdicionarTv(Televisao televisao)
        {
            try
            {
                ValidarTv(televisao);
                listaTelevisoes.Add(televisao);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw new Exception("Erro ao adicionar TV", e);
            }
        }

        public Optional<Televisao> buscaTelevisao(String marcaTv)
        {
            Televisao televisao = null;
            foreach (Televisao tv in listaTelevisoes)
            {
                if (tv.marcaTv.Equals(marcaTv))
                {
                    televisao = tv;
                }
            }
            if (televisao == null)
            {
                televisao = new TelevisaoNaoEncontrada();
            }
                return new Optional<Televisao>(televisao); 
        }

        private void ValidarTv(Televisao televisao)
        {
            if (televisao == null) throw new Exception("Objecto Tv esta null");

            bool eTvInvalida = televisao.marcaTv.Equals("") || (televisao.polegadasTv < 0 || televisao.polegadasTv > 100);
            if (eTvInvalida) throw new Exception("dados da tv estao incorretos");

        }
    }
}
