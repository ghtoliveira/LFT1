using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFormaisParteUm
{
    static class AutomatoFinito
    {

        static List<Estado> estados = new List<Estado>();
        static Estado estadoAtual = new Estado();
        static int charAtual = 0;


        static void ResetAutomato()
        {
            
            estadoAtual.estado = (char)65;
            estadoAtual.proximoEstado = ' ';
            estadoAtual.transacao = ' ';

            
        }
        
        static void AdicionarTransacao(bool proximo)
        {
            
        }

        public struct Estado
        {
            public char estado { get; set; }
            public char proximoEstado { get; set; }
            public char transacao { get; set; }
        }

    }
}
