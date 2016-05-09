using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFormaisParteUm
{
    static class AutomatoFinito
    {

        static List<Estado> estados = new List<Estado>();
        static Estado estadoAtual = new Estado();
        //static int charAtual = 0;


        static void ResetAutomato()
        {
            
            estadoAtual.estado = (char)65;
            estadoAtual.proximoEstado = ' ';
            estadoAtual.transicao = ' ';
        }
        
        public static void AdicionarTransicao(char de, char para, char transicao)
        {
            Estado novoEstado = new Estado();
            novoEstado.estado = de;
            novoEstado.proximoEstado = para;
            novoEstado.transicao = transicao;
            estados.Add(novoEstado);

        }

        public struct Estado
        {
            public char estado { get; set; }
            public char proximoEstado { get; set; }
            public char transicao { get; set; }
        }

        public static void adicionarGrid(DataGridView grid)
        {
            grid.ColumnCount = 3;
            grid.Columns[0].Name = "De";
            grid.Columns[1].Name = "Transicao";
            grid.Columns[2].Name = "Para";

            

            foreach (Estado estado in estados)
            {
                DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
                row.Cells[0].Value = estado.estado;
                row.Cells[1].Value = estado.transicao;
                row.Cells[2].Value = estado.proximoEstado;

                grid.Rows.Add(row);
            }

            //row.Cells[0].Value = expressao;

            //grid.Rows.Add(row);
        }

    }
}
