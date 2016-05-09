using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFormaisParteUm {
    class GeradorDeProducoes {

        string producao;

        public string gerarProducoesRegulares(Label label, int maximo) {
            
            producao = "";
            Random rnd = new Random();

            Producao geradora = Gramatica.getProducoes().Find(x => x.esquerdo == Gramatica.simboloGerador);

            int pos = rnd.Next(geradora.direitos.Count);
            producao += geradora.direitos[pos];

            produzir(producao, rnd, maximo, 0, label);

            return producao;
        }



        private void produzir(string producao, Random rnd, int max, int index, Label label) {

            foreach(char c in producao) {
                if (Regex.Matches(c.ToString(), @"[A-Z]").Count == 1 && index != max){
                    Producao p = Gramatica.getProducoes().Find(x => x.esquerdo == c.ToString());

                    int pos = rnd.Next(p.direitos.Count);
                    string novo = (p.direitos[pos] == "&") ? "" : p.direitos[pos];

                    producao = producao.Replace(c.ToString(), novo);
                    label.Text = producao;

                    produzir(producao, rnd, max, index+1, label);

                } else if (Regex.Matches(c.ToString(), @"[A-Z]").Count == 1 && index == max) {
                    Producao p = Gramatica.getProducoes().Find(x => x.esquerdo == c.ToString());

                    foreach(string s in p.direitos) {
                        if (Regex.Matches(s, @"[A-Z]").Count == 0) {
                            producao = producao.Replace(c.ToString(), s);
                            label.Text = producao;
                            break;
                        }
                    }
                }
            }

            


        }


    }
}
