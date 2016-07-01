using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TrabalhoFormaisParteUm {
    static class AdicionarProducao {

        public static bool adicionarProducaoRegular(string ladoEsquerdo, string ladoDireito) {



            //Verifica se o usuário não está tentando adicionar uma produção vazia ou se o usuário não está tentando adicionar uma produção inválida
            if (String.IsNullOrWhiteSpace(ladoEsquerdo) || String.IsNullOrWhiteSpace(ladoDireito)) {
                MessageBox.Show("Produções não podem estar vazias.", "Verifique sua produção");
                return false;
            } else if (ladoEsquerdo.Length > 1 || ladoDireito.Length > 2) {
                MessageBox.Show("Lado esquerdo deve conter apenas um símbolo.\nLado direito deve conter no máximo dois símbolos.", "Verifique sua produção");
                return false;
            }

            //Verifica se a produção já existe
            foreach (Producao p in Gramatica.getProducoes()) {

                if (p.direitos[0] == ladoDireito && p.esquerdo == ladoEsquerdo) {
                    MessageBox.Show("Produção já adicionada, tente novamente!", "Verifique sua produção.");
                    return false;
                }
            }

            //Verifica se o lado esquerdo está nos não terminais
            if (!Gramatica.getNaoTerminais().Contains(ladoEsquerdo)) {
                MessageBox.Show("Símbolo não terminal não está na gramática, tente com um símbolo adicionado previamente.", "Verifique seu símbolo");
                return false;
            }

            //Verifica se o primeiro símbolo é um não terminal que foi adicionado ao conjunto de gramáticas anteriormente
            if (!Gramatica.getTerminais().Contains(ladoDireito[0].ToString())) {
                MessageBox.Show("Primeiro símbolo da produção não está na gramática, tente novamente.", "Verifique sua produção.");
                return false;
            }

            //E se for uma produção com dois símbolos ex: aS verifica se o segundo símbolo é um não terminal que foi adicionado à gramática anteriormente
            if (ladoDireito.Length > 1) {
                if (!Gramatica.getNaoTerminais().Contains(ladoDireito[1].ToString())) {
                    MessageBox.Show("Segundo símbolo da produção não está na gramática, tente novamente.", "Verifique sua produção.");
                    return false;
                }
            }


            //Adiciona a produção ao conjunto de produções pois passou por todas as verificações.
            Producao prod = Gramatica.getProducoes().Find(x => x.esquerdo == ladoEsquerdo);

            if (prod == null){
                Gramatica.getProducoes().Add(new Producao(ladoEsquerdo, ladoDireito));
            } else {
                prod.direitos.Add(ladoDireito);
            }
            

            return true;
        }


        public static bool adicionarProducaoLC(string ladoEsquerdo, string ladoDireito) {
            if (String.IsNullOrWhiteSpace(ladoEsquerdo) || String.IsNullOrWhiteSpace(ladoDireito)) {
                MessageBox.Show("Produções não podem estar vazias.", "Verifique sua produção");
                return false;
            }
            foreach (Producao p in Gramatica.getProducoes()) {

                if (p.direitos[0] == ladoDireito && p.esquerdo == ladoEsquerdo) {
                    MessageBox.Show("Produção já adicionada, tente novamente!", "Verifique sua produção.");
                    return false;
                }
            }
            if (!Gramatica.getNaoTerminais().Contains(ladoEsquerdo)) {
                MessageBox.Show("Símbolo não terminal não está na gramática, tente com um símbolo adicionado previamente.", "Verifique seu símbolo");
                return false;
            }

            

            foreach(char c in ladoDireito) {
                if (!c.ToString().Contains("&")) // Afim de realizar a remoção de palavra vazia será permitido que adicione palavra vazia
                {
                    if (!Gramatica.getTerminais().Contains(c.ToString()) && !Gramatica.getNaoTerminais().Contains(c.ToString()))
                    {
                        MessageBox.Show("Símbolo " + c.ToString() + " não está na gramática, tente com um símbolo adicionado previamente.", "Verifique seus símbolo");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Simbolo Vazio adicionado");
                }
                
            }

            Producao prod = Gramatica.getProducoes().Find(x => x.esquerdo == ladoEsquerdo);

            if (prod == null) {
                Gramatica.getProducoes().Add(new Producao(ladoEsquerdo, ladoDireito));
            } else {
                prod.direitos.Add(ladoDireito);
            }


            return true;


        } 



    }
}
