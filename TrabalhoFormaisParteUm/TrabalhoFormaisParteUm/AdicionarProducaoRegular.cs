using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TrabalhoFormaisParteUm {
    static class AdicionarProducaoRegular {

        public static void adicionarProducao(string ladoEsquerdo, string ladoDireito) {


            ///Não to usando else if pq se uma verificação falhar o código para, então não tem pq usar...

            //Verifica se o usuário não está tentando adicionar uma produção vazia ou se o usuário não está tentando adicionar uma produção inválida
            if (String.IsNullOrWhiteSpace(ladoEsquerdo) || String.IsNullOrWhiteSpace(ladoDireito)) {
                MessageBox.Show("Produções não podem estar vazias.", "Verifique sua produção");
                return;
            } else if (ladoEsquerdo.Length > 1 || ladoDireito.Length > 2) {
                MessageBox.Show("Lado esquerdo deve conter apenas um símbolo.\nLado direito deve conter no máximo dois símbolos.", "Verifique sua produção");
                return;
            }

            //Verifica se a produção já existe
            foreach (Producao p in Gramatica.getProducoes()) {

                if (p.direito == ladoDireito && p.esquerdo == ladoEsquerdo) {
                    MessageBox.Show("Produção já adicionada, tente novamente!", "Verifique sua produção.");
                    return;
                }
            }

            //Verifica se o lado esquerdo está nos não terminais
            if (!Gramatica.getNaoTerminais().Contains(ladoEsquerdo)) {
                MessageBox.Show("Símbolo não terminal não está na gramática, tente com um símbolo adicionado previamente.", "Verifique seu símbolo");
                return;
            }

            //Verifica se o primeiro símbolo é um não terminal que foi adicionado ao conjunto de gramáticas anteriormente
            if (!Gramatica.getTerminais().Contains(ladoDireito[0].ToString())) {
                MessageBox.Show("Primeiro símbolo da produção não está na gramática, tente novamente.", "Verifique sua produção.");
                return;
            }

            //E se for uma produção com dois símbolos ex: aS verifica se o segundo símbolo é um não terminal que foi adicionado à gramática anteriormente
            if (ladoDireito.Length > 1) {
                if (!Gramatica.getNaoTerminais().Contains(ladoDireito[1].ToString())) {
                    MessageBox.Show("Segundo símbolo da produção não está na gramática, tente novamente.", "Verifique sua produção.");
                    return;
                }
            }


            //Adiciona a produção ao conjunto de produções pois passo por todas as verificações.
            Gramatica.getProducoes().Add(new Producao(ladoEsquerdo, ladoDireito));
            foreach (Producao p in Gramatica.getProducoes())
                Console.WriteLine("Producao: " + p.esquerdo + " -> " + p.direito);






            ///TODO: Remover isso talvez, uma vez que essa verificação já foi feita quando o símbolo não terminal foi adicionado na gramática
            /*if (!Regex.Matches((ladoDireito[0].ToString(), @"[a-z0-9&]"){
                MessageBox.Show("Lado esquerdo inválido, verifique sua produção.\nGramáticas regulares devem conter apenas .", "Verifique sua produção.");
            }
            */

            /*
            Dá pra remover isso eu acho também, mas sipa da pra usar na parte dos livres de contexto, então deixa aí sei lá
            for (int c = 0;c < ladoDireito.Length; c++) {
                if (!Gramatica.getNaoTerminais().Contains(ladoDireito[c].ToString())) {
                    MessageBox.Show("Algum simbolo não terminal que você está tentando adicionar não está no conjunto de não terminais, tente novamente.",
                        "Verifique seu´símbolo.");
                    return;
                }
            }
            */

        }


    }
}
