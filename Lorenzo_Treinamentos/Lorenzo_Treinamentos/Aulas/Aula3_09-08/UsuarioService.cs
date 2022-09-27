using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas.Aula3_09_08
{
	public class UsuarioService
	{
		List<Usuario> lista = new List<Usuario>();

		public void salvarUsuario(Usuario usuario)
		{
            try
            {
				CalculoSalario calculaSalario = new CalculoSalario();
				Optional<Usuario> optUsuario = validacaoUsuario(usuario);
				calculaSalario.CalcularSalario(usuario);
                lista.Add(usuario);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.StackTrace);
				throw e;
            }
		}

		private Optional<Usuario> validacaoUsuario(Usuario usuario)
		{

			if (string.IsNullOrEmpty(usuario.cargo))
			{
				throw new Exception("nome em branco");
			}
			return null;
		}

	}
}
