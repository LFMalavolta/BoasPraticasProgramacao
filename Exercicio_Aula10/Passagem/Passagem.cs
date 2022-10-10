using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula10
{
    public class Passagem
    {
        public string TipoPassagem { get; set; }
        public bool Seguro { get; set; }
        public bool PoltronaEspecial { get; set; }
        public int NumeroPoltronas { get; set; }
        public string LocalEmbarque { get; set; }
        public string LocalDesembarque { get; set; }
        public decimal PrecoPassagem { get; set; }

        public override string ToString()
        {
            return $"\nPassagem-------------------\nEmbarque em: {LocalEmbarque}\nDesembarque em: {LocalDesembarque}\n" +
                $"Valor: {PrecoPassagem}\nPoltrona nº{NumeroPoltronas}\n\nPossui seguro: {Seguro}" +
                $"\nPoltrona especial: {PoltronaEspecial}\n---------------------------";
        }

    }
}
