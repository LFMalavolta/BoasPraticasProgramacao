using System;
using static Lorenzo_Treinamentos.Aulas.Aula2_02_08.EnumTv;

namespace BoasPraticasProgramacao
{
    public class Televisao
    {
        public String marcaTv { get; set; }
        public int polegadasTv { get; set; }

        public Televisao()
        {

        }

        public Televisao(String marcaTv, int polegadas)
        {
            try
            {
                ValidarTv(marcaTv, polegadas);
                this.marcaTv = marcaTv;
                this.polegadasTv = polegadas;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw new Exception("error", e);
            }
        }

        private int ValidarTv(String marcaTv, int polegadas)
        {
            bool eTvInvalida = marcaTv.Equals("") || (polegadas < 0 || polegadas > 100);
            if (eTvInvalida)
            {
                throw new Exception("TV invalida");
            }
            else
            {
                return (int)retornoTv.Sucesso;
            }
        }
    }

    class TelevisaoNaoEncontrada : Televisao
    {
        public TelevisaoNaoEncontrada()
        {
            marcaTv = "";
            polegadasTv = 0;
        }
    }
}

