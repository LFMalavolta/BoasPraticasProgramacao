namespace Lorenzo_Treinamentos.Aulas.Aula8
{
    public class NotaFiscal
    {
        public string Cabecalho { get; set; }
        public string ValorTotal { get; set; }
        public string Itens { get; set; }

        public override string ToString()
        {
            return (Cabecalho + "\n----------------\n" + Itens + "----------------\n" + ValorTotal);
        }

    }
}