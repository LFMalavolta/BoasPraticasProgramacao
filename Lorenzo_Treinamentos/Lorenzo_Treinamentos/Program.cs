using Lorenzo_Treinamentos.Aulas;
using System;

namespace Lorenzo_Treinamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AULA 2
            ////EXERCICIO AULA 2
            //Televisao tv1 = new Televisao("samsung", 42);
            //TvServico cadastro = new TvServico();

            //Optional<Televisao> optTv = cadastro.buscaTelevisao("sony");
            //if (optTv.HasValue)
            //{
            //    Televisao tv = optTv.Value;
            //    Console.WriteLine(tv.marcaTv);
            //}
            //cadastro.AdicionarTv(tv1);
            #endregion

            #region AULA 3
            ////AULA 3
            //ProcessaPagamento processaPagamento = new ProcessaPagamento();
            //ProgramadorPagamento programadorPagamento = new ProgramadorPagamento();
            //float salarioProgamador = processaPagamento.ProcessarCalculo(programadorPagamento, 100f);

            //AnalistaPagamento analistaPagamento = new AnalistaPagamento();
            //float salarioAnalista = processaPagamento.ProcessarCalculo(analistaPagamento, 200f);
            #endregion

            #region AULA 4
            ////AULA 4
            //Iphone iphone = new Iphone();
            //Nokia5120 nokia = new Nokia5120();
            //iphone.ConectaInternet();
            //iphone.EnviarMensagem();
            //iphone.FazerLigacao();
            //iphone.ReceberMensagem();

            //nokia.EnviarMensagem();
            //nokia.FazerLigacao();
            //nokia.ReceberMensagem();

            ////
            //MySQLBancoDados mySqlbancoDados = new MySQLBancoDados();
            //LocalBancoDados localBancoDados = new LocalBancoDados();
            //SyBaseBancoDados syBase = new SyBaseBancoDados();

            //Sistema sistema = new Sistema(localBancoDados);
            //sistema.salvar(new Passagem());

            //sistema.bancoDados = syBase;
            //sistema.salvar(new Passagem());

            //sistema.bancoDados = mySqlbancoDados;
            //sistema.salvar(new Passagem());


            //Exercicio 2
            //LogNuvem logNuvem = new LogNuvem();
            //LogLocal logLocal = new LogLocal();

            //Calculadora calculadora = new Calculadora(logNuvem);
            //calculadora.somar(15,20);
            //calculadora.subtrair(15,20);

            //calculadora.log = logLocal;
            //calculadora.somar(15, 20);
            //calculadora.subtrair(15, 20);
            #endregion

            #region AULA 7
            ////Exercicio 1:
            //Configuracao config1 = Configuracao.GetInstancia();
            //config1.nomeAplicacao = "teste";
            //Configuracao config2 = Configuracao.GetInstancia();
            //config2.nomeAplicacao = "teste2";
            //Configuracao config3 = Configuracao.GetInstancia();
            //config2.nomeAplicacao = "teste3";
            //Console.ReadLine();

            ////Exercicio 2:
            //FabricaJanelas fabricaJanelas = new FabricaJanelas();
            //IJanelasGraficas janela = fabricaJanelas.CriarJanelaGrafica(EnumJanela.HTML);
            //janela.MostrarTela();
            //Console.ReadLine();

            //janela = fabricaJanelas.CriarJanelaGrafica(EnumJanela.Forms);
            //janela.MostrarTela();
            //Console.ReadLine();

            ////Exercicios:
            ////1
            //ConectaBanco banco1 = ConectaBanco.GetInstancia();
            //banco1.nomeBanco = "MySQL";
            //Console.WriteLine(banco1.nomeBanco);

            //ConectaBanco banco2 = ConectaBanco.GetInstancia();
            //banco2.nomeBanco = "SQL Server";
            //Console.WriteLine(banco1.nomeBanco);

            //ConectaBanco banco3 = ConectaBanco.GetInstancia();
            //banco3.nomeBanco = "PostGreSQL";
            //Console.WriteLine(banco1.nomeBanco);
            //Console.ReadLine();


            ////2
            //ExercicioBuilder testePedido = new ExercicioBuilder()
            //                                                .para("José")
            //                                                .com(1, "Motocicleta")
            //                                                .com(2, "Capacete");
            //Console.WriteLine("Pedido final: " + testePedido);

            #endregion

            #region AULA 8
            ////Facede
            //Pedido pedido = new Pedido();
            //FacedePedido facedePedido = new FacedePedido();
            //facedePedido.RealizarPedido(pedido);

            ////Composite
            //NaRua naRua = new NaRua();
            //naRua.RealizarVendaRua(50);
            //naRua.RealizarVendaRua(90);
            //Online online = new Online();
            //online.RealizarVendaOnline(20);
            //online.RealizarVendaOnline(120);

            //TotalComprasComposite totalComprasComposite = new TotalComprasComposite();
            //totalComprasComposite.AdicionarTotalCompras(naRua);
            //totalComprasComposite.AdicionarTotalCompras(online);
            //int totalComprasDia = totalComprasComposite.RetornaTotalCompras();
            //Console.WriteLine("Total de vendas no dia: R$" + totalComprasDia);


            ////Exercicios:
            ////1 - Com Composite
            //NumeroNota numeroNota = new NumeroNota();
            //numeroNota.InserirDadosNaLinha("Nota 1");

            //ItensNota itens = new ItensNota();
            //itens.InserirDadosNaLinha("Sapato");
            //itens.InserirDadosNaLinha("Meia");
            //itens.InserirDadosNaLinha("Tenis");

            //ValorNota valorNota = new ValorNota();
            //valorNota.InserirDadosNaLinha("R$ 567,38");

            //NotaFiscalComposite notaFiscalComposite = new NotaFiscalComposite();
            //notaFiscalComposite.AdcionarLinhas(itens);
            //notaFiscalComposite.AdcionarLinhas(valorNota);
            //notaFiscalComposite.AdcionarCabecalho(numeroNota);
            //string notaFiscal = notaFiscalComposite.RetornaNotaFiscal();
            //Console.WriteLine(notaFiscal + "\n\n");

            ////1 - Com Builder
            //NotaFiscal notaFiscalBuilder = new NotaFiscalBuilder()
            //                                                .itens("Sapato")
            //                                                .itens("Tenis")
            //                                                .cabecalho("Nota 2")
            //                                                .itens("Chinelo")
            //                                                .itens("Calça")
            //                                                .valorTotal(150)
            //                                                .montaNota();
            //Console.WriteLine(notaFiscalBuilder);

            #endregion

            # region AULA 9
            ////Strategy
            //ImpostoContext impostoContext = new ImpostoContext();
            //IImpostos impostos = impostoContext.GetStrategy("IPI");
            //double valorImposto = impostos.CalcularImpostos(200);
            //Console.WriteLine("Calculo 1: " + valorImposto);

            //valorImposto = impostoContext.CalcularImpostos("IPI", 200);
            //Console.WriteLine($"Calculo 2: {valorImposto}");

            ////Exercicio 1:
            //MeiosPagamentoContext meiosPagamento = new MeiosPagamentoContext();
            //double valorTotal = meiosPagamento.CalcularValorMeioPagamento("Credito", "Lorenzo", 250);
            //Console.WriteLine($"Credito: {valorTotal}");

            //valorTotal = meiosPagamento.CalcularValorMeioPagamento("Debito", "Lorenzo2", 250);
            //Console.WriteLine($"Debito: {valorTotal}");

            //valorTotal = meiosPagamento.CalcularValorMeioPagamento("PIX", "Lorenzo3", 250);
            //Console.WriteLine($"PIX: {valorTotal}");

            //Observer Exemplo
            DevListener devListener = new DevListener();
            SecretariaListener secretariaListener = new SecretariaListener();
            Telefone telefone = new Telefone();
            telefone.AdicionarListener(devListener);
            telefone.AdicionarListener(secretariaListener);
            while (true)
            {
                Console.WriteLine("Digite a mensagem para tocar o telefone:");
                string mensagameTelefone = Console.ReadLine();
                if (mensagameTelefone.ToLower() == "sair")
                {
                    break;
                }
                telefone.mensagem = mensagameTelefone;
            }

            #endregion

            Console.ReadLine();
        }
    }
}
