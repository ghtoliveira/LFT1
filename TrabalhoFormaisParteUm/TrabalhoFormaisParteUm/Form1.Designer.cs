namespace TrabalhoFormaisParteUm {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.radioRegular = new System.Windows.Forms.RadioButton();
            this.radioLivreDeContexto = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaoTerminal = new System.Windows.Forms.TextBox();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.btnAdicionarNT = new System.Windows.Forms.Button();
            this.btnAdicionarT = new System.Windows.Forms.Button();
            this.panelSimbolos = new System.Windows.Forms.Panel();
            this.btnCriarProducoes = new System.Windows.Forms.Button();
            this.btnSelecionarG = new System.Windows.Forms.Button();
            this.comboGerador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGramatica = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionarProducao = new System.Windows.Forms.Button();
            this.panelProducoes = new System.Windows.Forms.Panel();
            this.txtLadoDireito = new System.Windows.Forms.TextBox();
            this.txtLadoEsquerdo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableProducoes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panelConjuntoProducoes = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelSimbolos.SuspendLayout();
            this.panelProducoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableProducoes)).BeginInit();
            this.panelConjuntoProducoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioRegular
            // 
            this.radioRegular.AutoSize = true;
            this.radioRegular.Location = new System.Drawing.Point(3, 3);
            this.radioRegular.Name = "radioRegular";
            this.radioRegular.Size = new System.Drawing.Size(113, 17);
            this.radioRegular.TabIndex = 0;
            this.radioRegular.TabStop = true;
            this.radioRegular.Text = "Gramática Regular";
            this.radioRegular.UseVisualStyleBackColor = true;
            this.radioRegular.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioLivreDeContexto
            // 
            this.radioLivreDeContexto.AutoSize = true;
            this.radioLivreDeContexto.Location = new System.Drawing.Point(3, 26);
            this.radioLivreDeContexto.Name = "radioLivreDeContexto";
            this.radioLivreDeContexto.Size = new System.Drawing.Size(159, 17);
            this.radioLivreDeContexto.TabIndex = 1;
            this.radioLivreDeContexto.TabStop = true;
            this.radioLivreDeContexto.Text = "Gramática Livre de Contexto";
            this.radioLivreDeContexto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioLivreDeContexto);
            this.panel1.Controls.Add(this.radioRegular);
            this.panel1.Location = new System.Drawing.Point(55, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 53);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adicionar Símbolos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Não Terminal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Terminal:";
            // 
            // txtNaoTerminal
            // 
            this.txtNaoTerminal.Location = new System.Drawing.Point(100, 45);
            this.txtNaoTerminal.Name = "txtNaoTerminal";
            this.txtNaoTerminal.Size = new System.Drawing.Size(39, 20);
            this.txtNaoTerminal.TabIndex = 7;
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(100, 80);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(39, 20);
            this.txtTerminal.TabIndex = 8;
            // 
            // btnAdicionarNT
            // 
            this.btnAdicionarNT.Location = new System.Drawing.Point(174, 41);
            this.btnAdicionarNT.Name = "btnAdicionarNT";
            this.btnAdicionarNT.Size = new System.Drawing.Size(87, 23);
            this.btnAdicionarNT.TabIndex = 9;
            this.btnAdicionarNT.Text = "Adicionar NT";
            this.btnAdicionarNT.UseVisualStyleBackColor = true;
            this.btnAdicionarNT.Click += new System.EventHandler(this.btnAdicionarNT_Click);
            // 
            // btnAdicionarT
            // 
            this.btnAdicionarT.Location = new System.Drawing.Point(174, 80);
            this.btnAdicionarT.Name = "btnAdicionarT";
            this.btnAdicionarT.Size = new System.Drawing.Size(87, 23);
            this.btnAdicionarT.TabIndex = 10;
            this.btnAdicionarT.Text = "Adicionar T";
            this.btnAdicionarT.UseVisualStyleBackColor = true;
            this.btnAdicionarT.Click += new System.EventHandler(this.btnAdicionarT_Click);
            // 
            // panelSimbolos
            // 
            this.panelSimbolos.Controls.Add(this.btnCriarProducoes);
            this.panelSimbolos.Controls.Add(this.btnSelecionarG);
            this.panelSimbolos.Controls.Add(this.comboGerador);
            this.panelSimbolos.Controls.Add(this.label4);
            this.panelSimbolos.Controls.Add(this.btnAdicionarNT);
            this.panelSimbolos.Controls.Add(this.btnAdicionarT);
            this.panelSimbolos.Controls.Add(this.label1);
            this.panelSimbolos.Controls.Add(this.label2);
            this.panelSimbolos.Controls.Add(this.txtTerminal);
            this.panelSimbolos.Controls.Add(this.label3);
            this.panelSimbolos.Controls.Add(this.txtNaoTerminal);
            this.panelSimbolos.Location = new System.Drawing.Point(2, 92);
            this.panelSimbolos.Name = "panelSimbolos";
            this.panelSimbolos.Size = new System.Drawing.Size(274, 201);
            this.panelSimbolos.TabIndex = 11;
            // 
            // btnCriarProducoes
            // 
            this.btnCriarProducoes.Location = new System.Drawing.Point(90, 153);
            this.btnCriarProducoes.Name = "btnCriarProducoes";
            this.btnCriarProducoes.Size = new System.Drawing.Size(95, 23);
            this.btnCriarProducoes.TabIndex = 14;
            this.btnCriarProducoes.Text = "Criar Produções";
            this.btnCriarProducoes.UseVisualStyleBackColor = true;
            this.btnCriarProducoes.Click += new System.EventHandler(this.btnCriarProducoes_Click);
            // 
            // btnSelecionarG
            // 
            this.btnSelecionarG.Location = new System.Drawing.Point(174, 115);
            this.btnSelecionarG.Name = "btnSelecionarG";
            this.btnSelecionarG.Size = new System.Drawing.Size(87, 23);
            this.btnSelecionarG.TabIndex = 13;
            this.btnSelecionarG.Text = "Selecionar";
            this.btnSelecionarG.UseVisualStyleBackColor = true;
            this.btnSelecionarG.Click += new System.EventHandler(this.btnSelecionarG_Click);
            // 
            // comboGerador
            // 
            this.comboGerador.FormattingEnabled = true;
            this.comboGerador.Location = new System.Drawing.Point(100, 115);
            this.comboGerador.Name = "comboGerador";
            this.comboGerador.Size = new System.Drawing.Size(39, 21);
            this.comboGerador.TabIndex = 12;
            this.comboGerador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gerador:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelGramatica
            // 
            this.labelGramatica.AutoSize = true;
            this.labelGramatica.Location = new System.Drawing.Point(86, 324);
            this.labelGramatica.Name = "labelGramatica";
            this.labelGramatica.Size = new System.Drawing.Size(105, 13);
            this.labelGramatica.TabIndex = 15;
            this.labelGramatica.Text = "G:({S,A,B},{0,1},P,S)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lado Esquerdo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lado Direito";
            // 
            // btnAdicionarProducao
            // 
            this.btnAdicionarProducao.Location = new System.Drawing.Point(38, 106);
            this.btnAdicionarProducao.Name = "btnAdicionarProducao";
            this.btnAdicionarProducao.Size = new System.Drawing.Size(95, 23);
            this.btnAdicionarProducao.TabIndex = 15;
            this.btnAdicionarProducao.Text = "Adicionar Produção";
            this.btnAdicionarProducao.UseVisualStyleBackColor = true;
            this.btnAdicionarProducao.Click += new System.EventHandler(this.btnAdicionarProducao_Click);
            // 
            // panelProducoes
            // 
            this.panelProducoes.Controls.Add(this.txtLadoDireito);
            this.panelProducoes.Controls.Add(this.txtLadoEsquerdo);
            this.panelProducoes.Controls.Add(this.label7);
            this.panelProducoes.Controls.Add(this.label6);
            this.panelProducoes.Controls.Add(this.btnAdicionarProducao);
            this.panelProducoes.Controls.Add(this.label5);
            this.panelProducoes.Enabled = false;
            this.panelProducoes.Location = new System.Drawing.Point(43, 364);
            this.panelProducoes.Name = "panelProducoes";
            this.panelProducoes.Size = new System.Drawing.Size(174, 141);
            this.panelProducoes.TabIndex = 20;
            // 
            // txtLadoDireito
            // 
            this.txtLadoDireito.Location = new System.Drawing.Point(112, 50);
            this.txtLadoDireito.Name = "txtLadoDireito";
            this.txtLadoDireito.Size = new System.Drawing.Size(53, 20);
            this.txtLadoDireito.TabIndex = 22;
            // 
            // txtLadoEsquerdo
            // 
            this.txtLadoEsquerdo.Location = new System.Drawing.Point(9, 50);
            this.txtLadoEsquerdo.Name = "txtLadoEsquerdo";
            this.txtLadoEsquerdo.Size = new System.Drawing.Size(53, 20);
            this.txtLadoEsquerdo.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "->";
            // 
            // tableProducoes
            // 
            this.tableProducoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableProducoes.Location = new System.Drawing.Point(14, 25);
            this.tableProducoes.Name = "tableProducoes";
            this.tableProducoes.Size = new System.Drawing.Size(330, 205);
            this.tableProducoes.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Conjunto de Produções";
            // 
            // panelConjuntoProducoes
            // 
            this.panelConjuntoProducoes.Controls.Add(this.tableProducoes);
            this.panelConjuntoProducoes.Controls.Add(this.label8);
            this.panelConjuntoProducoes.Location = new System.Drawing.Point(304, 38);
            this.panelConjuntoProducoes.Name = "panelConjuntoProducoes";
            this.panelConjuntoProducoes.Size = new System.Drawing.Size(360, 287);
            this.panelConjuntoProducoes.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 570);
            this.Controls.Add(this.panelConjuntoProducoes);
            this.Controls.Add(this.panelProducoes);
            this.Controls.Add(this.labelGramatica);
            this.Controls.Add(this.panelSimbolos);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Trabalho Formais Parte Um";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSimbolos.ResumeLayout(false);
            this.panelSimbolos.PerformLayout();
            this.panelProducoes.ResumeLayout(false);
            this.panelProducoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableProducoes)).EndInit();
            this.panelConjuntoProducoes.ResumeLayout(false);
            this.panelConjuntoProducoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioRegular;
        private System.Windows.Forms.RadioButton radioLivreDeContexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaoTerminal;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Button btnAdicionarNT;
        private System.Windows.Forms.Button btnAdicionarT;
        private System.Windows.Forms.Panel panelSimbolos;
        private System.Windows.Forms.Button btnCriarProducoes;
        private System.Windows.Forms.Button btnSelecionarG;
        private System.Windows.Forms.ComboBox comboGerador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGramatica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionarProducao;
        private System.Windows.Forms.Panel panelProducoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLadoDireito;
        private System.Windows.Forms.TextBox txtLadoEsquerdo;
        private System.Windows.Forms.DataGridView tableProducoes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelConjuntoProducoes;
    }
}

