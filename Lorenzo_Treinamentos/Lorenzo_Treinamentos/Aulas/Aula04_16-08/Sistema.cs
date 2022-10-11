
namespace Lorenzo_Treinamentos.Aulas.Aula4_16_08
{
    public class Sistema
    {
        public IBancoDados bancoDados { get; set; }

        public Sistema(IBancoDados banco)
        {
            this.bancoDados = banco;
        }

        public void salvar(Passagem passagem)
        {
            bancoDados.salvar(passagem);
        }
    }

}
