using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFormaisParteUm {
    static class GeradorDeProducoes {
        public static string gerarProducoesRegulares(int nProducoes) {
            ///TODO: Terminar essa classe.
            ///Provavelmente teremos que mudar a classe Producao para facilitar a o geramento de sentenças aqui visto que um mesmo símbolo NT
            ///A pode ter n produções, como A -> aA | a.
            ///Assim, podemos fazer com o a parte do lado direito dos objetos de producao sejam um vetor, ao invés de adicionar duas producões. 
            ///Mas não tenho certeza, ver melhor isso...
            ///E também falta começar pelo símbolo gerador. 

            List<Producao> producoes = Gramatica.getProducoes();
            int pos = 0;
            string producao = "";
            Random rnd = new Random();
            for (int c = 0; c < nProducoes; c++) {
                pos = rnd.Next(producoes.Count());

                producao += producoes.ElementAt(pos).direitos;
                
            }


            Console.WriteLine(producao);

            return producao;
        }



    }
}
