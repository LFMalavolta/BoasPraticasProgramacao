using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{
    public class SecretariaListener : IListenerTelefone
    {
        public void TocouTelefone(string mensagem)
        {
            Console.WriteLine("Secretaria: Bom dia!!!");
        }
    }
}
