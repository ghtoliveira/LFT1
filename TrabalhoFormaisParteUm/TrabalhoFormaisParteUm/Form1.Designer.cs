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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCriarProducoes = new System.Windows.Forms.Button();
            this.btnSelecionarG = new System.Windows.Forms.Button();
            this.comboGerador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGramatica = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(12, 34);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCriarProducoes);
            this.panel2.Controls.Add(this.btnSelecionarG);
            this.panel2.Controls.Add(this.comboGerador);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnAdicionarNT);
            this.panel2.Controls.Add(this.btnAdicionarT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTerminal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNaoTerminal);
            this.panel2.Location = new System.Drawing.Point(222, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 201);
            this.panel2.TabIndex = 11;
            // 
            // btnCriarProducoes
            // 
            this.btnCriarProducoes.Location = new System.Drawing.Point(90, 153);
            this.btnCriarProducoes.Name = "btnCriarProducoes";
            this.btnCriarProducoes.Size = new System.Drawing.Size(95, 23);
            this.btnCriarProducoes.TabIndex = 14;
            this.btnCriarProducoes.Text = "Criar Produções";
            this.btnCriarProducoes.UseVisualStyleBackColor = true;
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
            this.labelGramatica.Location = new System.Drawing.Point(293, 239);
            this.labelGramatica.Name = "labelGramatica";
            this.labelGramatica.Size = new System.Drawing.Size(105, 13);
            this.labelGramatica.TabIndex = 15;
            this.labelGramatica.Text = "G:({S,A,B},{0,1},P,S)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 576);
            this.Controls.Add(this.labelGramatica);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Trabalho Formais Parte Um";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCriarProducoes;
        private System.Windows.Forms.Button btnSelecionarG;
        private System.Windows.Forms.ComboBox comboGerador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGramatica;
    }
}

