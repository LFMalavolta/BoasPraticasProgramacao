using System;

namespace Exercicio_Aula10
{
    internal class ValidaPassagem
    {
        public ValidaPassagem(Passagem novaPassagem)
        {
            if (novaPassagem == null) throw new Exception("Passagem com informações incompletas");
        }
    }
}