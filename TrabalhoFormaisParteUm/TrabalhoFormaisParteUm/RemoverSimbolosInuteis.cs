using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFormaisParteUm
{
    public static class RemoverSimbolosInuteis
    {
        public static void Remover(DataGridView tabela, DataGridView outraTabela)
        {
            //ESTEREIS
            List<Producao> producoes = Gramatica.getProducoes(); // retorna as produções já adicionadas
            
            List<Producao> producoesParaRemover = new List<Producao>();
            

            bool achouEsteril = false;

            foreach (Producao p in producoes) // para cada produção, ou seja, para cada lado esquerdo
            {
                int prodComNaoTerminais = 0; // variavel utilizada para contar quantos nao terminais existem do lado direito
                int prodComMesmoNaoTerminal = 0; // variavel utilizada para ver quantos desses nao terminais sao iguais ao lado direito

                foreach (string dir in p.direitos) // Para cada lado direito
                {
                    if (dir.Any(char.IsUpper)) // Checando se tem NT
                    {
                        prodComNaoTerminais++;
                        if (dir.Contains(p.esquerdo)) // Checa se o NT é igual ao lado esquerdo
                        {
                            prodComMesmoNaoTerminal++;
                        }
                        
                    }
                }

                if(prodComNaoTerminais == p.direitos.Count) //se o numero de produções com NT é igual ao numero total de produções daquele lado esquerdo
                {
                    if(prodComNaoTerminais == prodComMesmoNaoTerminal)
                    {
                        // QUER DIZER QUE TEM SIMBOLOS ESTEREIS
                        //TODO REMOVER OS SIMBOLOS
                        //Gramatica.removerProducao(p);
                        achouEsteril = true;
                        producoesParaRemover.Add(p); // Guarda as producoes para remover depois
                    }
                }
            }



            #region Remoção de Estereis
            if (achouEsteril) // Se achou estéril
            {
                List<string> direitosParaRemover = new List<string>(); // Lista para armazenar os direitos que serão removidos
                //Remove Producoes Estereis
                foreach (Producao remover in producoesParaRemover) // Para cada uma que tem que ser removida
                {
                    foreach (Producao prod in producoes) // Para cada produção restante das originais
                    {
                        foreach (string dir in prod.direitos) // Para cada lado direito das produções originais
                        {
                            if (dir.Contains(remover.esquerdo)) // Se cada lado direito contem o simbolo que esta sendo removido
                            {
                                direitosParaRemover.Add(dir); // Adiciona na lista de direitos para remover
                            }
                        }
                        Gramatica.removerLadoDireito(prod, direitosParaRemover); // Remove os lados direitos que tinham o simbolo removido
                    }
                    Gramatica.removerProducao(remover); // Remove a produção da Gramática
                }
            }
            else
            {
                MessageBox.Show("Não foram encontrados simbolos estereis");
            }
            #endregion


            //INALCANÇAVEIS
            producoes = Gramatica.getProducoes(); // Produções depois de serem verificados simbolos estereis
            producoesParaRemover = new List<Producao>();
            bool houveInalcancaveis = false;
            
            for (int i = 0; i < producoes.Count; i++)
            {
                bool temInalcancavel = true;
                if (producoes[i].esquerdo != Gramatica.simboloGerador) //Se Não for analizar o simbolo gerador
                {
                    
                    for (int j = 0; j < producoes.Count; j++) // Para cada lado esquerdo que terá seu lado direito comparado
                    {
                        if (producoes[i].esquerdo != producoes[j].esquerdo)
                        {
                            foreach (string dir in producoes[j].direitos) // Cada lado direito que será comparado
                            {
                                if (dir.Contains(producoes[i].esquerdo)) // Se algum lado direito contem o lado esquerdo em questao
                                {
                                    temInalcancavel = false; // Possui simbolo alcançavel
                                }
                            }
                        }
                    }
                }
                else
                {
                    temInalcancavel = false; // Para evitar de ser removido o simbolo gerador
                }

                if (temInalcancavel) // Se nao for constatado que nao existe inalcançavel
                {
                    Gramatica.removerProducao(producoes[i]); // Remove produção inalcançavel
                    houveInalcancaveis = true;
                }
                
            }

            if (!houveInalcancaveis)
            {
                MessageBox.Show("Não houve produções inalcançáveis");
            }

            #region Repopula a Grid
            //Repopular a Grid com as produções novas
            InicializadorUI.resetarGrid(tabela);

            foreach (Producao producoesNovas in Gramatica.getProducoes())
            {
                InicializadorUI.adicionarHeadersGrid(tabela, new string[] { "Lado Esquerdo", "Lado Direito" });
                foreach (string dir in producoesNovas.direitos)
                {
                    InicializadorUI.adicionarItemsGrid(tabela, new string[] { producoesNovas.esquerdo, dir });
                }
                
            }
            #endregion
        }
    }
}
