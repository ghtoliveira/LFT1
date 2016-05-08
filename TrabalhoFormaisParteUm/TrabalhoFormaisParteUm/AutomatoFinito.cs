using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFormaisParteUm
{
    static class AutomatoFinito
    {

        static List<char> estados;
        static int estadoAtual;
        
        static void ResetAutomato()
        {
            estados = new List<char>();
            for (int i = 65; i <= 90; i++)
            {
                estados.Add((char)i);
            }
            estadoAtual = 0;
        }

        static void AdicionarTransacao(bool proximo)
        {
            
        }

    }
}
