
using System;

namespace Lorenzo_Treinamentos
{
    public class FabricaJanelas
    {
        public IJanelasGraficas CriarJanelaGrafica(EnumJanela tipoJanela)
        {
            if (tipoJanela.ToString().Equals("HTML"))
            {
                return new JanelaHTML();
            }
            else if (tipoJanela.ToString().Equals("Forms"))
            {
                return new JanelaForms();
            }
            throw new Exception("Janela invalida");
        }
    }
}
