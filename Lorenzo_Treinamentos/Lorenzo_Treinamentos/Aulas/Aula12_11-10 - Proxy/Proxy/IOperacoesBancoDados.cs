using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo_Treinamentos.Aulas
{
    public interface IOperacoesBancoDados
    {
        void Salvar();
        void Deletar();
        void Buscar();
        void Atualizar();
    }
}
