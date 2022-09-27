using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula7_06_09.Exercicios
{
    public class ExercicioBuilder
    {
		List<Item> itens = new List<Item>();
		Cliente cliente;

		public ExercicioBuilder com(int quantidade, String nome)
		{
			Item itemAdicionado = new Item(nome, quantidade);
			itens.Add(itemAdicionado);
			Console.WriteLine("Adicionado " + quantidade + " " + nome + "ao pedido!");
			return this;
		}

		public ExercicioBuilder para(String nome)
		{
			cliente = new Cliente(nome);
			Console.WriteLine("Pedido será enviado para: " + nome);
			return this;
		}

		public void fechar()
		{
			// ...
		}
	}
}
