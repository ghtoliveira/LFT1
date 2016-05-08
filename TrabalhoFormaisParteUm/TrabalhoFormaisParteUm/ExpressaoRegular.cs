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
        static string expressao;

        public static void SetarExpressao(DataGridView grid, string expressao)
        {
            grid.ColumnCount = 1;
            grid.Columns[0].Name = "Expressoes";

            DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
            
            row.Cells[0].Value = expressao;
            
            grid.Rows.Add(row);
        }
    }
}
