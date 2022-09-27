using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{
    public class ManagementListenerTelefone
    {
        List<IListenerTelefone> listaListener = new List<IListenerTelefone>();

        public void AddListener(IListenerTelefone listenerTelefone)
        {
            this.listaListener.Add(listenerTelefone);
        }

        public void TocouTelefone(string mensagem)
        {
            foreach (IListenerTelefone listenerTelefone in listaListener)
            {
                listenerTelefone.TocouTelefone(mensagem);
            }
        }
    }
}
