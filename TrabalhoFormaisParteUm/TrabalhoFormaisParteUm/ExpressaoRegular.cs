using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFormaisParteUm
{
    static class ExpressaoRegular
    {
        public static void SetarExpressao(DataGridView grid, string expressao)
        {
            grid.ColumnCount = 1;
            grid.Columns[0].Name = "Expressoes";

            DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
            
            row.Cells[0].Value = expressao;
            
            grid.Rows.Add(row);
        }

        public static bool Validacoes(string expressao)
        {
            //Se algum char nao for minúsculo
            if (expressao.Any(char.IsUpper))
            {
                MessageBox.Show("Expressões Regulares aceitam apenas letras minúsculas");
                return false;
            }


            //Parentesis equilibrados
            int numeroDeParentesesEsquerda = 0;
            int numeroDeParentesesDireita = 0;

            foreach (char s in expressao)
            {
                if (s.Equals((char)40))
                {
                    numeroDeParentesesEsquerda++;
                    Console.WriteLine("Parenteses Esquerdo: " + numeroDeParentesesEsquerda);
                }
                else if(s.Equals((char)41))
                {
                    numeroDeParentesesDireita++;
                    Console.WriteLine("Parenteses Direita: " + numeroDeParentesesDireita);
                }
            }

            //Check dos parenteses
            if(numeroDeParentesesEsquerda != numeroDeParentesesDireita)
            {
                MessageBox.Show("Parenteses não estão equilibrados!");
                return false;
            }

            return true;
        }
    }
}
