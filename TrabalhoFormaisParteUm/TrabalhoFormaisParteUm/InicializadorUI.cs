using System;
using System.Collections.Generic;
using System.Windows.Forms;


/// <summary>
/// Classe usada para iniciar elementos da UI, adicionar headers, etc. assim ó código fica mais limpo e sem genérico.
/// 
/// </summary>
namespace TrabalhoFormaisParteUm {
    static class InicializadorUI {
        public static void adicionarHeadersGrid(DataGridView grid,string[] headers) {
            grid.ColumnCount = headers.Length;
            int pos = 0;
            foreach (string s in headers) {
                grid.Columns[pos].Name = s;
                pos++;
            }
        }

        public static void adicionarItemsGrid(DataGridView grid, string[] items) {
            DataGridViewRow row = (DataGridViewRow)grid.Rows[grid.Rows.Count-1].Clone();
            for (int i = 0; i < row.Cells.Count; i++) {
                row.Cells[i].Value = items[i];
            }
            grid.Rows.Add(row);
        }

        public static void resetarGrid(DataGridView grid)
        {
            /*
            for (int i = 0; i < grid.Rows.Count-1; i++)
            {
                grid.Rows.Remove(grid.Rows[i]);
            }
            */

            grid.DataSource = null;
            grid.Rows.Clear();
            
        }

    }
}
