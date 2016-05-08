using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFormaisParteUm {
    class GeradorDeProducoes {

        string producao;

        public string gerarProducoesRegulares() {
            ///TODO: Terminar essa classe.
            ///Provavelmente teremos que mudar a classe Producao para facilitar a o geramento de sentenças aqui visto que um mesmo símbolo NT
            ///A pode ter n produções, como A -> aA | a.
            ///Assim, podemos fazer com o a parte do lado direito dos objetos de producao sejam um vetor, ao invés de adicionar duas producões. 
            ///Mas não tenho certeza, ver melhor isso...
            ///E também falta começar pelo símbolo gerador. 
            
            producao = "";
            Random rnd = new Random();

            Producao geradora = Gramatica.getProducoes().Find(x => x.esquerdo == Gramatica.simboloGerador);

            int pos = rnd.Next(geradora.direitos.Count);
            producao += geradora.direitos[pos];

            produzir(producao, rnd, 10, 0);

            Console.WriteLine("Producao final: " + producao);

            return producao;
        }



        private void produzir(string producao, Random rnd, int max, int index) {

            foreach(char c in producao) {
                if (Regex.Matches(c.ToString(), @"[A-Z]").Count == 1 && index != max){
                    
                    Producao p = Gramatica.getProducoes().Find(x => x.esquerdo == c.ToString());
                    int pos = rnd.Next(p.direitos.Count);
                    string novo = (p.direitos[pos] == "&") ? "" : p.direitos[pos];
                    producao = producao.Replace(c.ToString(), novo);
                    Console.WriteLine(producao + "\n" + c.ToString() + " " +  p.direitos[pos]);
                    produzir(producao, rnd, max, index+1);
                } else if (Regex.Matches(c.ToString(), @"[A-Z]").Count == 1 && index == max) {
                    Producao p = Gramatica.getProducoes().Find(x => x.esquerdo == c.ToString());

                    foreach(string s in p.direitos) {
                        if (Regex.Matches(s, @"[A-Z]").Count == 0) {
                            producao = producao.Replace(c.ToString(), s);
                            break;
                        }
                    }
                    Console.WriteLine(producao);
                }
            }

            


        }


    }
}
