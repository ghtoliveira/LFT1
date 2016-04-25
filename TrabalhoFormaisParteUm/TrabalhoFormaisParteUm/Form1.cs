using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFormaisParteUm {
    public partial class Form1 : System.Windows.Forms.Form {
        

        public Form1() {
            InitializeComponent();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void btnSelecionarG_Click(object sender, EventArgs e) {
            Console.WriteLine("Gerador");
            Gramatica.simboloGerador = comboGerador.Text;
            OnSimboloAdicionado();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {
            
        }

        private void btnAdicionarNT_Click(object sender, EventArgs e) {
            if(radioRegular.Checked) {
                AdicionarSimbolosRegular.adicionarNaoTerminal(txtNaoTerminal.Text);
                txtNaoTerminal.Text = "";
                OnSimboloAdicionado();
            } else if (radioLivreDeContexto.Checked) {
                // Adicionar livre de contexto
            }
        }

        private void btnAdicionarT_Click(object sender, EventArgs e) {
            if (radioRegular.Checked) {
                AdicionarSimbolosRegular.adicionarTerminal(txtTerminal.Text);
                txtTerminal.Text = "";
                OnSimboloAdicionado();
            } else if (radioLivreDeContexto.Checked) {
                // Adicionar livre de contexto
            }
        }






        // Métodos próprios

        private void OnSimboloAdicionado() {
            labelGramatica.Text = Gramatica.atualizarLabelGramatica();
            ///TODO: Fazer com que isso só aconteça quando um NT é adicionado? 
            comboGerador.Items.Clear();
            foreach (string s in Gramatica.getNaoTerminais())
                comboGerador.Items.Add(s);

        }


    }
}
