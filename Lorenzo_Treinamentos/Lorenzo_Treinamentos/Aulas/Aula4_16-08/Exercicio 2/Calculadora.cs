using Lorenzo_Treinamentos.Aulas.Aula4_16_08.Exercicio_2;

namespace BoasPraticasProgramacao
{
    public class Calculadora
    {
        public Log log { get; set; }

        public Calculadora(Log log)
        {
            this.log = log;
        }
        
        public int somar(int primeiroNumero, int segundoNumero)
        {
            log.log("CHAMANDO SOMA");
            return primeiroNumero + segundoNumero;
        }

        public int subtrair(int primeiroNumero, int segundoNumero)
        {
            log.log("CHAMANDO SUBTRAIR");
            return primeiroNumero - segundoNumero;
        }
    }
}
