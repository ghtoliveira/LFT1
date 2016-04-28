using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrabalhoFormaisParteUm {
    static class Gramatica {
        static List<string> simbolosTerminais = new List<string>();
        static List<string> simbolosNaoTerminais = new List<string>();
        static List<Producao> producoes = new List<Producao>();
        public static string simboloGerador { get; set; }

        public static bool adicionarTerminal(string simbolo) {
            foreach (string s in simbolosTerminais)
                if (s == simbolo)
                    return false;
            
            simbolosTerminais.Add(simbolo);
            return true;
        }

        public static bool adicionarNaoTerminal(string simbolo) {
            foreach (string s in simbolosNaoTerminais)
                if (s == simbolo)
                    return false;

            simbolosNaoTerminais.Add(simbolo);
            return true;
        }
        

        // Boa sorte tentando melhorar esse método, ele deve ser minimizado para que nunca mais seja aberto. 
        public static string atualizarLabelGramatica() {
            string terminais = "";
            string naoTerminais = "";
            int cAdicionados = 0;
            foreach (string s in simbolosTerminais) {
                if (cAdicionados == 0)
                    terminais += s;
                else
                    terminais += "," + s;
                cAdicionados++;
            }

            cAdicionados = 0;
            foreach (string s in simbolosNaoTerminais) {
                if (cAdicionados == 0)
                    naoTerminais += s;
                else
                    naoTerminais += "," + s;
                cAdicionados++;
            }

            //string gramatica = String.Format("G:({" + "{0}" + "}, " + "{1}" + "}, P, {" + "{2}" + "})", naoTerminais, terminais, "S");
            //Falta formatar esse carajo pra ter os {} antes dos conjuntos
            //string gramatica = String.Format("G:({0}, {1}, P, {2})", naoTerminais, terminais, simboloGerador);
            string gramatica = "G:({" + naoTerminais + "}, {" + terminais + "},P," + simboloGerador + ")";
            return gramatica;
        }

        public static List<string> getTerminais() {
            return simbolosTerminais;
        }

        public static List<string> getNaoTerminais() {
            return simbolosNaoTerminais;
        }

        public static List<Producao> getProducoes() {
            return producoes;
        }

    }
}
