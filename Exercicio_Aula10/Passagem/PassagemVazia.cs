namespace Exercicio_Aula10
{
    internal class PassagemVazia : Passagem
    {
        public PassagemVazia()
        {
            TipoPassagem = "";
            Seguro = false;
            PoltronaEspecial = false;
            NumeroPoltronas = 0;
            LocalEmbarque = "";
            LocalDesembarque = "";
            PrecoPassagem = 0;
        }
    }
}