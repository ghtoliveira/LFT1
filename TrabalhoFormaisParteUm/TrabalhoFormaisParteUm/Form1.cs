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
            comboLadoEsquerdo.Items.Clear();
            foreach (string s in Gramatica.getNaoTerminais()) {
                comboGerador.Items.Add(s);
                comboLadoEsquerdo.Items.Add(s);
            }

        }

        private void btnCriarProducoes_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(Gramatica.simboloGerador))
                MessageBox.Show("Você precisa selecionar um símbolo gerador para sua gramática antes de criar produções.", "Adicione um símbolo gerador");
            else {
                panelProducoes.Enabled = true;
                panelSimbolos.Enabled = false;
            }
        }

        private void btnAdicionarProducao_Click(object sender, EventArgs e) {
            ///Todo: Adicionar campo na tabela apenas se ele foi adicionar à produção, não adicionar o header toda vez que fizer uma inserção, impedir o usuário de adicionar
            ///novos rows à tabela por meio da UI. (Mudar a propriedade enableUserToAddRows pra false não funciona, ele acaba proibindo o próprio programa de adicionar
            ///rows também pro meio de código.

            if (AdicionarProducaoRegular.adicionarProducao(comboLadoEsquerdo.Text, txtLadoDireito.Text)) {
                InicializadorUI.adicionarHeadersGrid(tableProducoes, new string[] { "Lado Esquerdo", "Lado Direito" });
                InicializadorUI.adicionarItemsGrid(tableProducoes, new string[] { comboLadoEsquerdo.Text, txtLadoDireito.Text });
            }
            

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnAdicionarSimbolos_Click(object sender, EventArgs e) {
            panelSimbolos.Enabled = true;
            panelTipoGramatica.Enabled = false;
        }

        private void btnGerarSentencas_Click(object sender, EventArgs e) {
            GeradorDeProducoes gerador = new GeradorDeProducoes();
            string producao = gerador.gerarProducoesRegulares();
            
        }

        private void adicionaExpressao_Click(object sender, EventArgs e)
        {
            if (ExpressaoRegular.Validacoes(inputExpressoes.Text))
            {
                ExpressaoRegular.SetarExpressao(tableExpressoes, inputExpressoes.Text);
            }
        }

        private void adicionarAutomato_Click(object sender, EventArgs e)
        {
            AutomatoFinito.AdicionarTransicao('A', 'B', 'a');
            AutomatoFinito.AdicionarTransicao('B', 'A', 'b');
            AutomatoFinito.AdicionarTransicao('B', 'C', 'c');
            AutomatoFinito.AdicionarTransicao('A', 'A', 'c');

            AutomatoFinito.adicionarGrid(automatoFinito);
        }
    }
}
