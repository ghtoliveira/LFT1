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
            radioRegular.Checked = true;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void btnSelecionarG_Click(object sender, EventArgs e) {
            Gramatica.simboloGerador = comboGerador.Text;
            OnSimboloAdicionado();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {
            
        }

        private void btnAdicionarNT_Click(object sender, EventArgs e) {
            AdicionarSimbolosRegular.adicionarNaoTerminal(txtNaoTerminal.Text);
            txtNaoTerminal.Text = "";
            OnSimboloAdicionado();
            
        }

        private void btnAdicionarT_Click(object sender, EventArgs e) {
            AdicionarSimbolosRegular.adicionarTerminal(txtTerminal.Text, radioRegular.Checked);
            txtTerminal.Text = "";
            OnSimboloAdicionado();
        }






        // Métodos próprios

        private void OnSimboloAdicionado() {
            labelGramatica.Text = Gramatica.atualizarLabelGramatica();
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

            if (radioRegular.Checked) {
                if (AdicionarProducao.adicionarProducaoRegular(comboLadoEsquerdo.Text, txtLadoDireito.Text)) {
                    InicializadorUI.adicionarHeadersGrid(tableProducoes, new string[] { "Lado Esquerdo", "Lado Direito" });
                    InicializadorUI.adicionarItemsGrid(tableProducoes, new string[] { comboLadoEsquerdo.Text, txtLadoDireito.Text });
                    panelConjuntoProducoes.Enabled = true;
                }
            } else if (radioLivreDeContexto.Checked) {
                if (AdicionarProducao.adicionarProducaoLC(comboLadoEsquerdo.Text, txtLadoDireito.Text)) {
                    panelConjuntoProducoes.Enabled = true;
                    InicializadorUI.adicionarHeadersGrid(tableProducoes, new string[] { "Lado Esquerdo", "Lado Direito" });
                    InicializadorUI.adicionarItemsGrid(tableProducoes, new string[] { comboLadoEsquerdo.Text, txtLadoDireito.Text });
                }
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
            int tamanho = Int32.Parse(txtTamanhoMaximo.Text);
            string producao = gerador.gerarProducoesRegulares(labelSentenca, (tamanho > 0) ? tamanho : 10 );
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

        private void btnGerarSentencas_Click_1(object sender, EventArgs e) {
            GeradorDeProducoes gp = new GeradorDeProducoes();
            int tamanho = String.IsNullOrEmpty(txtTamanhoMaximo.Text) ? 10 : Int32.Parse(txtTamanhoMaximo.Text);
            gp.gerarProducoesRegulares(labelSentenca, tamanho);
        }

        private void btnVerificarGLC_Click(object sender, EventArgs e) {
            GramaticaLC.verificarGlc();
        }
    }
}
